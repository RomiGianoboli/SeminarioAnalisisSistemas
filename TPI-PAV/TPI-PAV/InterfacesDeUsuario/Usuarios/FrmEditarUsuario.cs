using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_PAV.Entidades;
using TPI_PAV.Servicios;
using TPI_PAV.Utils;

namespace TPI_PAV.InterfacesDeUsuario.Usuarios
{
    public partial class FrmEditarUsuario : Form
    {
        private Usuario usuario;
        private UsuariosServicio usuarioServicio;
        private PerfilesServicio perfilesServicio;
        public FrmEditarUsuario(long id)
        {
            perfilesServicio = new PerfilesServicio();
            usuarioServicio = new UsuariosServicio();
            usuario = usuarioServicio.GetUsuario(id);
            InitializeComponent();
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarPerfiles();

        }

        private void CargarPerfiles()
        {
            var perfiles = perfilesServicio.GetPerfiles();
            var conector = new BindingSource();
            conector.DataSource = perfiles;
            FormUtils.CargarCombo(ref CbPerfil, conector, "Nombre", "Id");
            var perfilSeleccionado = perfiles.First(p => p.Id == usuario.Perfil.Id);
            CbPerfil.SelectedItem = perfilSeleccionado;

        }

        private void CargarDatos()
        {
            TxtNombre.Text = usuario.NombreUsuario;
            TxtPassword.Text = usuario.Contrasenia;
            TxtRePassword.Text = usuario.Contrasenia;
            TxtEmail.Text = usuario.Email;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                ValidarUsuario();
                ActualizarUsuario();
            
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarUsuario()
        {
            var password = TxtPassword.Text;
            var repassword = TxtRePassword.Text;
            if (password != repassword)
            {
                throw new ApplicationException("La contraseña no coincide");
            }
            usuario.Contrasenia = password;
            usuario.Perfil = (Perfil)CbPerfil.SelectedItem;
            usuario.Email = TxtEmail.Text;
            usuarioServicio.ValidarUsuario(usuario);
        }

        private void ActualizarUsuario()
        {
            usuarioServicio.ActualizarUsuario(usuario);
            MessageBox.Show("Se actualizó el usuario con éxito", "Información");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("¿Desea salir?", "Información", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                this.Dispose();
            }
        }
    }
}
