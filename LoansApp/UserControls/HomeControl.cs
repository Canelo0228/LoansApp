using LoansApp.Core.Application.DTOs.Loan;
using LoansApp.Core.Application.Interfaces.Services;
using System.Data;

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
                var data = MapLoansToDataTable(loans);
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
                var loans = await _loanService.GetAllWithFilterAsync(Parameter.Text, parameterValue.Text);
                if (loans != null && loans.Any())
                {
                    var data = MapLoansToDataTable(loans);
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
                    $"Are you sure you want to delete {loan.CustomerName}'s loan with a value of RD${loan.OriginalLoanAmount}?\n" +
                    "This action cannot be undone.",
                    "Confirm Delection",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.OK)
                {
                    try
                    {
                        await _loanService.DeleteAsync(loan.Id);
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

            if (selectedRow == null || selectedRow.Index < 0 || selectedRow.Cells["Id"].Value == null)
            {
                MessageBox.Show("No row is selected or the grid is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            try
            {
                return new SaveLoan
                {
                    Id = int.Parse(selectedRow.Cells["Id"].Value?.ToString() ?? "0"),
                    CustomerName = selectedRow.Cells["Customer Name"].Value?.ToString(),
                    PaymentDay = int.Parse(selectedRow.Cells["Payment Day"].Value?.ToString() ?? "0"),
                    MonthlyPayment = decimal.Parse(selectedRow.Cells["Monthly Income"].Value?.ToString()),
                    MonthlyInterest = decimal.Parse(selectedRow.Cells["Monthly Interest"].Value?.ToString()),
                    MonthlyPrincipal = decimal.Parse(selectedRow.Cells["Monthly Principal"].Value?.ToString()),
                    OriginalLoanAmount = decimal.Parse(selectedRow.Cells["Value"].Value?.ToString()),
                    OutstandingBalance = decimal.Parse(selectedRow.Cells["Loan Balance"].Value?.ToString()),
                    RemainingInstallments = int.Parse(selectedRow.Cells["Remaining Fees"].Value?.ToString())
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

        public DataTable MapLoansToDataTable(List<ViewLoan> loans)
        {
            DataTable table = new();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Customer Name", typeof(string));
            table.Columns.Add("Payment Day", typeof(int));
            table.Columns.Add("Monthly Income", typeof(decimal));
            table.Columns.Add("Monthly Interest", typeof(decimal));
            table.Columns.Add("Monthly Principal", typeof(decimal));
            table.Columns.Add("Value", typeof(decimal));
            table.Columns.Add("Loan Balance", typeof(decimal));
            table.Columns.Add("Remaining Fees", typeof(int));

            foreach (var loan in loans)
            {
                table.Rows.Add(
                    loan.Id,
                    loan.CustomerName,
                    loan.PaymentDay,
                    loan.MonthlyPayment,
                    loan.MonthlyInterest,
                    loan.MonthlyPrincipal,
                    loan.OriginalLoanAmount,
                    loan.OutstandingBalance,
                    loan.RemainingInstallments
                );
            }

            return table;
        }
    }
}