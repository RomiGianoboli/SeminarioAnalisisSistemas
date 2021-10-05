using System;
using System.Linq;
using System.Windows.Forms;
using TPI_PAV.Entidades;
using TPI_PAV.Servicios;
using TPI_PAV.Utils;

namespace TPI_PAV.InterfacesDeUsuario.Clientes
{
   
    public partial class FrmEditarCliente : Form
    {
        private Cliente cliente;
        private ClientesServicio clienteServicio;
        private BarriosServicio barriosServicio;
        public FrmEditarCliente(long id)
        {
            barriosServicio = new BarriosServicio();
            clienteServicio = new ClientesServicio();
            cliente = clienteServicio.GetCliente(id);
            InitializeComponent();
        }

        private void FrmEditarCliente_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarBarrios();

        }
        private void CargarDatos()
        {
            TxtNombre.Text = cliente.NombreCliente;
            TxtCalle.Text = cliente.Calle;
            TxtNumero.Text = cliente.NumeroCalle.ToString();
            //TxtEmail.Text = cliente.Email;
           
        }

        private void CargarBarrios()
        {
            var barrios = barriosServicio.GetBarrios();
            var conector = new BindingSource();
            conector.DataSource = barrios;
            FormUtils.CargarCombo(ref CbBarrio, conector, "NombreBarrio", "Id");
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
                ValidarCliente();
                ActualizarCliente();

            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                var mensaje = ex.Message;
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarCliente()
        {
            cliente.Barrio = (Barrio)CbBarrio.SelectedItem;
            cliente.Calle = TxtCalle.Text;
            cliente.NumeroCalle = Convert.ToInt32(TxtNombre.Text.Trim());
            //cliente.Email = TxtEmail.Text;
            clienteServicio.ValidarCliente(cliente);
        }

        private void ActualizarCliente()
        {
            clienteServicio.ActualizarCliente(cliente);
            MessageBox.Show("Se actualizó el cliente con éxito", "Información");
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
