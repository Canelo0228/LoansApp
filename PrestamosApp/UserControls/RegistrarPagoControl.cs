using PrestamosApp.BD;
using PrestamosApp.Models;
using System.Data;

namespace PrestamosApp.UserControls
{
    public partial class RegistrarPagoControl : UserControl
    {
        private Prestamos form;
        private Inicio inicio;
        private HistorialControl historial;
        public RegistrarPagoControl(Inicio inicio, Prestamos form)
        {
            InitializeComponent();
            this.form = form;
            this.inicio = inicio;
            historial = new HistorialControl(inicio, form);
        }

        private void RegistrarPagoControl_Load(object sender, EventArgs e)
        {
            CargarDatosIniciales();
            dataGridView1.Font = new Font("Arial", 12);
            dataGridView2.Font = new Font("Arial", 13);
            this.comboBox1.Text = DateTime.Now.Year.ToString();
        }

        public void cargarPagosPrestamo(int id, int rango, string year)
        {
            try
            {
                DataTable datos = Datos.obtenerPagos(id, rango, year);
                dataGridView2.DataSource = datos;
                comboBox1.SelectedItem = year;
                if (rango == 1)
                {
                    comboBox2.SelectedItem = 1;
                }
                else
                {
                    comboBox2.SelectedItem = 2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pagos iniciales: " + ex.Message);
            }
        }

        public void CargarDatosIniciales()
        {
            try
            {
                DataTable datos = Datos.ObtenerDatos();
                dataGridView1.DataSource = datos;
                var filaSeleccionada = dataGridView1.CurrentRow;
                name.Text = filaSeleccionada.Cells["NOMBRE"].Value?.ToString();
                number.Text = filaSeleccionada.Cells["#"].Value?.ToString();
                cantidad.Text = filaSeleccionada.Cells["COBRO TOTAL"].Value?.ToString();
                cuotas.Text = filaSeleccionada.Cells["CUOTAS"].Value?.ToString();
                capital.Text = filaSeleccionada.Cells["CAPITAL"].Value?.ToString();
                balance.Text = filaSeleccionada.Cells["BALANCE PENDIENTE"].Value?.ToString();
                valor.Text = filaSeleccionada.Cells["VALOR PRESTAMO"].Value?.ToString();
                interes.Text = filaSeleccionada.Cells["INTERES"].Value?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos iniciales: " + ex.Message);
            }
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dia.Text) ||
                string.IsNullOrWhiteSpace(mes.Text) ||
                string.IsNullOrWhiteSpace(year.Text) ||
                string.IsNullOrWhiteSpace(cantidad.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un préstamo antes de aplicar el pago.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var fila = dataGridView1.CurrentRow;
            string id = fila.Cells["ID"].Value?.ToString();
            string nameStr = fila.Cells["NOMBRE"].Value?.ToString();
            string numberStr = fila.Cells["#"].Value?.ToString();
            string valorStr = fila.Cells["VALOR PRESTAMO"].Value?.ToString();
            string cuotasStr = fila.Cells["CUOTAS"].Value?.ToString();
            string capitalStr = fila.Cells["CAPITAL"].Value?.ToString();
            string balanceStr = fila.Cells["BALANCE PENDIENTE"].Value?.ToString();
            string interesStr = fila.Cells["INTERES"].Value?.ToString();

            Pagos pago = new Pagos
            {
                ID = id,
                Dia = dia.Text.Trim(),
                Mes = mes.Text.Trim(),
                Year = year.Text.Trim(),
                Cantidad = cantidad.Text.Trim(),
                MesDia = mes.Text.Trim() + dia.Text.Trim()
            };

            bool esUltimoPago = int.TryParse(cuotasStr, out int cuotasInt) &&
                                int.TryParse(capitalStr, out int capitalInt) &&
                                decimal.TryParse(balanceStr, out decimal balanceInt) &&
                                (balanceInt - capitalInt <= 0 && cuotasInt <= 1);

            string mensaje = $"¿Estás seguro de que deseas aplicar un pago al préstamo #{numberStr} perteneciente a {nameStr} que tiene un valor de {valorStr}?";
            if (esUltimoPago)
            {
                mensaje += "\nEste será el último pago para este préstamo. Este ya será saldado en su totalidad.\nEsta acción no puede ser revertida.";
                var confirmacion = MessageBox.Show(mensaje, "Confirmar pago", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (confirmacion == DialogResult.OK)
                {
                    Datos datos = new Datos();
                    string resultado = datos.guardarPago(pago);

                    if (resultado == "OK")
                    {
                        MessageBox.Show("Pago registrado con éxito.");

                        string res = "";
                        res = datos.eliminarRegistro(Convert.ToInt32(id));
                        if (res.Equals("OK"))
                        {
                            int.TryParse(interesStr, out int interesesInt);
                            int.TryParse(capitalStr, out int capitalInt2);
                            int.TryParse(valorStr, out int valorInt2);

                            decimal TotalIntereses = interesesInt * (valorInt2 / capitalInt2);

                            res = "";
                            GuardarHistorial data = new GuardarHistorial
                            {
                                number = number.Text.Trim(),
                                valor = valor.Text.Trim(),
                                capital = capital.Text.Trim(),
                                interes = interes.Text.Trim(),
                                cobroTotal = cantidad.Text.Trim(),
                                name = name.Text.Trim(),
                                fecha = DateTime.Now.ToShortDateString(),
                                interesesGanados = TotalIntereses.ToString()
                            };

                            try
                            {
                                Datos datos2 = new Datos();
                                res = datos2.guardarEnHistorial(data);
                                if (res.Equals("OK"))
                                {
                                    MessageBox.Show("Prestamo saldado con exito");
                                    form.MostrarVista(historial);
                                }
                                else
                                {
                                    MessageBox.Show("Error al guardar en historial " + res);
                                    return;
                                }
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show($"Ha ocurrido un error al saldar el prestamo: {ex.Message}");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Un error ha ocurrido, el prestamo no ha sido eliminado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el pago: " + resultado);
                    }
                }
                else
                {
                    MessageBox.Show("El pago no ha sido aplicado.");
                }
            }
            else
            {
                mensaje += "\nEsta acción no puede ser revertida.";
                var confirmacion = MessageBox.Show(mensaje, "Confirmar pago", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (confirmacion == DialogResult.OK)
                {
                    Datos datos = new Datos();
                    string resultado = datos.guardarPago(pago);

                    if (resultado == "OK")
                    {
                        MessageBox.Show("Pago registrado con éxito.");
                        CargarDatosIniciales();

                        switch (pago.Mes)
                        {
                            case "Enero":
                            case "Febrero":
                            case "Marzo":
                            case "Abril":
                            case "Mayo":
                            case "Junio":
                                cargarPagosPrestamo(Convert.ToInt32(id), 1, pago.Year);
                                break;

                            case "Julio":
                            case "Agosto":
                            case "Septiembre":
                            case "Octubre":
                            case "Noviembre":
                            case "Diciembre":
                                cargarPagosPrestamo(Convert.ToInt32(id), 2, pago.Year);
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el pago: " + resultado);
                    }
                }
                else
                {
                    MessageBox.Show("El pago no ha sido aplicado.");
                }
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            form.MostrarVista(inicio);
        }

        private void buscarPagoButton_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un préstamo antes de buscar pagos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener la fila seleccionada y el ID del préstamo
            var filaSeleccionada = dataGridView1.CurrentRow;
            string id = filaSeleccionada.Cells["ID"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("El préstamo seleccionado no tiene un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar que se haya seleccionado un rango de meses
            if (comboBox1.SelectedItem == null || string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Por favor, selecciona un año para buscar el préstamo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar que se haya seleccionado un rango de meses
            if (comboBox2.SelectedItem == null || string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("Por favor, selecciona un rango de meses para buscar el préstamo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar el rango de meses y cargar pagos
            if (comboBox2.Text == "Enero - Junio")
            {
                cargarPagosPrestamo(Convert.ToInt32(id), 1, comboBox1.Text);
            }
            else
            {
                cargarPagosPrestamo(Convert.ToInt32(id), 2, comboBox1.Text);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var filaSeleccionada = dataGridView1.CurrentRow;
            name.Text = filaSeleccionada.Cells["NOMBRE"].Value?.ToString();
            number.Text = filaSeleccionada.Cells["#"].Value?.ToString();
            cantidad.Text = filaSeleccionada.Cells["COBRO TOTAL"].Value?.ToString();
            cuotas.Text = filaSeleccionada.Cells["CUOTAS"].Value?.ToString();
            capital.Text = filaSeleccionada.Cells["CAPITAL"].Value?.ToString();
            balance.Text = filaSeleccionada.Cells["BALANCE PENDIENTE"].Value?.ToString();
            valor.Text = filaSeleccionada.Cells["VALOR PRESTAMO"].Value?.ToString();
            interes.Text = filaSeleccionada.Cells["INTERES"].Value?.ToString();
        }
    }
}
