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
using System.Collections.ObjectModel;

namespace TPI_PAV.InterfacesDeUsuario
{
    public partial class VistaFactura : Form
    {
        private Usuario usuarioLogueado;
        public FacturasServicio facturasServicio;
        public ProductosServicio productosServicio;
        public ClientesServicio clientesServicio;
        public int numeroFactura;
        public List<DetalleFactura> listaDetalle = new List<DetalleFactura>();

        

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
            TxtUsuario.Text = $"{usuarioLogueado.NombreUsuario}";
            
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
            var df = new DetalleFactura();

            df.producto = (Producto)CbProducto.SelectedItem;
            df.Precio = Convert.ToDecimal(TxtPrecio.Text);
            df.Cantidad = Convert.ToInt32(TxtCantidad.Text);
            df.Estado = true;
            listaDetalle.Add(df);

            CargarGrilla(listaDetalle);
        }

        private void CargarGrilla(List<DetalleFactura> df)
        {
            decimal totalFactura = 0;
            DgvDetalle.Rows.Clear();
            foreach (var d in df)
            {
                var fila = new string[] {
                    d.Id.ToString(),
                    d.NombreProducto,
                    d.Precio.ToString(),
                    d.Cantidad.ToString(),
                    d.Total.ToString()
                };
                DgvDetalle.Rows.Add(fila);

                totalFactura += d.Total; 
            }

            TxtTotal.Text = totalFactura.ToString();
        }


        private void BtnGenerarFactura_Click(object sender, EventArgs e)
        {
            //Factura fa = new Factura();

            //fa.NumeroFactura = Convert.ToInt32(TxtNumeroFactura.Text);
            //fa.FechaAlta = Convert.ToDateTime(DtpFechaAlta.Value);
            //fa.Usuario.Id = Convert.ToInt32(TxtUsuario.Text);
            //fa.Cliente = (Cliente)CbCliente.SelectedItem;
            //fa.Total = Convert.ToInt32(TxtTotal.Text);

            //facturasServicio.GenerarFactura(fa, listaDetalle);

            ////opc1: si usamos en datasource cuando cargamos la grilla

            //List<DetalleFactura> df = (List<DetalleFactura>)DgvDetalle.DataSource;

            //Opc2
            //List<DetalleFactura> ldf = new List<DetalleFactura>();

            //foreach (DataGridViewRow row in DgvDetalle.Rows)
            //{
            //    DetalleFactura df = new DetalleFactura();

            //    df.producto = row.Cells["nombre"]
            //    df.Precio = Convert.ToDecimal(row.Cells["precio"].ToString());
            //    df.Cantidad = Convert.ToInt32(row.Cells["cantidad"].ToString());

            //    ldf.Add(df);
            //}

            
        }

        private void BtnGenerarFactura_Click_1(object sender, EventArgs e)
        {
            Factura fa = new Factura();

            fa.NumeroFactura = numeroFactura;
            fa.FechaAlta = Convert.ToDateTime(DtpFechaAlta.Value);
            fa.Cliente = (Cliente)CbCliente.SelectedItem;
            fa.Total = Convert.ToDecimal(TxtTotal.Text);
            fa.Usuario = usuarioLogueado;

            facturasServicio.GenerarFactura(fa, listaDetalle);
            MessageBox.Show("Se genero la factura con éxito", "Información");

        }
    }
}
