using MySql.Data.MySqlClient;
using Parcial_III___Hotel.Models;
using Parcial_III___Hotel.DAO;

namespace Parcial_III___Hotel.DataAccessObject
{
    public class LoginDAO : ConnectionString
    {
        public static Usuario? Login(string input_nombreUsuario, string input_contraseña)
        {
            string loginQuery = "SELECT COUNT(*) FROM Usuarios WHERE Nombre_Usuario = @Nombre_Usuario AND Contraseña = @Contraseña";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand loginCommand = new MySqlCommand(loginQuery, conn))
                    {
                        loginCommand.Parameters.AddWithValue("@Nombre_Usuario", input_nombreUsuario.Trim());
                        loginCommand.Parameters.AddWithValue("Contraseña", input_contraseña.Trim());

                        int result = Convert.ToInt32(loginCommand.ExecuteScalar());
                        if (result > 0)
                        {
                            Usuario? usuario = getUsuarioData(input_nombreUsuario, input_contraseña);
                            return usuario;
                        }
                        else { return null; }
                    }
                }
            }   
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private static Usuario? getUsuarioData(string input_nombreUsuario, string input_contraseña)
        {
            string getDataQuery = "SELECT * FROM Usuarios WHERE Nombre_Usuario = @Nombre_Usuario AND Contraseña = @Contraseña";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand getDataCommand = new MySqlCommand(getDataQuery, conn))
                {
                    getDataCommand.Parameters.AddWithValue("@nombre_Usuario", input_nombreUsuario.Trim());
                    getDataCommand.Parameters.AddWithValue("@Contraseña", input_contraseña.Trim());
                    using (MySqlDataReader reader = getDataCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                id = reader.GetInt32("Id"),
                                nombreUsuario = reader.GetString("Nombre_Usuario"),
                                contraseña = reader.GetString("Contraseña"),
                                tipoUsuario = reader.GetString("Tipo_Usuario")
                            };
                            return usuario;
                        }
                        else { return null; }
                    }
                }
            }
        }
    }
}
