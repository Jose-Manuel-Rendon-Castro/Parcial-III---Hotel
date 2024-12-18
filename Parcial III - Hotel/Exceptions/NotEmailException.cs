namespace Parcial_III___Hotel.Exceptions    
{
    public class NotEmailException : Exception
    {
        public NotEmailException() : base("Ingrese un correo electrónico válido") { }
    }
}
