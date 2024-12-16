using MySql.Data.MySqlClient;
using Parcial_III___Hotel.DAO;
using System.Data;
using System.Net;

namespace Parcial_III___Hotel.DataAccessObject
{
    public class PayWallDAO : ConnectionString
    {
        public static decimal CantidadPagar(decimal ID)
        {
            string selectQuery = "SELECT Cantidad_A_Pagar FROM Pagos WHERE Id_Check = @Id_Check LIMIT 1";  // Limitamos a 1 para evitar duplicados

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn))
                {
                    selectCommand.Parameters.AddWithValue("@Id_Check", ID);

                    object result = selectCommand.ExecuteScalar();

                    if (decimal.TryParse(result.ToString(), out decimal cantidad))
                    {
                        return cantidad;
                    }
                    else
                    {
                        throw new Exception($"No se encontró un pago registrado para el ID_Check: {ID}.");
                    }
                }
            }
        }
        /*public static void GenerarPago()
        {
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
                    cmd.Parameters.AddWithValue("@Estado_Membresia", 1);

                    cmd.ExecuteNonQuery();

                    // Retrieve the auto-generated guest_id
                    guestId = cmd.LastInsertedId; // Retrieves the LAST_INSERT_ID()
                }
            }
        }*/
    }
}
