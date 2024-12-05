using Parcial_III___Hotel.Controllers;
using Parcial_III___Hotel.DAO;

namespace Parcial_III___Hotel
{
    public partial class FrmLogin : Form
    {
        private LoginController _loginController;
        public FrmLogin()
        {
            InitializeComponent();
            _loginController = new LoginController(this);
        }
    }
}
