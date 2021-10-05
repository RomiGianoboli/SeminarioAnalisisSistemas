using System;
using System.Windows.Forms;
using TPI_PAV.Entidades;
using TPI_PAV.Servicios;

namespace TPI_PAV.InterfacesDeUsuario.Productos
{
    public partial class FrmEditarProducto : Form
    {
        private Producto producto;
        private ProductosServicio productosServicio;
        public FrmEditarProducto(int id)
        {
            productosServicio = new ProductosServicio();
            producto = productosServicio.GetProducto(id);
            InitializeComponent();
        }


        private void CargarDatos()
        {
            TxtNombre.Text = producto.NombreProducto;
            TxtPrecio.Text = producto.Precio.ToString();
            TxtStock.Text = producto.Stock.ToString();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                ValidarProducto();
                ActualizarProducto();

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

        private void ActualizarProducto()
        {
            productosServicio.ActualizarProducto(producto);
            MessageBox.Show("Se actualizó al producto con éxito", "Información");
        }

        private void ValidarProducto()
        {
            producto.NombreProducto = TxtNombre.Text;
            producto.Stock = Convert.ToInt32(TxtStock.Text.Trim());
            producto.Precio = Convert.ToDecimal(TxtPrecio.Text.Trim());
            productosServicio.ValidarProducto(producto);

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
                this.Dispose(); 
        }

        private void FrmEditarProducto_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
