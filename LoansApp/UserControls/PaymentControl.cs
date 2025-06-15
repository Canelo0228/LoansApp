using LoansApp.Core.Application.DTOs.Loan;
using LoansApp.Core.Application.DTOs.Payment;
using LoansApp.Core.Application.Interfaces.Services;

namespace LoansApp.UserControls
{
    public partial class PaymentControl : UserControl
    {
        private LoansForm _form;
        private LoansRecordControl historial;
        private readonly IPaymentService _paymentService;
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
            SavePayment savePayment = new()
            {
                LoanID = _loans[_currentIndex].ID,
                Amount = int.Parse(Income.Text.Trim()),
                Day = Day.Text,
                Month = Month.Text,
                Year = Year.Text
            };
            try
            {
                var lastPayment = await _paymentService.ApplyPaymentAsync(savePayment);
                if (lastPayment)
                {
                    MessageBox.Show("Payment applied successfully.");
                    await _form.ShowView(historial);
                }
                MessageBox.Show("Payment applied successfully.");
                GetData(_loans[_currentIndex].ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error ocurred: {ex.Message}");
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
