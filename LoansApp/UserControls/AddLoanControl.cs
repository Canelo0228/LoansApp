using LoansApp.Core.Application.DTOs.Loan;
using LoansApp.Core.Application.Helpers;
using LoansApp.Core.Application.Interfaces.Services;

namespace LoansApp.UserControls
{
    public partial class AddLoanControl : UserControl
    {
        private LoansForm _form;
        private HomeControl _home;
        private readonly ILoanService _loanService;

        public AddLoanControl(HomeControl home, LoansForm form, ILoanService loanService)
        {
            InitializeComponent();
            _form = form;
            _home = home;
            _loanService = loanService;
        }

        private async void AddLoanButton(object sender, EventArgs e)
        {
            if (!ValidateRequiredFields())
            {
                ShowWarning("All the fields are required.");
                return;
            }

            List<string> errors = new();

            if (TryParseLoanFields(out int incomeAmount, out int valueAmount, out int capitalAmount, out int interestAmount))
            {
                if (incomeAmount <= 0 || valueAmount <= 0)
                    errors.Add("The total income and the loan value can't be 0");

                if (incomeAmount > valueAmount)
                    errors.Add("The total income can't be bigger than the loan value.");

                if (capitalAmount <= 0 || interestAmount <= 0)
                    errors.Add("The interest and the capital amounts can't be 0.");

                if (incomeAmount <= interestAmount)
                    errors.Add("The interest amount can't be equal to the total income.");

                if (errors.Any())
                {
                    MessageBox.Show(string.Join("\n", errors), "Validation issues", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                ShowWarning("Only numbers are allow in amounts fields.");
                return;
            }

            SaveLoan saveLoan = new()
            {
                ID = 0,
                Name = name.Text.Trim(),
                Number = number.Text.Trim(),
                PayDay = payDay.Text.Trim(),
                TotalIncome = totalIncome.Text.Trim(),
                Interest = interest.Text.Trim(),
                Capital = capital.Text.Trim(),
                Value = value.Text.Trim(),
                LoanBalance = value.Text.Trim(),
                RemainingFees = fees.Text.Trim()
            };

            try
            {
                await _loanService.AddAsync(saveLoan);
                MessageBox.Show("Successfully added Loan.");
                await _form.ShowView(_home);
            }
            catch (Exception ex)
            {

                ShowWarning($"An error ocurred adding the loan: {ex.Message}");
            }
        }

        private async void CancelButton(object sender, EventArgs e)
        {
            await _form.ShowView(_home);
        }

        private bool ValidateRequiredFields()
        {
            var fields = new[] { name, number, payDay, fees, totalIncome, interest, capital };
            return fields.All(c => !string.IsNullOrWhiteSpace(c.Text.Trim()));
        }

        private void OnlyNumbersAllow(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool TryParseLoanFields(out int incomeAmount, out int valueAmount, out int capitalAmount, out int interestAmount)
        {
            bool successIncome = int.TryParse(totalIncome.Text, out incomeAmount);
            bool successFee = int.TryParse(value.Text, out valueAmount);
            bool successCapital = int.TryParse(capital.Text, out capitalAmount);
            bool successInterest = int.TryParse(interest.Text, out interestAmount);

            return successIncome && successFee && successCapital && successInterest;
        }

        private void CalculateFees(object sender, EventArgs e)
        {
            TryParseLoanFields(out int incomeAmount, out int valueAmount, out int capitalAmount, out int interestAmount);
            fees.Text = LoanHelper.CalculateFees(valueAmount, capitalAmount).ToString();
        }

        private void CalculateInterest(object sender, EventArgs e)
        {
            TryParseLoanFields(out int incomeAmount, out int valueAmount, out int capitalAmount, out int interestAmount);
            interest.Text = LoanHelper.CalculateInterest(incomeAmount, capitalAmount).ToString();
        }

        private void CalculateCapital(object sender, EventArgs e)
        {
            TryParseLoanFields(out int incomeAmount, out int valueAmount, out int capitalAmount, out int interestAmount);
            capital.Text = LoanHelper.CalculateCapital(incomeAmount, interestAmount).ToString();
            CalculateFees(sender, e);
        }

    }
}