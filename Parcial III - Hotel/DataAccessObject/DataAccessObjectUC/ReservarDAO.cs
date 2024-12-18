using MySql.Data.MySqlClient;
using Parcial_III___Hotel.DAO;
using Parcial_III___Hotel.Models;
using System.Data;

namespace Parcial_III___Hotel.DataAccessObject.DataAccessObjectUC
{
    public class ReservarDAO : ConnectionString
    {
        public static List<Huesped> ObtenerHuespedes()
        {
            string selectQuery = "SELECT * FROM huespedes";
            List<Huesped> Huespedes = new List<Huesped>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn))
                {
                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["Huesped_Id"]);
                            string? nombre = reader["Nombre"].ToString() ?? string.Empty;
                            decimal numCelular = Convert.ToDecimal(reader["NumCelular"]);
                            string? correo = reader["Correo"].ToString() ?? string.Empty;
                            string? membresia = reader["Tipo_Membresia"].ToString() ?? string.Empty;
                            bool isMembresia = Convert.ToBoolean(reader["Estado_Membresia"]);

                            Huesped huesped = new Huesped(id, nombre, numCelular, correo, membresia, isMembresia);
                            Huespedes.Add(huesped);
                        }
                    }
                }
            }
            return Huespedes;
        }
        private static int obtenerIdHuesped(string nombre)
        {
            string selectQuery = "SELECT Huesped_Id FROM huespedes WHERE Nombre = @Nombre";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectCommnad = new MySqlCommand(selectQuery, conn))
                {
                    selectCommnad.Parameters.AddWithValue("@Nombre", nombre);
                    return Convert.ToInt32(selectCommnad.ExecuteScalar());
                }
            }
        }

        public static void ReservarHabitacion(string nombre, DateTime fecha_Entrada, DateTime fecha_Salida, DataGridView dataGridView)
        {
            string checkQuery = "INSERT INTO Checks (Fecha_Entrada, Fecha_Salida, Huesped_Id, NumHabitacion, Estado_Checks) VALUES (@Fecha_Entrada, @Fecha_Salida, @Huesped_Id, @NumHabitacion, @Estado_Checks)";
            string? roomType = dataGridView.SelectedRows[0].Cells["Tipo_Habitacion"].Value.ToString();
            string? roomCapacity = dataGridView.SelectedRows[0].Cells["Capacidad"].Value.ToString();
            string? roomNumber = dataGridView.SelectedRows[0].Cells["NumHabitacion"].Value.ToString();
            int huespedId = obtenerIdHuesped(nombre);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(checkQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Fecha_Entrada", fecha_Entrada);
                        cmd.Parameters.AddWithValue("@Fecha_Salida", fecha_Salida);
                        cmd.Parameters.AddWithValue("@Huesped_Id", huespedId);
                        cmd.Parameters.AddWithValue("@NumHabitacion", roomNumber);
                        cmd.Parameters.AddWithValue("@Estado_Checks", "Pendiente");
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Reservacion creada exitosamente!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void MostrarHabitacionesDisponibles(DataGridView dataGridView)
        {
            string selectQuery = "SELECT numhabitacion, tipo_habitacion, tipo_vista, precio, capacidad FROM suitesavage.habitaciones WHERE Disponibilidad = 'disponible'";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn))
                    {
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter())
                        {
                            dataAdapter.SelectCommand = selectCommand;
                            DataTable dbDataSet = new DataTable();
                            dataAdapter.Fill(dbDataSet);
                            BindingSource bSource = new BindingSource();

                            bSource.DataSource = dbDataSet;
                            dataGridView.DataSource = bSource;
                            dataAdapter.Update(dbDataSet);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
