using LoansApp.Core.Application.DTOs.Loan;
using LoansApp.Core.Application.DTOs.Payment;
using LoansApp.Core.Application.DTOs.Record;
using LoansApp.Core.Application.Interfaces.Services;
using LoansApp.Core.Domain.Entities;

namespace LoansApp.UserControls
{
    public partial class PaymentControl : UserControl
    {
        private LoansForm _form;
        private LoansRecordControl historial;
        private readonly IPaymentService _paymentService;
        private readonly IRecordService _recordService;
        private readonly ILoanService _loanService;
        private List<ViewLoan> _loans = new();
        private List<ViewPayment> _payments = new();
        private int _currentIndex = 0;
        Dictionary<int, string> monthlyOrder = new Dictionary<int, string>
        {
            [1] = "January",
            [2] = "February",
            [3] = "March",
            [4] = "April",
            [5] = "May",
            [6] = "June",
            [7] = "July",
            [8] = "August",
            [9] = "September",
            [10] = "October",
            [11] = "November",
            [12] = "December"
        };

        public PaymentControl(LoansForm form, IRecordService recordService, IPaymentService paymentService, ILoanService loanService)
        {
            InitializeComponent();
            _form = form;
            _recordService = recordService;
            historial = new(recordService);
            _paymentService = paymentService;
            _loanService = loanService;
        }

        private async void AddPaymentControl_Load(object sender, EventArgs e)
        {
            _loans = await _loanService.GetAllAsync();
            GetData(_loans[_currentIndex].ID);
            ShowLoanAtIndex(_currentIndex);
            dataGridView1.Font = new Font("Arial", 14);
            if (DateTime.Now.Day >= 9 && DateTime.Now.Day < 20)
            {
                Day.Text = 9.ToString();
            }
            else
            {
                Day.Text = 24.ToString();
            }
            Month.Text = monthlyOrder[DateTime.Now.Month];
            Year.Text = DateTime.Now.Year.ToString();

        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
             _loans = await _loanService.GetAllAsync();
            if (string.IsNullOrWhiteSpace(Day.Text) ||
                string.IsNullOrWhiteSpace(Month.Text) ||
                string.IsNullOrWhiteSpace(Year.Text))
            {
                MessageBox.Show("All the fields are required.");
                return;
            }
            Loan loan = new()
            {
                ID = _loans[_currentIndex].ID,
                Name = _loans[_currentIndex].Name,
                Interest = _loans[_currentIndex].Interest,
                Capital = _loans[_currentIndex].Capital,
                LoanBalance = _loans[_currentIndex].LoanBalance,
                Number = _loans[_currentIndex].Number,
                PayDay = _loans[_currentIndex].PayDay,
                RemainingFees = _loans[_currentIndex].RemainingFees,
                TotalIncome = _loans[_currentIndex].TotalIncome,
                Value = _loans[_currentIndex].Value
            };
            SaveLoan saveLoan = new()
            {
                ID = loan.ID,
                Name = loan.Name,
                Interest = loan.Interest,
                Capital = loan.Capital,
                LoanBalance = (int.Parse(loan.LoanBalance) - int.Parse(loan.Capital)).ToString(),
                Number = loan.Number,
                PayDay = loan.PayDay,
                RemainingFees = (int.Parse(loan.RemainingFees) - 1).ToString(),
                TotalIncome =   loan.TotalIncome,
                Value = loan.Value
            };
            SavePayment savePayment = new()
            {
                Day = Day.Text,
                Month = Month.Text,
                Year = Year.Text,
                Amount = int.Parse(Income.Text.Trim()),
                MonthDay = $"{Day.Text} / {Month.Text}",
                LoanID = loan.ID,
                Loan = loan
            };
            _payments = await _paymentService.GetByLoanIdAsync(_loans[_currentIndex].ID);
            SaveRecord saveRecord = new()
            {
                Name = loan.Name,
                loanNumber = loan.Number,
                EndDate = DateTime.Now.ToShortDateString(),
                MonthlyIncome = loan.TotalIncome,
                MonthlyInterest = loan.Interest,
                MonthlyCapital = loan.Capital,
                LoanValue = loan.Value,
                TotalInterestIncomes = (int.Parse(loan.Interest) * (_payments.Count() + 1)).ToString()
            };
            try
            {
                if ( (int.Parse(loan.RemainingFees) <= 1) && (int.Parse(saveLoan.LoanBalance) <= int.Parse(loan.Capital)) )
                {
                    await _paymentService.AddAsync(savePayment, saveLoan);
                    await _recordService.AddAsync(saveRecord);
                    await _loanService.DeleteAsync(loan.ID);
                    MessageBox.Show("Last payment was succesfully applied to the loan.");
                    await _form.ShowView(historial);
                }
                else
                {
                    await _paymentService.AddAsync(savePayment, saveLoan);
                    MessageBox.Show("Pay was succesfully applied to the loan.");
                    GetData(_loans[_currentIndex].ID);
                }
                feesLeft.Text = saveLoan.RemainingFees;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error ocurred while applying the pay to the loan: {ex.Message}");
                return;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Day.Text = string.Empty;
            Month.Text = string.Empty;
            Year.Text = string.Empty;
        }

        private void ShowLoanAtIndex(int index)
        {
            if (_loans.Count == 0) return;

            index = Math.Clamp(index, 0, _loans.Count - 1);

            _currentIndex = index;

            var loan = _loans[_currentIndex];
            name.Text = loan.Name;
            Number.Text = loan.Number;
            Income.Text = loan.TotalIncome;
            feesLeft.Text = loan.RemainingFees;

            backButton.Enabled = _currentIndex > 0;
            nextButton.Enabled = _currentIndex < _loans.Count - 1;
        }

        private void ConfigureDataGrid()
        {

            dataGridView1.Font = new Font("Arial", 12);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
        }

        public async void GetData(int id)
        {
            try
            {
                _payments = await _paymentService.GetByLoanIdAsync(id);
                var data = _paymentService.MapPaymentsToDataTable(_payments);
                dataGridView1.DataSource = data;
                ConfigureDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (_currentIndex < _loans.Count - 1)
            {
                ShowLoanAtIndex(_currentIndex + 1);
                GetData(_loans[_currentIndex].ID);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (_currentIndex > 0)
            {
                ShowLoanAtIndex(_currentIndex - 1);
                GetData(_loans[_currentIndex].ID);
            }
        }
    }
}
