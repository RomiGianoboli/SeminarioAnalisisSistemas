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
    public partial class FrmRegistrarCliente : Form
    {
        private Cliente cliente;
        private ClientesServicio clienteServicio;
        private BarriosServicio barriosServicio;
        public FrmRegistrarCliente()
        {
            barriosServicio = new BarriosServicio();
            clienteServicio = new ClientesServicio();
            InitializeComponent();
        }

        private void FrmRegistrarCliente_Load(object sender, EventArgs e)
        {
            CargarBarrios();
        }

        private void CargarBarrios()
        {
            var barrios = barriosServicio.GetBarrios();

            var barrioSeleccionado = barrios.First();
            var conector = new BindingSource();
            
            conector.DataSource = barrios;
            CbBarrio.DataSource = conector;
            CbBarrio.DisplayMember = "NombreBarrio";
            CbBarrio.ValueMember = "Id";
            CbBarrio.SelectedItem = barrioSeleccionado;
        }

        private void RegistrarCliente()
        {
            if (!clienteServicio.RegistrarCliente(cliente))
            {
                MessageBox.Show("Ocurrió un problema al registrar el cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("El cliente se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("Desea confirmar la operación", "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }

        private bool EsClienteValido()
        {

            var nombre = TxtNombre.Text;
            var calle = TxtCalle.Text;
            var numero = Convert.ToInt32(TxtNumero.Text.Trim());
            var barrio = (Barrio)CbBarrio.SelectedItem;
            var fechaAlta = Convert.ToDateTime(DtpFechaAlta.Text.Trim());
            var email = TxtEmail.Text;

            var clienteIngresado = new Cliente();
            clienteIngresado.NombreCliente = nombre;
            clienteIngresado.Email = email;
            clienteIngresado.Calle = calle;
            clienteIngresado.NumeroCalle = numero;
            clienteIngresado.FechaAlta = fechaAlta;
            clienteIngresado.Barrio = barrio;
            clienteServicio.ValidarCliente(clienteIngresado);
            cliente = clienteIngresado;
            return true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                if (!EsClienteValido())
                    return;
                RegistrarCliente();
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
    }
}
