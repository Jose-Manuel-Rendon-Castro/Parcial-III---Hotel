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

        public PayWallController(FrmPayWall frmPayWall)
        {
            _frmPayWall = frmPayWall;
            _frmPayWall.cmboxPayWall_TipoPago.SelectedIndexChanged += cmboxPayWall_TipoPago_SelectedIndexChanged;
            _frmPayWall.msktxtboxPayWall_Pago.KeyDown += msktxtboxPayWall_Pago_KeyDown;
            _frmPayWall.msktxtboxPayWall_NombreTitular.KeyDown += msktxtboxPayWall_NombreTitular_KeyDown;
            _frmPayWall.btnPayWall_Pagar.Click += BtnPayWall_Pagar_Click;
        }
        private void BtnPayWall_Pagar_Click(object? sender, EventArgs e)
        {

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

        private void msktxtboxPayWall_NombreTitular_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Hola");
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
