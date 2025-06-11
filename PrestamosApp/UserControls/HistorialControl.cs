using PrestamosApp.BD;
using System.Data;

namespace PrestamosApp.UserControls
{
    public partial class HistorialControl : UserControl
    {
        private Prestamos form;
        private Inicio inicio;
        public HistorialControl(Inicio inicio, Prestamos form)
        {
            InitializeComponent();
            this.form = form;
            this.inicio = inicio;
        }

        private void HistorialControl_Load(object sender, EventArgs e)
        {
            CargarDatosIniciales();
            dataGridView1.Font = new Font("Arial", 13);
        }

        public void CargarDatosIniciales()
        {
            try
            {
                DataTable datos = Datos.ObtenerHistorial();
                dataGridView1.DataSource = datos;
                var filaSeleccionada = dataGridView1.CurrentRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos iniciales: " + ex.Message);
            }
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            form.MostrarVista(inicio);
        }
    }
}
