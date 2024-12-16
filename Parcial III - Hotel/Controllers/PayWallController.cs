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
        }

        public void MostrarPago(decimal idCheck)
        {
            decimal cantidadPagar = PayWallDAO.CantidadPagar(idCheck);
            _frmPayWall.lblPayWall_CantidadPagar.Text = $"${cantidadPagar}";
            _frmPayWall.ShowDialog();
        }
    }
}
