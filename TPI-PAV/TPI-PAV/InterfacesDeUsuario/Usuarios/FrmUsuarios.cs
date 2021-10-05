using System;
using System.Windows.Forms;
using TPI_PAV.Entidades;
using TPI_PAV.Servicios;

namespace TPI_PAV.InterfacesDeUsuario.Usuarios
{
    public partial class FrmUsuarios : Form
    {
        private PerfilesServicio perfilesServicio;
        private UsuariosServicio usuariosServicio;
        

        public FrmUsuarios()
        {
            perfilesServicio = new PerfilesServicio();
            usuariosServicio = new UsuariosServicio();
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarPerfiles();
            ConsultarUsuarios();
        }

        private void CargarPerfiles()
        {
            var perfiles = perfilesServicio.GetPerfiles();

            var perfilDefault = new Perfil();
            perfilDefault.Nombre = "Seleccionar";
            perfiles.Add(perfilDefault);


            var conector = new BindingSource();
            conector.DataSource = perfiles;

            CbPerfil.DataSource = conector;
            CbPerfil.DisplayMember = "Nombre";
            CbPerfil.ValueMember = "Id";
            CbPerfil.SelectedItem = perfilDefault;

        }



        private void ConsultarUsuarios()
        {
            var usuarioFiltros = new Usuario();
            usuarioFiltros.NombreUsuario = TxtNombre.Text.Trim();
            usuarioFiltros.Perfil = (Perfil)CbPerfil.SelectedItem;
            var incluirTodos = CkIncluirInactivos.Checked;
            var usuarios = usuariosServicio.GetUsuarios(usuarioFiltros, incluirTodos);
            DgvUsuarios.Rows.Clear();

            foreach (var usuario in usuarios)
            {
                var descripcionEstado = usuario.Estado ? "Activo" : "Inactivo";
                var fila = new string[]
                {
                    usuario.Id.ToString(),
                    usuario.NombreUsuario,
                    usuario.Email,
                    usuario.Perfil.Nombre,
                    descripcionEstado
                };
                DgvUsuarios.Rows.Add(fila);
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            new FrmRegistrarUsuario().Show();
            ConsultarUsuarios();
        }




        private void BtnSalir_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("¿Desea salir?", "Información", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                this.Dispose();
            }

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarUsuarios();

        }



        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvUsuarios.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(DgvUsuarios.SelectedRows[0].Cells["Id"].Value);
                new FrmEditarUsuario(id).ShowDialog();
                return;
            }
            if (DgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro.", "Informacion", MessageBoxButtons.OK);
                return;
            }
            if (DgvUsuarios.SelectedRows.Count > 1)
            {
                MessageBox.Show("Debe seleccionar solo un registro, no muchos.", "Informacion", MessageBoxButtons.OK);
            }
        }

        private void BtnDarBaja_Click(object sender, EventArgs e)
        {
            if (DgvUsuarios.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(DgvUsuarios.SelectedRows[0].Cells["Id"].Value);
                new FrmBajaUsuario(id).ShowDialog();
                ConsultarUsuarios();
                return;
            }
            if (DgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro.", "Informacion", MessageBoxButtons.OK);
                return;
            }
            if (DgvUsuarios.SelectedRows.Count > 1)
            {
                MessageBox.Show("Debe seleccionar solo un registro, no muchos.", "Informacion", MessageBoxButtons.OK);
            }
        }
    }


}
