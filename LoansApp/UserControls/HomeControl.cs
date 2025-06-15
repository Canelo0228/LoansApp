using LoansApp.Core.Application.DTOs.Loan;
using LoansApp.Core.Application.Interfaces.Services;

namespace LoansApp.UserControls
{
    public partial class HomeControl : UserControl
    {
        private readonly ILoanService _loanService;
        public HomeControl(ILoanService loanService)
        {
            _loanService = loanService;
            InitializeComponent();
        }
        private async void Home_Load(object sender, EventArgs e)
        {
            await GetData();
        }

        public async Task GetData()
        {
            try
            {
                var loans = await _loanService.GetAllAsync();
                var data = _loanService.MapLoansToDataTable(loans);
                dataGridView1.DataSource = data;
                ConfigureDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error has ocurred while trying to load the Loans: {ex.Message}");
            }
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Parameter.Text) ||
                string.IsNullOrWhiteSpace(parameterValue.Text))
            {
                MessageBox.Show("Search parameters cannot be empty");
                return;
            }
            try
            {
                var loans = await _loanService.GetAllWithFilter(Parameter.Text, parameterValue.Text);
                if (loans != null && loans.Any())
                {
                    var data = _loanService.MapLoansToDataTable(loans);
                    dataGridView1.DataSource = data;
                    ConfigureDataGrid();
                }
                else
                {
                    MessageBox.Show("No Loans found matching the search parameters");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error ocurred while searching the Loans: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void cancelButton_Click(object sender, EventArgs e)
        {
            this.Parameter.Text = string.Empty;
            this.parameterValue.Text = string.Empty;
            await GetData();
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            var loan = GetSelectedRow();
            if (loan != null)
            {
                var result = MessageBox.Show(
                    $"Are you sure you want to delete {loan.Name}'s loan with a value of RD${loan.Value}?\n" +
                    "This action cannot be undone.",
                    "Confirm Delection",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.OK)
                {
                    try
                    {
                        await _loanService.DeleteAsync(loan.ID);
                        await GetData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting the loan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The Loan hasn't been deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public SaveLoan GetSelectedRow()
        {
            var selectedRow = dataGridView1.CurrentRow;

            if (selectedRow == null || selectedRow.Index < 0 || selectedRow.Cells["ID"].Value == null)
            {
                MessageBox.Show("No row is selected or the grid is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            try
            {
                return new SaveLoan
                {
                    ID = int.Parse(selectedRow.Cells["ID"].Value?.ToString() ?? "0"),
                    Name = selectedRow.Cells["Name"].Value?.ToString(),
                    Number = selectedRow.Cells["Number"].Value?.ToString(),
                    PayDay = selectedRow.Cells["PayDay"].Value?.ToString(),
                    TotalIncome = selectedRow.Cells["Monthly Income"].Value?.ToString(),
                    Interest = selectedRow.Cells["Interest"].Value?.ToString(),
                    Capital = selectedRow.Cells["Capital"].Value?.ToString(),
                    Value = selectedRow.Cells["Value"].Value?.ToString(),
                    LoanBalance = selectedRow.Cells["Loan Balance"].Value?.ToString(),
                    RemainingFees = selectedRow.Cells["Remaining Fees"].Value?.ToString()
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading row data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //Private Methods
        private void ConfigureDataGrid()
        {

            dataGridView1.Font = new Font("Arial", 12);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
        }
    }
}