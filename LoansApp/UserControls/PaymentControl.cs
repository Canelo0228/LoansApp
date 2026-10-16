using LoansApp.Core.Application.DTOs.Loan;
using LoansApp.Core.Application.DTOs.Payment;
using LoansApp.Core.Application.Interfaces.Services;

namespace LoansApp.UserControls
{
    public partial class PaymentControl : UserControl
    {
        private LoansForm _form;
        private HomeControl _home;
        private LoansRecordControl historial;
        private readonly IPaymentService _paymentService;
        private readonly ILoanService _loanService;
        private List<ViewLoan> _loans = new();
        private List<ViewPayment> _payments = new();
        private int _currentIndex = 0;

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
            GetData(_loans[_currentIndex].Id);
            ShowLoanAtIndex(_currentIndex);
            dataGridView1.Font = new Font("Arial", 14);
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            SavePayment savePayment = new()
            {
                LoanId = _loans[_currentIndex].Id,
                Amount = decimal.Parse(Income.Text.Trim()),
                Date = DateOnly.FromDateTime(DateTime.UtcNow)
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
                GetData(_loans[_currentIndex].Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error ocurred: {ex.Message}");
                return;
            }
        }

        private void ShowLoanAtIndex(int index)
        {
            if (_loans.Count == 0) return;

            index = Math.Clamp(index, 0, _loans.Count - 1);

            _currentIndex = index;

            var loan = _loans[_currentIndex];
            name.Text = loan.CustomerName;
            Income.Text = loan.MonthlyPayment.ToString();
            feesLeft.Text = loan.RemainingInstallments.ToString();

            backButton.Enabled = _currentIndex > 0;
            nextButton.Enabled = _currentIndex < _loans.Count - 1;
        }

        public async void GetData(int id)
        {
            try
            {
                _payments = await _paymentService.GetByLoanIdAsync(id);
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
                GetData(_loans[_currentIndex].Id);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (_currentIndex > 0)
            {
                ShowLoanAtIndex(_currentIndex - 1);
                GetData(_loans[_currentIndex].Id);
            }
        }

        private async void CancelButton_Click(object sender, EventArgs e)
        {
            await _form.ShowView(_home);
        }
    }
}
