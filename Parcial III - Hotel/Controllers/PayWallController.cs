using Parcial_III___Hotel.DataAccessObject;
using Parcial_III___Hotel.Views;
using Parcial_III___Hotel.Views.UserControls;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Parcial_III___Hotel.Controllers
{
    public class PayWallController
    {
        private FrmPayWall _frmPayWall;
        private decimal aPagar;

        public PayWallController(FrmPayWall frmPayWall)
        {
            _frmPayWall = frmPayWall;
            _frmPayWall.cmboxPayWall_TipoPago.SelectedIndexChanged += cmboxPayWall_TipoPago_SelectedIndexChanged;
            _frmPayWall.msktxtboxPayWall_Pago.KeyDown += msktxtboxPayWall_Pago_KeyDown;
            _frmPayWall.btnPayWall_Pagar.Click += btnPayWall_Pagar_Click;
        }
        private void btnPayWall_Pagar_Click(object? sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                MessageBox.Show("Pago procesado con éxito.");
                _frmPayWall.Close();
            }
        }

        public void MostrarPago(decimal idCheck)
        {
            aPagar = PayWallDAO.CantidadPagar(idCheck);
            _frmPayWall.lblPayWall_CantidadPagar.Text = $"$ {aPagar}";
            _frmPayWall.ShowDialog();
        }

        private void cmboxPayWall_TipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            _frmPayWall.btnPayWall_Pagar.Enabled = false;
            if (_frmPayWall.cmboxPayWall_TipoPago.Text == "Tarjeta")
            {
                _frmPayWall.lblPayWall_InfoTarjeta.Visible = true;
                _frmPayWall.lblPayWall_NumT.Visible = true;
                _frmPayWall.lblPayWall_FechaV.Visible = true;
                _frmPayWall.lblPayWall_CVV.Visible = true;
                _frmPayWall.lblPayWall_NombreTitular.Visible = true;
                _frmPayWall.lblPayWall_MsjError.Visible = true;
                _frmPayWall.msktxtboxPayWall_NumTarjeta.Visible = true;
                _frmPayWall.msktxtboxPayWall_FechaV.Visible = true;
                _frmPayWall.msktxtboxPayWall_CVV.Visible = true;
                _frmPayWall.msktxtboxPayWall_NombreTitular.Visible = true;

                _frmPayWall.lblPayWall_Pago.Visible = false;
                _frmPayWall.lblPayWall_Cambio.Visible = false;
                _frmPayWall.msktxtboxPayWall_Pago.Visible = false;
                _frmPayWall.lblPayWall_Vuelto.Visible = false;
                _frmPayWall.msktxtboxPayWall_Pago.Clear();
                _frmPayWall.lblPayWall_Vuelto.Text = "Presione le tecla 'Enter' en el \r\npago ingresado para \r\nobtener el cambio.";

                _frmPayWall.btnPayWall_Pagar.Enabled = true;
            }
            else if (_frmPayWall.cmboxPayWall_TipoPago.Text == "Efectivo")
            {
                _frmPayWall.lblPayWall_Pago.Visible = true;
                _frmPayWall.lblPayWall_Cambio.Visible = true;
                _frmPayWall.msktxtboxPayWall_Pago.Visible = true;
                _frmPayWall.lblPayWall_Vuelto.Visible = true;

                _frmPayWall.lblPayWall_InfoTarjeta.Visible = false;
                _frmPayWall.lblPayWall_NumT.Visible = false;
                _frmPayWall.lblPayWall_FechaV.Visible = false;
                _frmPayWall.lblPayWall_CVV.Visible = false;
                _frmPayWall.lblPayWall_NombreTitular.Visible = false;
                _frmPayWall.lblPayWall_MsjError.Visible = false;
                _frmPayWall.msktxtboxPayWall_NumTarjeta.Visible = false;
                _frmPayWall.msktxtboxPayWall_FechaV.Visible = false;
                _frmPayWall.msktxtboxPayWall_CVV.Visible = false;
                _frmPayWall.msktxtboxPayWall_NombreTitular.Visible = false;
                _frmPayWall.msktxtboxPayWall_NumTarjeta.Clear();
                _frmPayWall.msktxtboxPayWall_FechaV.Clear();
                _frmPayWall.msktxtboxPayWall_CVV.Clear();
                _frmPayWall.msktxtboxPayWall_NombreTitular.Clear();
            }
        }

        private void msktxtboxPayWall_Pago_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si la tecla presionada es "Enter"
            if (e.KeyCode == Keys.Enter)
            {
                CalcularCambio(aPagar);

                // Marcar el evento como manejado para evitar que cause otras acciones
                e.Handled = true;
            }
        }

        private void CalcularCambio(decimal aPagar) 
        {
            if (decimal.TryParse(_frmPayWall.msktxtboxPayWall_Pago.Text, out decimal montoPagado))
            {
                if (montoPagado < aPagar)
                {
                    MessageBox.Show("La cantidad pagada es menor que el monto total a pagar.");
                    _frmPayWall.btnPayWall_Pagar.Enabled = false;
                }
                else if (montoPagado == aPagar)
                {
                    _frmPayWall.lblPayWall_Vuelto.Text = "Pago Exacto.";
                    _frmPayWall.btnPayWall_Pagar.Enabled = true;
                }
                else
                {
                    decimal cambio = montoPagado - aPagar;
                    _frmPayWall.lblPayWall_Vuelto.Text = "El cambio a devolver es: " + cambio.ToString("C");
                    _frmPayWall.btnPayWall_Pagar.Enabled = true;

                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un monto válido.");
            }
        }

        private bool ValidarFechaVencimiento(string fechaVencimiento)
        {
            string[] partes = fechaVencimiento.Split('/');
            int mes = int.Parse(partes[0]);
            int year = int.Parse("20" + partes[1]);

            DateTime fechaActual = DateTime.Now;
            DateTime fechaExpiracion = new DateTime(year, mes, 1);

            return fechaExpiracion >= new DateTime(fechaActual.Year, fechaActual.Month, 1);
        }
        private bool ValidarFormulario()
        {
            _frmPayWall.lblPayWall_MsjError.Text = "";

            string numeroTarjeta = _frmPayWall.msktxtboxPayWall_NumTarjeta.Text.Replace("-", "");
            if (!Regex.IsMatch(numeroTarjeta, @"^\d{16}$"))
            {
                _frmPayWall.lblPayWall_MsjError.Text = "El número de tarjeta debe tener 16 dígitos.";
                return false;
            }

            if (!Regex.IsMatch(_frmPayWall.msktxtboxPayWall_FechaV.Text, @"^(0[1-9]|1[0-2])\/\d{2}$"))
            {
                _frmPayWall.lblPayWall_MsjError.Text = "Ingrese una Fecha de Vencimiento Válida.";
                return false;
            }

            if (!ValidarFechaVencimiento(_frmPayWall.msktxtboxPayWall_FechaV.Text))
            {
                _frmPayWall.lblPayWall_MsjError.Text = "La fecha de vencimiento no puede ser \r\nanterior al mes actual.";
                return false;
            }

            string numeroCVV = _frmPayWall.msktxtboxPayWall_CVV.Text.Replace("/", "");
            if (!Regex.IsMatch(numeroCVV, @"^\d{3,4}$"))
            {
                _frmPayWall.lblPayWall_MsjError.Text = "El CVV debe tener 3 o 4 dígitos.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(_frmPayWall.msktxtboxPayWall_NombreTitular.Text))
            {
                _frmPayWall.lblPayWall_MsjError.Text = "Debe ingresar un \r\nNombre de Titular de la Tarjeta.";
                return false;
            }

            return true;
        }


    }
}
