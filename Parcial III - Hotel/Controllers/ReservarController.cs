using Parcial_III___Hotel.DataAccessObject;
using Parcial_III___Hotel.DataAccessObject.DataAccessObjectUC;
using Parcial_III___Hotel.Models;
using Parcial_III___Hotel.Views;
using Parcial_III___Hotel.Views.UserControls;

namespace Parcial_III___Hotel.Controllers
{
    public class ReservarController
    {
        private ReservarUC _reservarUC;
        private List<Huesped> huespedes = ReservarDAO.ObtenerHuespedes();

        public ReservarController(ReservarUC reservarUC)
        {
            _reservarUC = reservarUC;
            _reservarUC.btnReservarUC_MostrarHabitaciones.Click += btnReservarUC_MostrarHabitaciones_Click;
            _reservarUC.btnReservarUC_CrearHuesped.Click += btnReservarUC_CrearHuesped_Click;
            _reservarUC.btnReservarUC_Reservar.Click += btnReservarUC_Reservar_Click;
            _reservarUC.btnReservarUC_Cotizar.Click += btnReservarUC_Cotizar_Click;
            _reservarUC.combxReservarUC_Huesped.TextUpdate += combxReservarUC_Huespedes_TextUpdate;
        }

        private void combxReservarUC_Huespedes_TextUpdate (object? sender, EventArgs e)
        {
            string text = _reservarUC.combxReservarUC_Huesped.Text;

            var huespedesFiltrados = huespedes.Where(huesped => huesped.Nombre.Contains(text, StringComparison.OrdinalIgnoreCase)).ToList();

            _reservarUC.combxReservarUC_Huesped.DroppedDown = false;
            if (huespedesFiltrados.Count > 0)
            {
                _reservarUC.combxReservarUC_Huesped.BeginUpdate();
                _reservarUC.combxReservarUC_Huesped.DataSource = null;
                _reservarUC.combxReservarUC_Huesped.DataSource = huespedesFiltrados;
                _reservarUC.combxReservarUC_Huesped.DisplayMember = "Nombre";
                _reservarUC.combxReservarUC_Huesped.EndUpdate();

                _reservarUC.combxReservarUC_Huesped.DroppedDown = true; // Reabrir DropDown
            }

            // Restaurar el texto
            _reservarUC.combxReservarUC_Huesped.Text = text;
            _reservarUC.combxReservarUC_Huesped.SelectionStart = text.Length;
            _reservarUC.combxReservarUC_Huesped.SelectionLength = 0;
        }
        private void btnReservarUC_MostrarHabitaciones_Click (object? sender, EventArgs e)
        {
            ReservarDAO.MostrarHabitacionesDisponibles(_reservarUC.dtgvReservarUC_Habitaciones);
        }
        private void btnReservarUC_CrearHuesped_Click (object? sender, EventArgs e)
        {
            FrmCrearCliente_Huesped frmCrearCliente_Huesped = new FrmCrearCliente_Huesped();
            frmCrearCliente_Huesped.Show();            
        }
        private void btnReservarUC_Reservar_Click (object? sender, EventArgs e)
        {
            ReservarDAO.ReservarHabitacion(
                _reservarUC.combxReservarUC_Huesped.Text,
                _reservarUC.dtpReservarUC_FechaEntrada.Value,
                _reservarUC.dtpReservarUC_FechaSalida.Value,
                _reservarUC.dtgvReservarUC_Habitaciones
            );
        }
        private void btnReservarUC_Cotizar_Click (object? sender, EventArgs e)
        {
            MessageBox.Show(ReservarDAO.CotizarReservacion(_reservarUC.dtpReservarUC_FechaEntrada.Value, _reservarUC.dtpReservarUC_FechaSalida.Value, _reservarUC.dtgvReservarUC_Habitaciones));
        }
    }
}