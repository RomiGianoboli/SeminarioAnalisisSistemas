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
    public partial class FrmProductos : Form
    {
        private ProductosServicio productosServicio;
        public FrmProductos()
        {
            productosServicio = new ProductosServicio();
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            ConsultarProductos();

        }
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarProductos();
        }

        private void ConsultarProductos()
        {
            var productoFiltros = new Producto();
            productoFiltros.NombreProducto = TxtNombre.Text.Trim();
            var incluitTodos = CkIncluirInactivos.Checked; 

            var productos = productosServicio.GetProductos(productoFiltros, incluitTodos);
            //DgvProductos.Rows.Clear();
            DgvProductos.DataSource = productos;

            //foreach (var producto in productos)
            //{
            //    var descripcionEstado = producto.Estado ? "Activo" : "Inactivo";
            //    var fila = new string[]
            //    {

            //        producto.Id.ToString(),
            //        producto.NombreProducto,
            //        producto.Precio.ToString(),
            //        producto.Stock.ToString(),
            //        producto.FechaAlta.ToLongDateString(),
            //        descripcionEstado
            //    };
            //    DgvProductos.Rows.Add(fila);
            //}

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("¿Desea salir?", "Informacion", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            new FrmRegistrarProducto().Show();
            ConsultarProductos();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvProductos.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(DgvProductos.SelectedRows[0].Cells["Id"].Value);
                new FrmEditarProducto(id).ShowDialog();
                ConsultarProductos();
                return;
            }
            if (DgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro.", "Informacion", MessageBoxButtons.OK);
                return;
            }
            if (DgvProductos.SelectedRows.Count > 1)
            {
                MessageBox.Show("Debe seleccionar solo un registro, no muchos.", "Informacion", MessageBoxButtons.OK);
            }
        }

        private void BtnDarBaja_Click(object sender, EventArgs e)
        {
            if (DgvProductos.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(DgvProductos.SelectedRows[0].Cells["Id"].Value);
                new FrmBajaProducto(id).ShowDialog();
                ConsultarProductos();
                return;
            }
            if (DgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro.", "Informacion", MessageBoxButtons.OK);
                return;
            }
            if (DgvProductos.SelectedRows.Count > 1)
            {
                MessageBox.Show("Debe seleccionar solo un registro, no muchos.", "Informacion", MessageBoxButtons.OK);
            }
        }
    }
}
