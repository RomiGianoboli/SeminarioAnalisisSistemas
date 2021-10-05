using System;
using System.Linq;
using System.Windows.Forms;
using TPI_PAV.Entidades;
using TPI_PAV.Servicios;
using TPI_PAV.Utils;

namespace TPI_PAV.InterfacesDeUsuario.Usuarios
{
    public partial class FrmBajaUsuario : Form
    {
        private Usuario usuario;
        private UsuariosServicio usuarioServicio;
        private PerfilesServicio perfilesServicio;
        public FrmBajaUsuario(long id)
        {
            usuarioServicio = new UsuariosServicio();
            perfilesServicio = new PerfilesServicio();
            usuario = usuarioServicio.GetUsuario(id);
            InitializeComponent();
        }

        private void FrmBajaUsuario_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarPerfiles();
        }

        private void DarBajaUsuario()
        {
            usuarioServicio.DarBajaUsuario(usuario);
            MessageBox.Show("La operación se realizó con éxito", "Información");
        }

        private void CargarDatos()
        {
            TxtNombre.Text = usuario.NombreUsuario;
            TxtEmail.Text = usuario.Email;
            if (usuario.Estado)
                RbActivo.Checked = true;
            else
                RbInactivo.Checked = true;
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

        private void SetBajaUsuario()
        {
            if (RbActivo.Checked)
                usuario.Estado = true;
            if (RbInactivo.Checked)
                usuario.Estado = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                SetBajaUsuario();
                DarBajaUsuario();
                
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
