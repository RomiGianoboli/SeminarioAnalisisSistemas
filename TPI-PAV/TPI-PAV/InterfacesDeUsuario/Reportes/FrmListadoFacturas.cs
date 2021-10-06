using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TPI_PAV.Entidades;
using TPI_PAV.Servicios;

namespace TPI_PAV.InterfacesDeUsuario.Reportes
{
    public partial class FrmListadoFacturas : Form
    {
        private ClientesServicio clientesServicio;
        private RepFacturasServicio repFacturasServicio;
        public FrmListadoFacturas()
        {
            repFacturasServicio = new RepFacturasServicio();
            clientesServicio = new ClientesServicio();
            InitializeComponent();
        }

        private void FrmListadoFacturas_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            var clientes = clientesServicio.GetClientes();

            var clientesDefault = new Cliente();
            clientesDefault.NombreCliente = "Seleccionar";
            clientes.Add(clientesDefault);

            var conector = new BindingSource();
            conector.DataSource = clientes;

            CbCliente.DataSource = conector;
            CbCliente.DisplayMember = "NombreCliente";
            CbCliente.ValueMember = "Id";
            CbCliente.SelectedItem = clientesDefault;

        }


        private void CargarGrilla(List<RepFacturas> facturas)
        {
            decimal totalFactura = 0;
            DgvLista.Rows.Clear();
            foreach (var f in facturas)
            {
                var fila = new string[] {
                   f.FechaAlta.ToString("dd/MM/yyyy"),
                   f.ClienteId.ToString(),
                   f.Total.ToString()

                };
                DgvLista.Rows.Add(fila);

                totalFactura += f.Total;
            }

            TxtTotal.Text = totalFactura.ToString();
        }
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                var filtros = new RepFacturas()
                {
                    FechaDesde = DtpFechaDesde.Value,
                    FechaHasta = DtpFechaHasta.Value,
                    ClienteId = ((Cliente)CbCliente.SelectedItem).Id,
                  
                };
                Consultar(filtros);


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
        
        private void Consultar(RepFacturas filtros)
        {
            var facturas = repFacturasServicio.Obtener(filtros);
            CargarGrilla(facturas);

        }
    }
}
