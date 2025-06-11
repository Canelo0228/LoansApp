using PrestamosApp.BD;
using PrestamosApp.Models;
using System;
using System.Windows.Forms;

namespace PrestamosApp.UserControls
{
    public partial class RegistrarPrestamoControl : UserControl
    {
        private Prestamos form;
        private Inicio inicio;
        public RegistrarPrestamoControl(Inicio inicio, Prestamos form)
        {
            InitializeComponent();
            this.form = form;
            this.inicio = inicio;
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

        private void agregarButton_Click(object sender, EventArgs e)
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
                MessageBox.Show("Por favor ingresa números válidos en monto a cobrar y cuotas.");
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
                number = number.Text.Trim(),
                valor = valor.Text.Trim(),
                capital = capital.Text.Trim(),
                interes = interes.Text.Trim(),
                cobroTotal = cobro.Text.Trim(),
                name = name.Text.Trim(),
                payDay = dia.Text.Trim(),
                cuotas = cuotas.Text.Trim()
            };

            try
            {
                Datos datos = new Datos();
                res = datos.guardarRegistro(1, data);
                if (res.Equals("OK"))
                {
                    MessageBox.Show("Prestamo registrado con Exito");
                    form.MostrarVista(inicio);
                }
                else
                {
                    MessageBox.Show("Error al registrar el prestamo " + res);
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ha ocurrido un error al Registrar el nuevo prestamo: {ex.Message}");
            }

            
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            form.MostrarVista(inicio);
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
