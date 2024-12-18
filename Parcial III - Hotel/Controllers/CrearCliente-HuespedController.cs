using Parcial_III___Hotel.DataAccessObject;
using Parcial_III___Hotel.Exceptions;
using Parcial_III___Hotel.Views;
using ZstdSharp.Unsafe;

namespace Parcial_III___Hotel.Controllers
{
    public class CrearCliente_HuespedController
    {
        private FrmCrearCliente_Huesped _frmCrearCliente_Huesped;

        public CrearCliente_HuespedController(FrmCrearCliente_Huesped frmCrearCliente_Huesped)
        {
            _frmCrearCliente_Huesped = frmCrearCliente_Huesped;
            _frmCrearCliente_Huesped.btnCrearCliente_Crear.Click += btnCrearCliente_Crear_Click;
        }

        private void btnCrearCliente_Crear_Click (object? sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(_frmCrearCliente_Huesped.txtbCrearCliente_Nombre.Text) ||
                    String.IsNullOrEmpty(_frmCrearCliente_Huesped.txtbCrearCliente_Apellido.Text) ||
                    String.IsNullOrEmpty(_frmCrearCliente_Huesped.txtbCrearCliente_Correo.Text) ||
                    String.IsNullOrEmpty(_frmCrearCliente_Huesped.txtbCrearCliente_NumCelular.Text))
                {
                    throw new EmptyFieldException(); 
                }

                CrearCliente_HuespedDAO.CrearCliente_Huesped(
                    _frmCrearCliente_Huesped.txtbCrearCliente_Nombre.Text,
                    _frmCrearCliente_Huesped.txtbCrearCliente_Apellido.Text,
                    _frmCrearCliente_Huesped.txtbCrearCliente_Correo.Text,
                    _frmCrearCliente_Huesped.txtbCrearCliente_NumCelular.Text);
            }

            catch (EmptyFieldException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCrearCliente_Salir_Click (object? sender, EventArgs e)
        {
            _frmCrearCliente_Huesped.Close();
        }
    }
}
