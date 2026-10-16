using LoansApp.Core.Application.DTOs.Record;
using LoansApp.Core.Application.Interfaces.Services;
using System.Data;

namespace LoansApp.UserControls
{
    public partial class LoansRecordControl : UserControl
    {
        private readonly IRecordService _recordService;
        public LoansRecordControl(IRecordService recordService)
        {
            InitializeComponent();
            _recordService = recordService;
        }

        private async void HistorialControl_Load(object sender, EventArgs e)
        {
            await GetData();
            dataGridView1.Font = new Font("Arial", 13);
        }

        public async Task GetData()
        {
            try
            {
                var records = await _recordService.GetAllAsync();
                var data = MapRecordsToDataTable(records);
                dataGridView1.DataSource = data;
                ConfigureDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error has ocurred while trying to load the Loans Records: {ex.Message}");
            }
        }

        //Private Methods
        private void ConfigureDataGrid()
        {

            dataGridView1.Font = new Font("Arial", 12);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
        }

        private DataTable MapRecordsToDataTable(List<ViewRecord> entities)
        {
            DataTable table = new();
            table.Columns.Add("Customer Name", typeof(string));
            table.Columns.Add("End Date", typeof(DateOnly));
            table.Columns.Add("Monthly Income", typeof(decimal));
            table.Columns.Add("Monthly Interest", typeof(decimal));
            table.Columns.Add("Monthly Capital", typeof(decimal));
            table.Columns.Add("Loan Value", typeof(decimal));
            table.Columns.Add("Total Interest Incomes", typeof(decimal));

            foreach (var entity in entities)
            {
                table.Rows.Add(
                    entity.CustomerName,
                    entity.EndDate,
                    entity.MonthlyPayment,
                    entity.MonthlyInterest,
                    entity.MonthlyPrincipal,
                    entity.OriginalLoanAmount,
                    entity.TotalInterestIncome
                );
            }

            return table;
        }
    }
}
