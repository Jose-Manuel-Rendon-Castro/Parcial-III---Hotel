using Parcial_III___Hotel.Controllers.ControllersUC;

namespace Parcial_III___Hotel.Views.UserControls
{
    public partial class CheckInUC : UserControl
    {
        private CheckInController _checkInController;
        public CheckInUC()
        {
            InitializeComponent();
            _checkInController = new CheckInController(this);
        }
    }
}
