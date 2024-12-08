﻿using Parcial_III___Hotel.Views;

namespace Parcial_III___Hotel.Controllers
{
    public class MenuNavegadorController
    {
        private FrmMenuNavegacion _frmMenuNavegacion;
        public MenuNavegadorController(FrmMenuNavegacion frmMenuNavegacion)
        {
            _frmMenuNavegacion = frmMenuNavegacion;
            _frmMenuNavegacion.panelMenu_SidePanel.Height = _frmMenuNavegacion.btnMenu_Inicio.Height;
            _frmMenuNavegacion.panelMenu_SidePanel.Top = _frmMenuNavegacion.btnMenu_Inicio.Top;
            _frmMenuNavegacion.InicioUC.BringToFront();

            _frmMenuNavegacion.btnMenu_Inicio.Click += btnMenu_Inicio;
            _frmMenuNavegacion.btnMenu_Reservar.Click += btnMenu_Reservar;
            _frmMenuNavegacion.btnMenu_CheckIn.Click += btnMenu_CheckIn;
            _frmMenuNavegacion.btnMenu_Reservacion.Click += btnMenu_Reservacion;
            _frmMenuNavegacion.btnMenu_Salir.Click += btnMenu_Salir;
        }
        
        private void btnMenu_Inicio(object? sender, EventArgs e)
        {
            _frmMenuNavegacion.panelMenu_SidePanel.Height = _frmMenuNavegacion.btnMenu_Inicio.Height;
            _frmMenuNavegacion.panelMenu_SidePanel.Top = _frmMenuNavegacion.btnMenu_Inicio.Top;
            _frmMenuNavegacion.InicioUC.BringToFront();
        }
        private void btnMenu_Reservar(object? sender, EventArgs e)
        {
            _frmMenuNavegacion.panelMenu_SidePanel.Height = _frmMenuNavegacion.btnMenu_Reservar.Height;
            _frmMenuNavegacion.panelMenu_SidePanel.Top = _frmMenuNavegacion.btnMenu_Reservar.Top;
            _frmMenuNavegacion.ReservarUC.BringToFront();
        }
        private void btnMenu_CheckIn (object? sender, EventArgs e)
        {
            _frmMenuNavegacion.panelMenu_SidePanel.Height = _frmMenuNavegacion.btnMenu_CheckIn.Height;
            _frmMenuNavegacion.panelMenu_SidePanel.Top = _frmMenuNavegacion.btnMenu_CheckIn.Top;
            _frmMenuNavegacion.panelMenu_CheckInUC.BringToFront();
        }
        private void btnMenu_Reservacion(object? sender, EventArgs e)
        {
            _frmMenuNavegacion.panelMenu_SidePanel.Height = _frmMenuNavegacion.btnMenu_Reservacion.Height;
            _frmMenuNavegacion.panelMenu_SidePanel.Top = _frmMenuNavegacion.btnMenu_Reservacion.Top;
            _frmMenuNavegacion.ReservacionUC.BringToFront();
        }

        private void btnMenu_Salir(object? sender, EventArgs e)
        {
            _frmMenuNavegacion.Close();
        }
    }
}
