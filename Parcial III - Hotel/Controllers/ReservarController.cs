using MySql.Data.MySqlClient;
using Parcial_III___Hotel.DAO;
using Parcial_III___Hotel.Exceptions;
using Parcial_III___Hotel.Models;
using Parcial_III___Hotel.Views;
using Parcial_III___Hotel.Views.UserControls;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Parcial_III___Hotel.Controllers
{
    public class ReservarController
    {
        private ReservarUC _reservarUC;
        private double totalQuote;

        public ReservarController(ReservarUC reservarUC)
        {
            _reservarUC = reservarUC;
            _reservarUC.btnReservar_ChecarHabitaciones.Click += btnReservar_ChecarHabitaciones_Click;
            _reservarUC.btnReservar_Cotizar.Click += btnReservar_Cotizar_Click;
            _reservarUC.btnReservar_CrearReservacion.Click += btnReservar_CrearReservacion_Click;
        }

        private void btnReservar_ChecarHabitaciones_Click(object? sender, EventArgs e)
        {
            string constring = "Server=localhost;Database=SuiteSavage;Uid=root;Pwd=0000";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select numhabitacion, tipo_habitacion, tipo_vista, precio, capacidad from suitesavage.habitaciones where Disponibilidad = 'disponible';", conDataBase);

            try
            {
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter();
                sqlDataAdapter.SelectCommand = cmdDataBase;
                DataTable dbDataSet = new DataTable();
                sqlDataAdapter.Fill(dbDataSet);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataSet;
                _reservarUC.dgvReservar_MostrarHabitaciones.DataSource = bSource;
                sqlDataAdapter.Update(dbDataSet);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidateForm()
        {
            // Validate Name textbox
            if (string.IsNullOrWhiteSpace(_reservarUC.txtReservar_Nombre.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacio.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (_reservarUC.txtReservar_Nombre.Text.Length > 35)
            {
                MessageBox.Show("El campo Nombre no puede exeder 35 caracteres.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (_reservarUC.txtReservar_Nombre.Text.Any(char.IsDigit)) // Check if the Name contains numbers
            {
                MessageBox.Show("El campo Nombre no puede contener digitos.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate Phone textbox
            if (string.IsNullOrWhiteSpace(_reservarUC.txtReservar_Celular.Text))
            {
                MessageBox.Show("El campo Celular no puede estar vacio.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (_reservarUC.txtReservar_Celular.Text.Length < 10)
            {
                MessageBox.Show("El campo Celular no puede ser menos de 10 digitos.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (_reservarUC.txtReservar_Celular.Text.Length > 10)
            {
                MessageBox.Show("El campo Celular no puede ser mayor de 10 digitos.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!long.TryParse(_reservarUC.txtReservar_Celular.Text, out _))
            {
                MessageBox.Show("El campo Celular solo debe contener digitos.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate Email textbox
            if (string.IsNullOrWhiteSpace(_reservarUC.txtReservar_Correo.Text))
            {
                MessageBox.Show("El campo Correo no puede estar vacio.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!_reservarUC.txtReservar_Correo.Text.Contains("@") || !_reservarUC.txtReservar_Correo.Text.EndsWith(".com"))
            {
                MessageBox.Show("El campo Correo debe contener un correo valido (por ejemplo, example@example.com).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate Membership combobox
            if (_reservarUC.comboBox_ReservarUC_TipoDeMembresia.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un tipo de membresia.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate Start Date datetimepicker
            if (!_reservarUC.dtpReserva_FechaInicio.Checked)
            {
                MessageBox.Show("Por favor eliga una fecha de inicio.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate End Date datetimepicker
            if (!_reservarUC.dtpReservar_FechaSalida.Checked)
            {
                MessageBox.Show("Por favor eliga una fecha de salida.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (_reservarUC.dtpReservar_FechaSalida.Value <= _reservarUC.dtpReserva_FechaInicio.Value)
            {
                MessageBox.Show("La fecha de salida no puede ser antes de la fecha de inicio.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // All validations passed
            return true;
        }

        private void btnReservar_Cotizar_Click(object? sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    if (_reservarUC.dgvReservar_MostrarHabitaciones.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Por favor seleccione una fila de la tabla.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    } 

                    DataGridViewRow SelectedRow = _reservarUC.dgvReservar_MostrarHabitaciones.SelectedRows[0];

                    if (!SelectedRow.Cells["precio"].Value.ToString().All(char.IsDigit))
                    {
                        MessageBox.Show("Precio invalido", "Validation Error"); 
                    }

                    double nightlyRate = Convert.ToDouble(SelectedRow.Cells["precio"].Value);

                    if (!_reservarUC.dtpReserva_FechaInicio.Checked || !_reservarUC.dtpReservar_FechaSalida.Checked)
                    {
                        MessageBox.Show("Por favor eliga una valida fecha de inicio.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DateTime startDate = _reservarUC.dtpReserva_FechaInicio.Value;
                    DateTime endDate = _reservarUC.dtpReservar_FechaSalida.Value;

                    if (endDate <= startDate)
                    {
                        MessageBox.Show("La fecha de salida no puede ser antes que la fecha de inicio.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int numberOfNights = (endDate.Day - startDate.Day);

                    // Calculate the total quote
                    totalQuote = nightlyRate * numberOfNights;

                    // Display the result
                    MessageBox.Show($"El precio total por las {numberOfNights} noches es de: {totalQuote:C}", "Quote");
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Un error ocurrio al querer realizar la cotizacion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReservar_CrearReservacion_Click(object? sender, EventArgs e)
        {
            try
            {
                // Get values from form controls
                string? guestEmail = _reservarUC.txtReservar_Correo.Text;
                string? guestName = _reservarUC.txtReservar_Nombre.Text;
                string phone = _reservarUC.txtReservar_Celular.Text;
                string? membershipType = _reservarUC.comboBox_ReservarUC_TipoDeMembresia.SelectedItem?.ToString();
                DateTime checkInDate = _reservarUC.dtpReserva_FechaInicio.Value;
                DateTime checkOutDate = _reservarUC.dtpReservar_FechaSalida.Value;
                string? roomType = _reservarUC.dgvReservar_MostrarHabitaciones.SelectedRows[0].Cells["Tipo_Habitacion"].Value.ToString();
                string? roomCapacity = _reservarUC.dgvReservar_MostrarHabitaciones.SelectedRows[0].Cells["Capacidad"].Value.ToString();
                string? roomNumber = _reservarUC.dgvReservar_MostrarHabitaciones.SelectedRows[0].Cells["NumHabitacion"].Value.ToString();
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
        }
    }
}