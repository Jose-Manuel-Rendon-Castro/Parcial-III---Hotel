using Parcial_III___Hotel.Controllers;
using Parcial_III___Hotel.Models;

namespace Parcial_III___Hotel.Views
{
    public partial class FrmMenuNavegacion : Form
    {
        private MenuNavegadorController _menuNavegadorController;
        public FrmMenuNavegacion(Usuario loggedUser)
        {
            InitializeComponent();
            _menuNavegadorController = new MenuNavegadorController(this);
        }
    }
}
