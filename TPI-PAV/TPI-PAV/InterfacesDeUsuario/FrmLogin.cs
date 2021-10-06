using System;
using System.Windows.Forms;
using TPI_PAV.Entidades;
using TPI_PAV.Servicios;

namespace TPI_PAV.InterfacesDeUsuario
{
    public partial class FrmLogin : Form
    {
        private UsuariosServicio usuariosServicio;
        public FrmLogin()
        {
            InitializeComponent();
            usuariosServicio = new UsuariosServicio();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            var usuarioIngresado = TxtUsuario.Text;

            Usuario usuario = new Usuario();
            usuario.NombreUsuario = usuarioIngresado;
            usuario.Contrasenia = TxtContrasenia.Text;

            var usuarioLogueado = usuariosServicio.Login(usuario);
            if (usuarioLogueado == null)
            {
                MessageBox.Show("Usuario/contraseña inválida", "Información", MessageBoxButtons.OK);
            }
            else
            {
                this.Dispose();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
                this.Dispose();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

    }
}
