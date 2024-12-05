namespace Parcial_III___Hotel.Exceptions
{
    public class EmptyFieldException : Exception
    {
        public EmptyFieldException() : base("Llene los campos obligatorios para continuar") { }
    }
}
