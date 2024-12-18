using Parcial_III___Hotel.Controllers.ControllersUC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_III___Hotel.Controllers
{
    public class MediadorPayWall
    {
        private CheckInController _checkInController;
        private PayWallController _payWallController;

        public MediadorPayWall(CheckInController checkInController, PayWallController payWallController)
        {
            _checkInController = checkInController;
            _payWallController = payWallController;
        }

        public void NotificarPagoRequerido(decimal idCheck)
        {
            _payWallController.MostrarPago(idCheck);
        }
    }
}
