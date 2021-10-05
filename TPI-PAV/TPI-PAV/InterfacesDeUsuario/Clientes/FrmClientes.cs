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
using TPI_PAV.InterfacesDeUsuario.Clientes;
using TPI_PAV.Servicios;

namespace TPI_PAV.InterfacesDeUsuario
{
    public partial class FrmCliente : Form
    {
        private BarriosServicio barriosServicio;
        private ClientesServicio clientesServicio;
        private Principal principal;
        public FrmCliente(Principal _principal)
        {
            barriosServicio = new BarriosServicio();
            clientesServicio = new ClientesServicio();
            principal = _principal;
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CargarBarrios();
            ConsultarClientes();

        }

        private void CargarBarrios()
        {
            var barrios = barriosServicio.GetBarrios();

            var barriosDefault = new Barrio();
            barriosDefault.NombreBarrio = "Seleccionar";
            barrios.Add(barriosDefault);


            var conector = new BindingSource();
            conector.DataSource = barrios;

            CbBarrio.DataSource = conector;
            CbBarrio.DisplayMember = "NombreBarrio";
            CbBarrio.ValueMember = "Id";
            CbBarrio.SelectedItem = barriosDefault;

        }
        private void ConsultarClientes()
        {
            var clientesFiltros = new Cliente();
            clientesFiltros.NombreCliente = TxtNombre.Text.Trim();
            clientesFiltros.Barrio = (Barrio)CbBarrio.SelectedItem;
            var incluirTodos = CkIncluirInactivos.Checked;
            var clientes = clientesServicio.GetClientes(clientesFiltros, incluirTodos);
            DgvClientes.Rows.Clear();

            foreach (var cliente in clientes)
            {
                var descripcionEstado = cliente.Estado ? "Activo" : "Inactivo";
                var fila = new string[]
                {
                    cliente.Id.ToString(),
                    cliente.NombreCliente,
                    cliente.Calle,
                    cliente.NumeroCalle.ToString(),
                    cliente.Barrio.NombreBarrio,
                    cliente.FechaAlta.ToLongDateString(),
                    cliente.Email,
                    descripcionEstado
                };
                DgvClientes.Rows.Add(fila);
            }
        }


        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            new FrmRegistrarCliente().Show();
            ConsultarClientes();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvClientes.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(DgvClientes.SelectedRows[0].Cells["Id"].Value);
                new FrmEditarCliente(id).ShowDialog();
                return;
            }
            if (DgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro.", "Informacion", MessageBoxButtons.OK);
                return;
            }
            if (DgvClientes.SelectedRows.Count > 1)
            {
                MessageBox.Show("Debe seleccionar solo un registro, no muchos.", "Informacion", MessageBoxButtons.OK);
            }
        }

        private void BtnDarBaja_Click(object sender, EventArgs e)
        {
            if (DgvClientes.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(DgvClientes.SelectedRows[0].Cells["Id"].Value);
                new FrmBajaCliente(id).ShowDialog();
                ConsultarClientes();
                return;
            }
            if (DgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro.", "Informacion", MessageBoxButtons.OK);
                return;
            }
            if (DgvClientes.SelectedRows.Count > 1)
            {
                MessageBox.Show("Debe seleccionar solo un registro, no muchos.", "Informacion", MessageBoxButtons.OK);
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

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarClientes();
        }
    }
}
