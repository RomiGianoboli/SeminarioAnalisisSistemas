using System;
using System.Windows.Forms;
using TPI_PAV.Entidades;
using TPI_PAV.Servicios;

namespace TPI_PAV.InterfacesDeUsuario.Productos
{
    public partial class FrmRegistrarProducto : Form
    {
        private Producto producto;
        private ProductosServicio productoServicio;
    
        public FrmRegistrarProducto()
        {
            productoServicio = new ProductosServicio();
            InitializeComponent();
        }

        private void FrmRegistrarProducto_Load(object sender, EventArgs e)
        {
           
        }

        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("Desea confirmar la operación", "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }
        
        private bool EsProductoValido()
        {
            var nombre = TxtNombre.Text.Trim();
            var precio = Convert.ToInt64(TxtPrecio.Text.Trim());
            var stock = Convert.ToInt32(TxtStock.Text.Trim());
            var fechaAlta = Convert.ToDateTime(DtpFechaAlta.Text.Trim());

            var productoIngresado = new Producto();
            productoIngresado.NombreProducto = nombre;
            productoIngresado.Precio = precio;
            productoIngresado.Stock = stock;
            productoIngresado.FechaAlta = fechaAlta;
            productoServicio.ValidarProducto(productoIngresado);
            producto = productoIngresado;
            return true;

        }
      
        private void RegistrarProducto()
        {
            if (!productoServicio.RegistrarProducto(producto))
            {
                MessageBox.Show("Ocurrió un problema al registrar el producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("El producto se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
        
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("¿Desea salir?", "Informacion", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                if (!EsProductoValido())
                    return;
                RegistrarProducto();
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
    }
}
