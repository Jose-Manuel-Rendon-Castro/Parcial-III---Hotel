using Parcial_III___Hotel.DataAccessObject.DataAccessObjectUC;
using Parcial_III___Hotel.Views.UserControls;

namespace Parcial_III___Hotel.Controllers.ControllersUC
{
    public class CheckInController
    {
        private CheckInUC _checkInUC;
        public CheckInController(CheckInUC checkInUC)
        {
            _checkInUC = checkInUC;
            _checkInUC.Load += Load;
            _checkInUC.btnCheckInUC_ConfirmarCheckIn.Click += btnCheckInUC_ConfirmarCheckIn_Click;
        } 

        private void btnCheckInUC_ConfirmarCheckIn_Click (object? sender, EventArgs e)
        {

        }

        private void Load (object? sender, EventArgs e)
        {
            CheckInDAO.TablaHuespedes(_checkInUC.dtgvCheckInUC_Lista);
        }
    }
}
