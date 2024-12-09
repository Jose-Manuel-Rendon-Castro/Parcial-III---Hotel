﻿using MySql.Data.MySqlClient;
using Parcial_III___Hotel.DataAccessObject;
using System.Data;

namespace Parcial_III___Hotel.DataAccessObject.DataAccessObjectUC
{
    public class CheckInDAO : ConnectionString
    {
        public static void TablaHuespedes(DataGridView listaHuespedes)
        {
            string selectQuery = "SELECT * FROM Checks WHERE DATE(Fecha_Entrada) = CURDATE()";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn))
                {
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectCommand))
                    {
                        DataTable dataTable = new DataTable();
                        
                        dataAdapter.Fill(dataTable);
                        listaHuespedes.DataSource = dataTable;

                    }
                }
            }
        }

        public static void UpdateCheckStatus(DataGridView dataGridView)
        {
            string updateString = "UPDATE Checks SET Estado_Checks = 'ACTIVO' WHERE id = @id";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand updateCommand = new MySqlCommand(updateString, conn))
                {
                    int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[1].Value);
                    updateCommand.Parameters.AddWithValue("@id", id);
                    updateCommand.ExecuteNonQuery();
                }
            }
        }
    }
}