using MySql.Data.MySqlClient;
using System.Data;
using Parcial_III___Hotel.DAO;

namespace Parcial_III___Hotel.DataAccessObject.DataAccessObjectUC
{
    public class ReservacionUCDAO : ConnectionString

    {
        public static void MostrarTabla(DataGridView dataGridView)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Habitaciones"; 
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las habitaciones: " + ex.Message);
                }
            }
        }
        public static void DisponibleoNO(DataGridView dataGridView)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
               
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Habitaciones where habitaciones = true";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las habitaciones: " + ex.Message);
                }
            }
        }

    }
}
