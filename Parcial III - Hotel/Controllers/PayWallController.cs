using Parcial_III___Hotel.DataAccessObject;
using Parcial_III___Hotel.Views;
using Parcial_III___Hotel.Views.UserControls;
using System.Windows.Forms;

namespace Parcial_III___Hotel.Controllers
{
    public class PayWallController
    {
        private FrmPayWall _frmPayWall;
        private decimal aPagar;
        private bool pagoRealizado = false;

        public PayWallController(FrmPayWall frmPayWall)
        {
            _frmPayWall = frmPayWall;
            _frmPayWall.cmboxPayWall_TipoPago.SelectedIndexChanged += cmboxPayWall_TipoPago_SelectedIndexChanged;
            _frmPayWall.msktxtboxPayWall_Pago.KeyDown += msktxtboxPayWall_Pago_KeyDown;
            _frmPayWall.btnPayWall_Pagar.Click += BtnPayWall_Pagar_Click;
        }
        private void BtnPayWall_Pagar_Click(object? sender, EventArgs e)
        {
            if (pagoRealizado) return;
            pagoRealizado = true;

            if (_frmPayWall.cmboxPayWall_TipoPago.Text == "Efectivo")
            {
                if (String.IsNullOrEmpty(_frmPayWall.lblPayWall_Vuelto.Text))
                {
                    MessageBox.Show("Presione la tecla 'ENTER' en el pago ingresado para determinar el cambio de ser necesario.");
                    pagoRealizado = false;
                }
                else if (!String.IsNullOrEmpty(_frmPayWall.lblPayWall_Vuelto.Text))
                {
                    MessageBox.Show("Check In Registrado con Éxito.");
                    _frmPayWall.Close();
                }
            }
        }

        public void MostrarPago(decimal idCheck)
        {
            aPagar = PayWallDAO.CantidadPagar(idCheck);
            _frmPayWall.lblPayWall_CantidadPagar.Text = $"${aPagar}";
            _frmPayWall.ShowDialog();
        }

        private void cmboxPayWall_TipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_frmPayWall.cmboxPayWall_TipoPago.Text == "Tarjeta")
            {
                _frmPayWall.lblPayWall_InfoTarjeta.Visible = true;
                _frmPayWall.lblPayWall_NumT.Visible = true;
                _frmPayWall.lblPayWall_FechaV.Visible = true;
                _frmPayWall.lblPayWall_CVV.Visible = true;
                _frmPayWall.msktxtboxPayWall_NumTarjeta.Visible = true;
                _frmPayWall.msktxtboxPayWall_FechaV.Visible = true;
                _frmPayWall.msktxtboxPayWall_CVV.Visible = true;

                _frmPayWall.lblPayWall_Pago.Visible = false;
                _frmPayWall.lblPayWall_Cambio.Visible = false;
                _frmPayWall.msktxtboxPayWall_Pago.Visible = false;
                _frmPayWall.lblPayWall_Vuelto.Visible = false;
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
                _frmPayWall.msktxtboxPayWall_NumTarjeta.Visible = false;
                _frmPayWall.msktxtboxPayWall_FechaV.Visible = false;
                _frmPayWall.msktxtboxPayWall_CVV.Visible = false;
            }

        }

        private void msktxtboxPayWall_Pago_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si la tecla presionada es "Enter"
            if (e.KeyCode == Keys.Enter)
            {
                _frmPayWall.lblPayWall_Vuelto.Text = "";  // Limpiar el mensaje de vuelto

                // Llamar a la función CalcularCambio pasando el valor de aPagar
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
    }
}
