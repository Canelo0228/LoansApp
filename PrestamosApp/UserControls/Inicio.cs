using PrestamosApp.BD;
using System.Data;
using System.Globalization;

namespace PrestamosApp.UserControls
{
    public partial class Inicio : UserControl
    {

        public Inicio()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            InitializeComponent();
            CargarDatosIniciales();
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            CargarDatosIniciales();
            dataGridView1.Font = new Font("Arial", 12);
        }

        public void CargarDatosIniciales()
        {
            try
            {
                DataTable datos = Datos.ObtenerDatos();
                dataGridView1.DataSource = datos;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ScrollBars = ScrollBars.Vertical;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos iniciales: " + ex.Message);
            }
        }

        public void buscarDatos()
        {
            try
            {
                DataTable datos = Datos.buscarPrestamo(parametro.Text, valorParametro.Text);
                if (datos != null && datos.Rows.Count > 0)
                {
                    dataGridView1.DataSource = datos;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.ScrollBars = ScrollBars.Vertical;
                }
                else
                {
                    MessageBox.Show("No existen prestamos con esas caracteristicas");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el prestamo: " + ex.Message);
            }
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(parametro.Text) ||
                string.IsNullOrWhiteSpace(valorParametro.Text))
            {
                MessageBox.Show("Los campos de busqueda estan vacios");
                return;
            }
            buscarDatos();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.parametro.Text = string.Empty;
            this.valorParametro.Text = string.Empty;
            CargarDatosIniciales();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var filaSeleccionada = dataGridView1.CurrentRow;

                string id = filaSeleccionada.Cells["ID"].Value?.ToString();
                string name = filaSeleccionada.Cells["NOMBRE"].Value?.ToString();
                string valor = filaSeleccionada.Cells["VALOR PRESTAMO"].Value?.ToString();

                var resultado = MessageBox.Show(
                    $"¿Estás seguro de que deseas eliminar este préstamo de {name} que tiene un valor de {valor}? \n" +
                    "Esta accion no puede ser revertida.",
                    "Confirmar Eliminación",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.OK)
                {
                    string res = "";
                    Datos datos = new Datos();
                    res = datos.eliminarRegistro(Convert.ToInt32(id));
                    if (res.Equals("OK"))
                    {
                        MessageBox.Show("Prestamo eliminado con Exito");
                        CargarDatosIniciales();
                    }
                    else
                    {
                        MessageBox.Show("Un error ha ocurrido, el prestamo no ha sido eliminado");
                    }
                }
                else
                {
                    MessageBox.Show("El prestamo no ha sido eliminado.");
                }
            }
            else
            {
                MessageBox.Show(
                    "Por favor, selecciona un prestamo antes de eliminar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }


        }
    }
}