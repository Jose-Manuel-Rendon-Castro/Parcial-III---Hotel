using Parcial_III___Hotel.DataAccessObject;
using Parcial_III___Hotel.Views;
using Parcial_III___Hotel.Views.UserControls;

namespace Parcial_III___Hotel.Controllers
{
    public class PayWallController
    {
        private FrmPayWall _frmPayWall;
        public PayWallController(FrmPayWall frmPayWall)
        {
            _frmPayWall = frmPayWall;
            _frmPayWall.btnPayWall_Pagar.Click += BtnPayWall_Pagar_Click;
        }

        public void MostrarPago(decimal idCheck)
        {
            decimal cantidadPagar = PayWallDAO.CantidadPagar(idCheck);
            _frmPayWall.lblPayWall_CantidadPagar.Text = $"${cantidadPagar}";
            _frmPayWall.ShowDialog();
        }

        private void BtnPayWall_Pagar_Click(object? sender, EventArgs e)
        {
            if (_frmPayWall.cmboxPayWall_TipoPago.Text == "Efectivo")
            {

            }
            else
            {

            }
            _frmPayWall.Close();
        }
    }
}
