using Parcial_III___Hotel.Controllers;
using Parcial_III___Hotel.Controllers.ControllersUC;
using Parcial_III___Hotel.Models;
using Parcial_III___Hotel.Views.UserControls;

namespace Parcial_III___Hotel.Views
{
    public partial class FrmMenuNavegacion : Form
    {
        private MenuNavegadorController _menuNavegadorController;
        private CheckInController _checkInController;
        public FrmMenuNavegacion(Usuario loggedUser)
        {
            InitializeComponent();

            CheckInUC checkInUC = new CheckInUC();
            _checkInController = new CheckInController(checkInUC);
            _menuNavegadorController = new MenuNavegadorController(this, _checkInController);
        }
    }
}
