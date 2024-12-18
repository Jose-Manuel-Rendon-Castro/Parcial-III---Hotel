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

                string nombreCompleto = _frmCrearCliente_Huesped.txtbCrearCliente_Nombre.Text.Trim() + " " + _frmCrearCliente_Huesped.txtbCrearCliente_Apellido.Text.Trim();
                string numCelular = _frmCrearCliente_Huesped.txtbCrearCliente_NumCelular.Text.Trim();
                string correo = _frmCrearCliente_Huesped.txtbCrearCliente_Correo.Text.Trim();
                string membresia = _frmCrearCliente_Huesped.combxCrearCliente_Membresia.Text.Trim();

                CrearCliente_HuespedDAO.CrearCliente_Huesped(nombreCompleto, numCelular, correo, membresia);
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
