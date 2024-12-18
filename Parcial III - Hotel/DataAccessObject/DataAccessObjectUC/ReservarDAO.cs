using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using Parcial_III___Hotel.DAO;
using Parcial_III___Hotel.Models;
using Parcial_III___Hotel.Views.UserControls;
using System.Data;

namespace Parcial_III___Hotel.DataAccessObject.DataAccessObjectUC
{
    public class ReservarDAO : ConnectionString
    {
        public static List<Huesped> ObtenerHuespedes()
        {
            string selectQuery = "SELECT Nombre FROM huespedes";
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
                            int id = Convert.ToInt16(reader["Huesped_Id"]);
                            string? nombre = reader["Nombre"].ToString() ?? string.Empty;
                            int numCelular = Convert.ToInt32(reader["NumCelular"]);
                            string? correo = reader["Correo"].ToString() ?? string.Empty;
                            string? membresia = reader["Tipo_Membresia"].ToString() ?? string.Empty;
                            bool isMembresia = (reader["Estado_Membresia"].ToString() == "1") ? true : false;

                            Huesped huesped = new Huesped(id, nombre, numCelular, correo, membresia, isMembresia);
                            Huespedes.Add(huesped);
                        }
                        return Huespedes;
                    }
                }
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
