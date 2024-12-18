using Parcial_III___Hotel.Controllers;

namespace Parcial_III___Hotel.Views
{
    public partial class FrmCrearCliente_Huesped : Form
    {
        private CrearCliente_HuespedController _crearCliente_HuespedController;     
        public FrmCrearCliente_Huesped()
        {
            InitializeComponent();
            _crearCliente_HuespedController = new CrearCliente_HuespedController(this);
        }
    }
}
