using PrestamosApp.UserControls;

namespace PrestamosApp
{
    public partial class Prestamos : Form
    {
        private Inicio inicio;
        public Prestamos()
        {
            InitializeComponent();
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            inicio = new Inicio();
            MostrarVista(inicio);
        }

        public void MostrarVista(UserControl userControl)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl);
            inicio.CargarDatosIniciales();
            userControl.Dock = DockStyle.Fill;
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            var vistaExistente = panelMain.Controls
                .OfType<Inicio>()
                .FirstOrDefault();

            if (vistaExistente == null)
            {
                var nuevaVista = inicio;
                MostrarVista(nuevaVista);
            }
            else
            {
                vistaExistente.BringToFront();
            }
        }

        private void registrarPrestamo_Click(object sender, EventArgs e)
        {
            var vistaExistente = panelMain.Controls
                .OfType<RegistrarPrestamoControl>()
                .FirstOrDefault();

            if (vistaExistente == null)
            {
                var nuevaVista = new RegistrarPrestamoControl(inicio, this);
                MostrarVista(nuevaVista);
            }
            else
            {
                vistaExistente.BringToFront();
            }
        }

        private void editarPrestamo_Click(object sender, EventArgs e)
        {
            if (inicio.dataGridView1.CurrentRow != null)
            {
                var filaSeleccionada = inicio.dataGridView1.CurrentRow;

                string id = filaSeleccionada.Cells["ID"].Value?.ToString();
                string name = filaSeleccionada.Cells["NOMBRE"].Value?.ToString();
                string number = filaSeleccionada.Cells["#"].Value?.ToString();
                string dia = filaSeleccionada.Cells["DIA DE PAGO"].Value?.ToString();
                string cobro = filaSeleccionada.Cells["COBRO TOTAL"].Value?.ToString();
                string interes = filaSeleccionada.Cells["INTERES"].Value?.ToString();
                string capital = filaSeleccionada.Cells["CAPITAL"].Value?.ToString();
                string valor = filaSeleccionada.Cells["VALOR PRESTAMO"].Value?.ToString();
                string cuotas = filaSeleccionada.Cells["CUOTAS"].Value?.ToString();

                var vistaExistente = panelMain.Controls
                .OfType<EditarPrestamoControl>()
                .FirstOrDefault();

                if (vistaExistente == null)
                {
                    var nuevaVista = new EditarPrestamoControl(inicio, this, id, name, number, dia, cobro, interes, capital, valor, cuotas);
                    MostrarVista(nuevaVista);
                }
                else
                {
                    vistaExistente.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un prestamo antes de editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void registrarPago_Click(object sender, EventArgs e)
        {
            if (inicio.dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("Para registrar pagos, primero debes registrar un prestamo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var vistaExistente = panelMain.Controls
                .OfType<RegistrarPagoControl>()
                .FirstOrDefault();

            if (vistaExistente == null)
            {
                var nuevaVista = new RegistrarPagoControl(inicio, this);
                MostrarVista(nuevaVista);
            }
            else
            {
                vistaExistente.BringToFront();
            }
        }

        private void historial_Click(object sender, EventArgs e)
        {
            var vistaExistente = panelMain.Controls
                .OfType<HistorialControl>()
                .FirstOrDefault();

            if (vistaExistente == null)
            {
                var nuevaVista = new HistorialControl(inicio, this);
                MostrarVista(nuevaVista);
            }
            else
            {
                vistaExistente.BringToFront();
            }
        }
    }
}
