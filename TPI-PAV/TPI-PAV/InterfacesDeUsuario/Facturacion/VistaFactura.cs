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

namespace TPI_PAV.InterfacesDeUsuario
{
    public partial class VistaFactura : Form
    {
        private Usuario usuarioLogueado;
        public FacturasServicio facturasServicio;
        public ProductosServicio productosServicio;
        public ClientesServicio clientesServicio;
        public int numeroFactura;
        public List<DetalleFactura> listaDetalle;
        public VistaFactura()
        {

            facturasServicio = new FacturasServicio();
            productosServicio = new ProductosServicio();
            clientesServicio = new ClientesServicio();
            listaDetalle = new List<DetalleFactura>();
            
            numeroFactura = facturasServicio.ObtenerSiguienteNumeroFactura();
            InitializeComponent();
        }

        private void LblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void VistaFactura_Load(object sender, EventArgs e)
        {
            SetearUltimoNumeroFactura();

            CargarClientes();

            CargarProductos();
            usuarioLogueado = UsuariosServicio.UsuarioLogueado;
            TxtUsuario.Text = $"{usuarioLogueado.NombreUsuario} - Perfil:{usuarioLogueado.Perfil.Id}";
        }

        private void CargarClientes()
        {

            var clientes = clientesServicio.GetClientes();
            var clienteSeleccionado = clientes.First();
            var conector = new BindingSource();
            conector.DataSource = clientes;
            CbCliente.DataSource = conector;
            CbCliente.DisplayMember = "NombreCliente";
            CbCliente.ValueMember = "Id";
            CbCliente.SelectedItem = clienteSeleccionado;
        }

        private void CargarProductos()
        {
            var conector = new BindingSource();
            conector.DataSource = productosServicio.GetProductos();

            CbProducto.DataSource = conector;
            CbProducto.DisplayMember = "NombreProducto";
            CbProducto.ValueMember = "Id";
            CbProducto.SelectedIndex = 0;
        }



        private void SetearUltimoNumeroFactura()
        {
            var strNumFactura = numeroFactura.ToString().PadLeft(7, '0');
            TxtNumeroFactura.Text = $"001-{strNumFactura}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProduct = (Producto)CbProducto.SelectedItem;
            TxtPrecio.Text = selectedProduct.Precio.ToString();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
            
        }

        

        private void AgregarProducto()
        {

            DetalleFactura df = new DetalleFactura();

            df.producto =(Producto)CbProducto.SelectedItem;
            df.Precio = Convert.ToDecimal(TxtPrecio.Text);
            df.Cantidad = Convert.ToInt32(TxtCantidad.Text);
            df.Estado = true;
            listaDetalle.Add(df);

            RefrescarGrilla();

        }

        
        private void AgregarProducto2()
        {
            DgvDetalle.Rows.Clear();

        }
        

        private void RefrescarGrilla()
        {
            DgvDetalle.DataSource = listaDetalle;
            DgvDetalle.Refresh();
        }

        private void BtnGenerarFactura_Click(object sender, EventArgs e)
        {
            Factura fa = new Factura();
            DetalleFactura ld = new DetalleFactura();
            //TODO CARGAR OBJETO

            facturasServicio.GenerarFactura(fa, ld);
        }
    }
}
