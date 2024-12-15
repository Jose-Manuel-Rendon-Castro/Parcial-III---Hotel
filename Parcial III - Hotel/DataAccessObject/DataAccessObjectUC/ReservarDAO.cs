using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using Parcial_III___Hotel.DAO;
using Parcial_III___Hotel.Views.UserControls;
using System.Data;

namespace Parcial_III___Hotel.DataAccessObject.DataAccessObjectUC
{
    public class ReservarDAO : ConnectionString
    {
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
