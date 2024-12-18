using MySql.Data.MySqlClient;
using Parcial_III___Hotel.DAO;

namespace Parcial_III___Hotel.DataAccessObject
{
    public class CrearCliente_HuespedDAO : ConnectionString
    {
        public static void CrearCliente_Huesped(string newName, string newNumCelular, string newCorreo, string newTipoMembresia)
        {
            string insertQuery = "INSERT INTO huespedes (Nombre, NumCelular, Correo, Tipo_Membresia, Estado_Membresia) VALUES (@Nombre, @NumCelular, @Correo, @Tipo_Membresia, @Estado_Membresia)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn))
                {
                    insertCommand.Parameters.AddWithValue("@Nombre", newName);
                    insertCommand.Parameters.AddWithValue("@NumCelular", newNumCelular);
                    insertCommand.Parameters.AddWithValue("@Correo", newCorreo);
                    insertCommand.Parameters.AddWithValue("@Tipo_Membresia", newTipoMembresia);
                    insertCommand.Parameters.AddWithValue("@Estado_Membresia", "1");
                    insertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
