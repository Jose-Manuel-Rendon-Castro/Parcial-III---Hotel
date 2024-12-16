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
    }
}
