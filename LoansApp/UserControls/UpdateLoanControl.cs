using LoansApp.Core.Application.DTOs.Loan;
using LoansApp.Core.Application.Helpers;
using LoansApp.Core.Application.Interfaces.Services;

namespace LoansApp.UserControls
{
    public partial class UpdateLoanControl : UserControl
    {
        private LoansForm _form;
        private HomeControl _home;
        private readonly ILoanService _loanService;
        private readonly SaveLoan _saveLoan;

        public UpdateLoanControl(HomeControl home, LoansForm form, SaveLoan saveLoan, ILoanService loanService)
        {
            InitializeComponent();
            _form = form;
            _home = home;
            _loanService = loanService;
            _saveLoan = saveLoan;
            LoadData();
        }

        private async void updateButton_Click(object sender, EventArgs e)
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

            var result = MessageBox.Show(
                    $"Are you sure you want to update {name.Text}'s Loan, number {number.Text}, which has a value of RD${value.Text}?\n" +
                    "This cannot be undone.",
                    "Confirm update.",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                _saveLoan.Name = name.Text.Trim();
                _saveLoan.Number = number.Text.Trim();
                _saveLoan.PayDay = payDay.Text.Trim();
                _saveLoan.TotalIncome = totalIncome.Text.Trim();
                _saveLoan.Interest = interest.Text.Trim();
                _saveLoan.Capital = capital.Text.Trim();
                _saveLoan.Value = value.Text.Trim();
                _saveLoan.RemainingFees = fees.Text.Trim();

            if (result == DialogResult.OK)
            {
                try
                {
                    await _loanService.UpdateAsync(_saveLoan, _saveLoan.ID);
                    MessageBox.Show("Successfully updated Loan");
                    await _form.ShowView(_home);

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"An error ocurred while trying to update the Loan: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("The loan has not been updated.");
            }
        }

        private async void cancelButton_Click(object sender, EventArgs e)
        {
            await _form.ShowView(_home);
        }

        private bool ValidateRequiredFields()
        {
            var fields = new[] { name, number, payDay, fees, totalIncome, interest, capital };
            return fields.All(c => !string.IsNullOrWhiteSpace(c.Text.Trim()));
        }

        private void LoadData()
        {
            name.Text = _saveLoan.Name;
            number.Text = _saveLoan.Number;
            payDay.Text = _saveLoan.PayDay;
            totalIncome.Text = _saveLoan.TotalIncome;
            interest.Text = _saveLoan.Interest;
            capital.Text = _saveLoan.Capital;
            value.Text = _saveLoan.Value;
            fees.Text = _saveLoan.RemainingFees;
        }

        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void OnlyNumbersAllow(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
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