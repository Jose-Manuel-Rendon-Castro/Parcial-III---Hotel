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

        public static void MostrarTabla(DataGridView dataGridView, string nombreTabla, string numPrecioMin, string numPrecioMax, string disponibilidad, string tipoVista, string tipoHabitacion, string busquedaNombre)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand selectCommand = new MySqlCommand(FiltradoDatos(nombreTabla, numPrecioMin, numPrecioMax, disponibilidad, tipoVista, tipoHabitacion, busquedaNombre), conn))
                    {
                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            using (DataTable dataTable = new DataTable())
                            {
                                dataTable.Load(reader);
                                dataGridView.DataSource = dataTable;
                                dataGridView.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error de base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private static string FiltradoDatos(string nombreTabla, string numPrecioMin, string numPrecioMax, string disponibilidad, string tipoVista, string tipoHabitacion, string busquedaNombre)
        {
            string selectQuery = $"SELECT * FROM {nombreTabla}";
            List<string> condiciones = new List<string>();

            if (!string.IsNullOrEmpty(tipoHabitacion)) { condiciones.Add($"Tipo_Habitacion = '{tipoHabitacion}'"); }
            if (!string.IsNullOrEmpty(disponibilidad)) { condiciones.Add($"Disponibilidad = '{disponibilidad}'"); }
            if (!string.IsNullOrEmpty(tipoVista)) { condiciones.Add($"Tipo_Vista = '{tipoVista}'"); }
            if (!string.IsNullOrEmpty(busquedaNombre)) { condiciones.Add($"Nombre LIKE '%{busquedaNombre}%'"); }

            // Filtro de precio: cada valor puede ser independiente
            if (!string.IsNullOrEmpty(numPrecioMin))
            {
                condiciones.Add($"Precio >= {numPrecioMin}");
            }
            if (!string.IsNullOrEmpty(numPrecioMax))
            {
                condiciones.Add($"Precio <= {numPrecioMax}");
            }

            if (condiciones.Count > 0)
            {
                selectQuery += " WHERE " + string.Join(" AND ", condiciones);
            }

            return selectQuery;
        }


    }







}
