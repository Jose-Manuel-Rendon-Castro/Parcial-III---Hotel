using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_III___Hotel.Exceptions
{
    public class NotCelNumberException : Exception
    {
        public NotCelNumberException() : base ("Ingrese un numero de contacto válido (10 digitos)") { }
    }
}
