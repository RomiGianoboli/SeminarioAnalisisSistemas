using System;
using System.Linq;
using System.Windows.Forms;
using TPI_PAV.Entidades;
using TPI_PAV.Servicios;

namespace TPI_PAV.InterfacesDeUsuario.Usuarios
{
    public partial class FrmRegistrarUsuario : Form
    {
        private Usuario usuario;
        private UsuariosServicio usuarioServicio;
        private PerfilesServicio perfilesServicio;
       

        public FrmRegistrarUsuario() //completar argumentos
        {
            usuarioServicio = new UsuariosServicio();
            perfilesServicio = new PerfilesServicio();
            InitializeComponent();
        }

       
        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("Desea confirmar la operación", "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }

        private bool EsUsuarioValido()
        {
            var password = TxtPassword.Text;
            var repassword = TxtRePassword.Text;
            if (password != repassword)
            {
                MessageBox.Show("La constraseña no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            var nombre = TxtNombre.Text;
            var perfil = (Perfil)CbPerfil.SelectedItem;
            var email = TxtEmail.Text;

            var usuarioIngresado = new Usuario();
            usuarioIngresado.NombreUsuario = nombre;
            usuarioIngresado.Email = email;
            usuarioIngresado.Contrasenia = password;
            usuarioIngresado.Perfil = perfil;
            usuarioServicio.ValidarUsuario(usuarioIngresado);
            usuario = usuarioIngresado;
            return true;
        }


        private void CargarPerfiles()
        {
            var perfiles = perfilesServicio.GetPerfiles();
            var perfilSeleccionado = perfiles.First();
            var conector = new BindingSource();
            conector.DataSource = perfiles;
            CbPerfil.DataSource = conector;
            CbPerfil.DisplayMember = "Nombre";
            CbPerfil.ValueMember = "Id";
            CbPerfil.SelectedItem = perfilSeleccionado;
        }

        private void FrmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            CargarPerfiles();
        }

        private void RegistrarUsuario()
        {
            if (!usuarioServicio.RegistrarUsuario(usuario))
            {
                MessageBox.Show("Ocurrió un problema al registrar el usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("El usuario se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                if (!EsUsuarioValido())
                    return;
                RegistrarUsuario();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                var mensaje = ex.Message;
                MessageBox.Show("Ha ocurrido un problema, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("¿Desea salir?", "Información", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                this.Dispose();
                
            }
         

        }

        private void CbPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

