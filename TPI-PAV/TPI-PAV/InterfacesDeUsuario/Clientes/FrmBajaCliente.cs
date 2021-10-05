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

namespace TPI_PAV.InterfacesDeUsuario.Clientes
{
    public partial class FrmBajaCliente : Form
    {
        private Cliente cliente;
        private ClientesServicio clienteServicio;
        private BarriosServicio barriosServicio;
        public FrmBajaCliente(long id)
        {

            clienteServicio = new ClientesServicio();
            barriosServicio = new BarriosServicio();
            cliente = clienteServicio.GetCliente(id);
            InitializeComponent();
        }

        private void FrmBajaCliente_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarBarrios();
        }

        private void DarBajaCliente()
        {
            clienteServicio.DarBajaCliente(cliente);
            MessageBox.Show("La operación se realizó con éxito", "Información");
        }

        private void SetBajaCliente()
        {
            if (RbActivo.Checked)
                cliente.Estado = true;
            if (RbInactivo.Checked)
                cliente.Estado = false;
        }

        private void CargarDatos()
        {
            TxtNombre.Text = cliente.NombreCliente;
            TxtEmail.Text = cliente.Email;
            if (cliente.Estado)
                RbActivo.Checked = true;
            else
                RbInactivo.Checked = true;
        }

        private void CargarBarrios()
        {
            var barrios = barriosServicio.GetBarrios();
            var conector = new BindingSource();
            conector.DataSource = barrios;
            FormUtils.CargarCombo(ref CbBarrio, conector, "Nombre", "Id");
            var barrioSeleccionado = barrios.First(b => b.Id == cliente.Barrio.Id);
            CbBarrio.SelectedItem = barrioSeleccionado;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                SetBajaCliente();
                DarBajaCliente();

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
