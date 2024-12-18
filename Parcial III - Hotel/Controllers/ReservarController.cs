using MySql.Data.MySqlClient;
using Parcial_III___Hotel.DataAccessObject.DataAccessObjectUC;
using Parcial_III___Hotel.Models;
using Parcial_III___Hotel.Views.UserControls;

namespace Parcial_III___Hotel.Controllers
{
    public class ReservarController
    {
        private ReservarUC _reservarUC;
        private List<Huesped> huespedes = ReservarDAO.ObtenerHuespedes();
        private double totalQuote;

        public ReservarController(ReservarUC reservarUC)
        {
            _reservarUC = reservarUC;
            _reservarUC.btnReservarUC_MostrarHabitaciones.Click += btnReservarUC_MostrarHabitaciones_Click; 
            //_reservarUC.btnReservarUC_Reservar.Click += btnReservarUC_Reservar_Click;

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
        private void btnReservarUC_MostrarHabitaciones_Click(object? sender, EventArgs e)
        {
            ReservarDAO.MostrarHabitacionesDisponibles(_reservarUC.dtgvReservarUC_Habitaciones);
        }

        /*private void btnReservarUC_Reservar_Click(object? sender, EventArgs e)
        {
            try
            {
                // Get values from form controls
                string? guestName = _reservarUC.txtbReservarUC_Nombre.Text;
                string phone = _reservarUC.txtbReservarUC_Celular.Text;
                string? guestEmail = _reservarUC.txtbReservarUC_Correo.Text;
                string? membershipType = _reservarUC.cmboxReservarUC_Membresia.SelectedItem?.ToString();
                DateTime checkInDate = _reservarUC.dtpReservarUC_FechaEntrada.Value;
                DateTime checkOutDate = _reservarUC.dtpReservarUC_FechaSalida.Value;
                string? roomType = _reservarUC.dtgvReservarUC_Habitaciones.SelectedRows[0].Cells["Tipo_Habitacion"].Value.ToString();
                string? roomCapacity = _reservarUC.dtgvReservarUC_Habitaciones.SelectedRows[0].Cells["Capacidad"].Value.ToString();
                string? roomNumber = _reservarUC.dtgvReservarUC_Habitaciones.SelectedRows[0].Cells["NumHabitacion"].Value.ToString();
                double totalAmount = totalQuote;

                // Connection string
                string connectionString = "Server=localhost;Database=SuiteSavage;Uid=root;Pwd=0000";

                // Insert into guests table
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Insert guest information
                    string guestQuery = @"INSERT INTO Huespedes (Nombre, NumCelular, Correo, Tipo_Membresia, Estado_Membresia) 
                                  VALUES (@Nombre, @NumCelular, @Correo, @Tipo_Membresia, @Estado_Membresia)";
                    long guestId;
                    using (MySqlCommand cmd = new MySqlCommand(guestQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", guestName);
                        cmd.Parameters.AddWithValue("@NumCelular", phone);
                        cmd.Parameters.AddWithValue("@Correo", guestEmail);
                        cmd.Parameters.AddWithValue("@Tipo_Membresia", membershipType);
                        cmd.Parameters.AddWithValue("@Estado_Membresia",1);

                        cmd.ExecuteNonQuery();

                        // Retrieve the auto-generated guest_id
                        guestId = cmd.LastInsertedId; // Retrieves the LAST_INSERT_ID()
                    }

                    // Insert check-in and check-out details
                    string checkQuery = @"INSERT INTO Checks (Fecha_Entrada, Fecha_Salida, Huesped_Id, NumHabitacion, Estado_Checks) 
                                  VALUES (@Fecha_Entrada, @Fecha_Salida, @Huesped_Id, @NumHabitacion, @Estado_Checks)";
                    //long checkId;
                    using (MySqlCommand cmd = new MySqlCommand(checkQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Fecha_Entrada", checkInDate);
                        cmd.Parameters.AddWithValue("@Fecha_Salida", checkOutDate);
                        cmd.Parameters.AddWithValue("@Huesped_Id", guestId);
                        cmd.Parameters.AddWithValue("@NumHabitacion", roomNumber);
                        cmd.Parameters.AddWithValue("@Estado_Checks", "En Check In");

                        cmd.ExecuteNonQuery();
                    }
                }

                // Success message
                MessageBox.Show("Reservacion creada exitosamente!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
    }
}