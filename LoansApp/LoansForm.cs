using LoansApp.Core.Application.Interfaces.Services;
using LoansApp.UserControls;

namespace LoansApp
{
    public partial class LoansForm : Form
    {
        private HomeControl home;
        private readonly ILoanService _loanService;
        private readonly IPaymentService _paymentService;
        private readonly IRecordService _recordService;

        public LoansForm(ILoanService loanService, IRecordService recordService, IPaymentService paymentService)
        {
            InitializeComponent();

            _loanService = loanService;
            _recordService = recordService;
            _paymentService = paymentService;
        }

        private async void Loans_Load(object sender, EventArgs e)
        {
            home = new HomeControl(_loanService);
            await ShowView(home);
        }

        public async Task ShowView(UserControl userControl)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            await home.GetData();
        }

        private async void GoToHome_Click(object sender, EventArgs e)
        {
            await NavigateToControl(() => home);
        }

        private async void AddLoan_Click(object sender, EventArgs e)
        {
            await NavigateToControl(() => new AddLoanControl(home, this, _loanService));
        }

        private async void UpdateLoan_Click(object sender, EventArgs e)
        {
            var loan = home.GetSelectedRow();
            if (loan != null)
            {
                await NavigateToControl(() => new UpdateLoanControl(home, this, loan, _loanService));
            }
            else
            {
                return;
            }
        }

        private async void AddPayment_Click(object sender, EventArgs e)
        {
            var loan = home.GetSelectedRow();

            if (loan != null)
            {
                await NavigateToControl(() => new PaymentControl(this, _recordService, _paymentService, _loanService));
            }
            else
            {
                return;
            }
        }

        private async void GoToLoansRecord_Click(object sender, EventArgs e)
        {
            await NavigateToControl(() => new LoansRecordControl(_recordService));
        }
        
        //Private Methods
        
        private async Task NavigateToControl<Control>(Func<Control> createView) where Control : UserControl
        {
            var existingView = panelMain.Controls.OfType<Control>().FirstOrDefault();

            if (existingView == null)
            {
                await ShowView(createView());
            }
            else
            {
                existingView.BringToFront();
            }
        }
        
        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
