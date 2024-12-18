using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using Parcial_III___Hotel.DAO;
using System.Data;
using System.Net;

namespace Parcial_III___Hotel.DataAccessObject
{
    public class PayWallDAO : ConnectionString
    {
        public static void GenerarPago(string huesped_id, string NumHabitacion, string id_checks)
        {            
            string insertQuery = "INSERT INTO Pagos (Huesped_Id, Metodo_Pago, Cantidad_A_Pagar, Id_Check) VALUES (@Huesped_Id, 1, @Cantidad_A_Pagar, @Id_Checks)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn))
                {
                    insertCommand.Parameters.AddWithValue("@Huesped_Id", huesped_id);
                    insertCommand.Parameters.AddWithValue("@Cantidad_A_Pagar", ObtenerPrecioReservacion(NumHabitacion));
                    insertCommand.Parameters.AddWithValue("@Id_Checks", id_checks);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        public static string ObtenerIdCheck()
        {
            string obtenerId_Check = "SELECT LAST_INSERT_ID()";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(obtenerId_Check, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        // Convertir el resultado a string y devolverlo
                        return result.ToString();
                    }
                    else
                    {
                        throw new Exception("No se pudo obtener el último ID insertado.");
                    }
                }
            }
        }

        public static int ObtenerPrecioReservacion (string numHabitacion)
        {
            string obtenerPrecioQuery = "SELECT precio FROM habitaciones WHERE NumHabitacion = @NumHabitacion";

            using (MySqlConnection conn = new MySqlConnection (connectionString))
            {
                conn.Open();
                using (MySqlCommand obtenerPrecioCommand = new MySqlCommand(obtenerPrecioQuery, conn))
                {
                    obtenerPrecioCommand.Parameters.AddWithValue("@NumHabitacion", numHabitacion);
                    int precioHabitacion = Convert.ToInt32(obtenerPrecioCommand.ExecuteScalar());

                    return precioHabitacion * ObtenerDiasEstancia(numHabitacion);
                }
            }
        }
        public static int ObtenerDiasEstancia (string numHabitacion)
        {
            string obtenerDiasEstanciaQuery = "SELECT DATEDIFF(Fecha_Salida, Fecha_Entrada) FROM checks WHERE NumHabitacion = @NumHabitacion";

            using (MySqlConnection conn = new MySqlConnection (connectionString))
            {
                conn.Open();
                using (MySqlCommand obtenerDiasEstanciaCommand = new MySqlCommand(obtenerDiasEstanciaQuery, conn))
                {
                    obtenerDiasEstanciaCommand.Parameters.AddWithValue("@NumHabitacion", numHabitacion);
                    return Convert.ToInt32(obtenerDiasEstanciaCommand.ExecuteScalar());
                }
            }
        } 
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
    }
}
