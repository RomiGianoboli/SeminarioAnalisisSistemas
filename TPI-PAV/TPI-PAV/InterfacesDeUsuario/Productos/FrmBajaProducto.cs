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

namespace TPI_PAV.InterfacesDeUsuario.Productos
{
    public partial class FrmBajaProducto : Form
    {
        private Producto producto;
        private ProductosServicio productoServicio;
        public FrmBajaProducto(long id)
        {
            productoServicio = new ProductosServicio();
            InitializeComponent();
        }

        private void FrmBajaProducto_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void DarBajaProducto()
        {
            productoServicio.DarBajaProducto(producto);
            MessageBox.Show("La operación se realizó con éxito", "Información");
        }

        private void CargarDatos()
        {
            TxtNombre.Text = producto.NombreProducto;
            if (producto.Estado)
                RbActivo.Checked = true;
            else
                RbInactivo.Checked = true;
        }

        private void SetBajaProducto()
        {
            if (RbActivo.Checked)
                producto.Estado = true;
            if (RbInactivo.Checked)
                producto.Estado = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                SetBajaProducto();
                DarBajaProducto();

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
            var dialog = MessageBox.Show("¿Desea salir?", "Informacion", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                this.Dispose();
            }
        }
    }
}
