namespace Parcial_III___Hotel.Models
{
    public class Usuario
    {
        private int _id;
        private string? _nombreUsuario;
        private string? _contraseña;
        private string? _tipoUsuario;

        public int id { get { return _id; } set { _id = value; } }
        public string? nombreUsuario { get { return _nombreUsuario; } set { _nombreUsuario = value; } }
        public string? contraseña { get { return _contraseña; } set { _contraseña = value; } }
        public string? tipoUsuario { get { return _tipoUsuario; } set { _tipoUsuario = value; } }
    }
}
