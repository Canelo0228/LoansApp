using LoansApp.Core.Application.Interfaces.Services;

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
                var data = _recordService.MapRecordsToDataTable(records);
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
    }
}
