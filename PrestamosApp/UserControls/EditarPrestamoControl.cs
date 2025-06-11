using PrestamosApp.BD;
using PrestamosApp.Models;

namespace PrestamosApp.UserControls
{
    public partial class EditarPrestamoControl : UserControl
    {
        private Prestamos form;
        private Inicio inicio;
        private string _id;
        public EditarPrestamoControl(Inicio inicio, Prestamos form, string id, string name, string number, string dia, string cobro, string interes, string capital, string valor, string cuotas)
        {
            InitializeComponent();
            this.form = form;
            this.inicio = inicio;
            _id = id;
            this.name.Text = name;
            this.number.Text = number;
            this.dia.Text = dia;
            this.cobro.Text = cobro;
            this.interes.Text = interes;
            this.capital.Text = capital;
            this.valor.Text = valor;
            this.cuotas.Text = cuotas;
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text.Trim()) ||
                string.IsNullOrWhiteSpace(number.Text.Trim()) ||
                string.IsNullOrWhiteSpace(dia.Text.Trim()) ||
                string.IsNullOrWhiteSpace(cuotas.Text.Trim()) ||
                string.IsNullOrWhiteSpace(cobro.Text.Trim()) ||
                string.IsNullOrWhiteSpace(interes.Text.Trim()) ||
                string.IsNullOrWhiteSpace(capital.Text.Trim()))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            if (int.TryParse(cobro.Text.Trim(), out int cobroTotal) &&
                int.TryParse(valor.Text.Trim(), out int cuotasTotal))
            {
                if (cobroTotal <= 0 || cuotasTotal <= 0)
                {
                    MessageBox.Show("El monto a cobrar y el valor del prestamo deben ser mayor a 0.");
                    return;
                }
                if (cobroTotal > cuotasTotal)
                {
                    MessageBox.Show("El monto a cobrar no debe ser mayor al valor del prestamo.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresa números válidos en monto a cobrar y valor de prestamo.");
                return;
            }

            if (int.TryParse(capital.Text.Trim(), out int capitalInt) &&
                int.TryParse(interes.Text.Trim(), out int interesInt))
            {
                if (capitalInt <= 0 || interesInt <= 0)
                {
                    MessageBox.Show("El capital y el interes debe ser mayor a 0");
                    return;
                }
                if (cobroTotal <= interesInt)
                {
                    MessageBox.Show("El interes no debe ser igual al monto de cobro total.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresa números válidos en capital e intereses.");
                return;
            }
            string res = "";
            Guardar data = new Guardar
            {
                Id = _id,
                number = number.Text.Trim(),
                valor = valor.Text.Trim(),
                capital = capital.Text.Trim(),
                interes = interes.Text.Trim(),
                cobroTotal = cobro.Text.Trim(),
                name = name.Text.Trim(),
                payDay = dia.Text.Trim(),
                cuotas = cuotas.Text.Trim()
            };

            var resultado = MessageBox.Show(
                    $"¿Estás seguro de que deseas aplicar un pago al prestamo #{number.Text} perteneciente a {name.Text} que tiene un valor de {valor.Text}? \n" +
                    "Esta accion no puede ser revertida.",
                    "Confirmar edicion",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );
            if (resultado == DialogResult.OK)
            {
                try
                {
                    Datos datos = new Datos();
                    res = datos.guardarRegistro(2, data);
                    if (res.Equals("OK"))
                    {
                        MessageBox.Show("Prestamo editado con Exito");

                        form.MostrarVista(inicio);
                    }
                    else
                    {
                        MessageBox.Show("Un error ha ocurrido, el prestamo no ha sido editado" + res);
                        return;
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Ha ocurrido un error al editar el prestamo: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("El prestamo no ha sido EDITADO.");
            }
        }
        private void cancelarButton_Click(object sender, EventArgs e)
        {
            form.MostrarVista(inicio);
        }

        private void CalcularCuotasTotal(object sender, EventArgs e)
        {
            CalcularIntereses(sender, e);
            if (int.TryParse(capital.Text, out int capitalTotal) &&
                int.TryParse(valor.Text, out int valorPrestamo))
            {
                if (capitalTotal <= 0)
                {
                    capitalTotal = 1;
                    capital.Text = "1";
                }
                int cuotasTotal = valorPrestamo / capitalTotal;
                cuotas.Text = cuotasTotal.ToString();
            }
            else
            {
                cuotas.Text = "1";
            }
            
        }

        private void CalcularIntereses(object sender, EventArgs e)
        {
            if (int.TryParse(capital.Text, out int capitalInt) &&
                int.TryParse(cobro.Text, out int cobroTotal))
            {
                if (capitalInt > cobroTotal)
                {
                    capitalInt = cobroTotal;
                    capital.Text = $"{cobroTotal}";
                }
                int nuevoInteres = cobroTotal - capitalInt;
                if (interes.Text != nuevoInteres.ToString())
                {
                    interes.Text = nuevoInteres.ToString();
                }
            }
            else
            {
                interes.Text = "1";
            }
        }

        private void CalcularCapital(object sender, EventArgs e)
        {
            if (int.TryParse(interes.Text, out int interesInt) &&
                int.TryParse(cobro.Text, out int cobroTotal))
            {
                if (interesInt > cobroTotal)
                {
                    interesInt = cobroTotal;
                    interes.Text = $"{cobroTotal}";
                }
                int nuevoCapital = cobroTotal - interesInt;
                if (capital.Text != nuevoCapital.ToString())
                {
                    capital.Text = nuevoCapital.ToString();
                }
                CalcularCuotasTotal(sender, e);
            }
            else
            {
                capital.Text = "1";
            }
        }

        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void cobro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void interes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void cuotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

    }
}
