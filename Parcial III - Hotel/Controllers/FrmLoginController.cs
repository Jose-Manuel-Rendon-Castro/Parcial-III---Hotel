using Parcial_III___Hotel.DAO;
using Parcial_III___Hotel.Exceptions;
using Parcial_III___Hotel.Models;
using Parcial_III___Hotel.Views;

namespace Parcial_III___Hotel.Controllers
{
    public class FrmLoginController
    {
        private FrmLogin _frmLogin;

        public FrmLoginController(FrmLogin frmLogin)
        {
            _frmLogin = frmLogin;
            _frmLogin.btnLogin_Salir.Click += btnLogin_Salir_Click;
            _frmLogin.btnLogin_IniciarSesion.Click += btnLogin_IniciarSesion_Click;
        }
        
        private void btnLogin_IniciarSesion_Click(object? sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(_frmLogin.txtBLogin_Usuario.Text) || String.IsNullOrEmpty(_frmLogin.txtBLogin_Contraseña.Text))
                {
                    throw new EmptyFieldException();
                }

                Usuario? userOnUse = LoginDAO.Login(
                    _frmLogin.txtBLogin_Usuario.Text,
                    _frmLogin.txtBLogin_Contraseña.Text
                );
                if ( userOnUse != null )
                {
                    FrmMenuNavegacion frmMenuNavegacion = new FrmMenuNavegacion(userOnUse);
                    MessageBox.Show("Sesion Iniciada");
                    _frmLogin.Hide();

                    frmMenuNavegacion.FormClosed += (s, args) => _frmLogin.Show();
                    frmMenuNavegacion.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Credenciales no coinciden o son inexistentes");
                    return;
                }
            }
            catch (EmptyFieldException ex)
            {
                MessageBox.Show(ex.Message, "Datos incorrectos");
            }
        }
        private void btnLogin_Salir_Click(object? sender, EventArgs e)
        {
            _frmLogin.Close();
        }
    }
}
