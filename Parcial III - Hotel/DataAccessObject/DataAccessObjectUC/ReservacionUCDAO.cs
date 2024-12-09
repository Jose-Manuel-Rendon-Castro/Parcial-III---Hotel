using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
