using System.Drawing.Printing;
using System.Security.Cryptography.X509Certificates;

namespace Parcial_III___Hotel.Models
{
    public class Huesped
    {
        private int _id;
        private string _nombre;
        private int _numCelular;
        private string _correo;
        private string _membresia;
        private bool _isMembresia;

        public int id { get { return _id; } set { _id = value; } }
        public string nombre { get { return _nombre; } set { _nombre = value; } }
        public int numCelular { get { return _numCelular; } set {_numCelular = value; } }
        public string correo { get { return _correo; } set { _correo = value; } }
        public string membresia { get { return _membresia; } set { _membresia = value; } }
        public bool isMembresia { get { return _isMembresia; } set { _isMembresia = value; } }

        public Huesped(int id, string nombre, int numCelular, string correo, string membresia, bool isMembresia)
        {
            id = this.id;
            nombre = this.nombre;
            numCelular = this.numCelular;
            correo = this.correo;
            membresia = this.membresia;
            isMembresia = this.isMembresia;
        }
    }
}
