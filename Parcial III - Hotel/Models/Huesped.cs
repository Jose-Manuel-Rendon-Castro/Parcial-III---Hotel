using System.Drawing.Printing;
using System.Security.Cryptography.X509Certificates;

namespace Parcial_III___Hotel.Models
{
    public class Huesped
    {
        public int HuespedId {  get; set; }
        public string Nombre { get; set; }
        public decimal NumCelular { get; set; }
        public string Correo { get; set; }
        public string TipoMembresia { get; set; }
        public bool EstadoMembresia { get; set; }

        public Huesped(int id, string nombre, decimal numCelular, string correo, string tipoMembresia, bool estadoMembresia)
        {
            HuespedId = id;
            Nombre = nombre;
            NumCelular = numCelular;
            Correo = correo;
            TipoMembresia = tipoMembresia;
            EstadoMembresia = estadoMembresia;
        }

        public static bool EsCorreo(string input_email)
        {
            return input_email.Contains("@gmail.com") ||
                   input_email.Contains("@hotmail.com") ||
                   input_email.Contains("@outlook.com") ||
                   input_email.Contains("@yahoo.com") ||
                   input_email.Contains("@icloud.com");
        }
    }
}
