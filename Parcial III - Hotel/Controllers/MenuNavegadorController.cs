using Parcial_III___Hotel.Controllers.ControllersUC;
using Parcial_III___Hotel.DataAccessObject.DataAccessObjectUC;
using Parcial_III___Hotel.Views;

namespace Parcial_III___Hotel.Controllers
{
    public class MenuNavegadorController
    {
        private FrmMenuNavegacion _frmMenuNavegacion;
        private CheckInController _CheckInController;
        private CheckOutController _CheckOutController;
        public MenuNavegadorController(FrmMenuNavegacion frmMenuNavegacion, CheckInController checkInController, CheckOutController checkOutController)
        {
            _frmMenuNavegacion = frmMenuNavegacion;
            _CheckInController = checkInController;
            _CheckOutController = checkOutController;
            _frmMenuNavegacion.panelMenu_SidePanel.Height = _frmMenuNavegacion.btnMenu_Inicio.Height;
            _frmMenuNavegacion.panelMenu_SidePanel.Top = _frmMenuNavegacion.btnMenu_Inicio.Top;
            _frmMenuNavegacion.panelMenu_InicioUC.BringToFront();

            _frmMenuNavegacion.btnMenu_Inicio.Click += btnMenu_Inicio_Click;
            _frmMenuNavegacion.btnMenu_Reservar.Click += btnMenu_Reservar_Click;
            _frmMenuNavegacion.btnMenu_Reservacion.Click += btnMenu_Reservacion_Click;
            _frmMenuNavegacion.btnMenu_CheckIn.Click += btnMenu_CheckIn_Click;
            _frmMenuNavegacion.btnMenu_CheckOut.Click += btnMenu_CheckOut_Click;
            _frmMenuNavegacion.btnMenu_Salir.Click += btnMenu_Salir_Click;
        }

        private void btnMenu_Inicio_Click (object? sender, EventArgs e)
        {
            _frmMenuNavegacion.panelMenu_SidePanel.Height = _frmMenuNavegacion.btnMenu_Inicio.Height;
            _frmMenuNavegacion.panelMenu_SidePanel.Top = _frmMenuNavegacion.btnMenu_Inicio.Top;
            _frmMenuNavegacion.panelMenu_InicioUC.BringToFront();
        }
        private void btnMenu_Reservar_Click (object? sender, EventArgs e)
        {
            _frmMenuNavegacion.panelMenu_SidePanel.Height = _frmMenuNavegacion.btnMenu_Reservar.Height;
            _frmMenuNavegacion.panelMenu_SidePanel.Top = _frmMenuNavegacion.btnMenu_Reservar.Top;
            _frmMenuNavegacion.panelMenu_ReservarUC.BringToFront();
            
        }
        private void btnMenu_CheckIn_Click (object? sender, EventArgs e)
        {
            _frmMenuNavegacion.panelMenu_SidePanel.Height = _frmMenuNavegacion.btnMenu_CheckIn.Height;
            _frmMenuNavegacion.panelMenu_SidePanel.Top = _frmMenuNavegacion.btnMenu_CheckIn.Top;
            _CheckInController.Load(sender, e);
            _frmMenuNavegacion.panelMenu_CheckInUC.BringToFront();
        }
        private void btnMenu_CheckOut_Click (object? sender, EventArgs e)
        {
            _frmMenuNavegacion.panelMenu_SidePanel.Height = _frmMenuNavegacion.btnMenu_CheckOut.Height;
            _frmMenuNavegacion.panelMenu_SidePanel.Top = _frmMenuNavegacion.btnMenu_CheckOut.Top;
            _CheckOutController.Load(sender, e);
            _frmMenuNavegacion.panelMenu_CheckOutUC.BringToFront();

        }
        private void btnMenu_Reservacion_Click (object? sender, EventArgs e)
        {
            _frmMenuNavegacion.panelMenu_SidePanel.Height = _frmMenuNavegacion.btnMenu_Reservacion.Height;
            _frmMenuNavegacion.panelMenu_SidePanel.Top = _frmMenuNavegacion.btnMenu_Reservacion.Top;
            _frmMenuNavegacion.panelMenu_ReservacionUC.BringToFront();
        }

        private void btnMenu_Salir_Click (object? sender, EventArgs e)
        {
            _frmMenuNavegacion.Close();
        }
    }
}
