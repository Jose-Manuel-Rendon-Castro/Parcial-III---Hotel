using Parcial_III___Hotel.Controllers;
using Parcial_III___Hotel.Controllers.ControllersUC;

namespace Parcial_III___Hotel.Views.UserControls
{
    public partial class CheckInUC : UserControl
    {
        private CheckInController _checkInController;
        private MediadorPayWall _mediadorPayWall;
        public CheckInUC()
        {
            InitializeComponent();
            FrmPayWall frmPayWall = new FrmPayWall();
            _mediadorPayWall = new MediadorPayWall(_checkInController, new PayWallController(frmPayWall));
            _checkInController = new CheckInController(this, _mediadorPayWall);
        }
    }
}
