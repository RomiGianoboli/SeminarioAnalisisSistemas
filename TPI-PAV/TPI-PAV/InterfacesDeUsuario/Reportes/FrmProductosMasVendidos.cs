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

namespace TPI_PAV.InterfacesDeUsuario.Reportes
{
    public partial class FrmProductosMasVendidos : Form
    {
        private RepProductosServicio repProductosServicio;
        public FrmProductosMasVendidos()
        {
            repProductosServicio = new RepProductosServicio();
            InitializeComponent();
        }


        public void ConsultarProductos()
        {
            var rep = new RepProductos();

            var fechaDesde = DtpFechaDesde.Value;
            var fechaHasta = DtpFechaHasta.Value;
            var incluirTodos = CkIncluirTodos.Checked;

            var productos = repProductosServicio.GetProductosMasVendidos( fechaDesde, fechaHasta);
            DgvDetalle.DataSource = productos;

            //if(incluirTodos)
            //{
            //    fechaDesde = null;
            //    fechaHasta = null;
            //}    

            //foreach (var p in productos)
            //{
               
            //    var fila = new string[]
            //    {
            //        p.NombreProducto.ToString(),
            //        p.Cantidad.ToString(),
            //        p.Total.ToString()
            //    };

            //    DgvDetalle.Rows.Add(fila);
            //}

        }

       
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultarProductos();   
            }
            catch (ApplicationException aex)
            {
                var mensaje = aex.Message;
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmProductosMasVendidos_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
