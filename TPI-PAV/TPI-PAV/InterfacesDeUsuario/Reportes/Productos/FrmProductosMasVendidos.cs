using Microsoft.Reporting.WinForms;
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
using TPI_PAV.RepositoriosBD;
using TPI_PAV.Servicios;

namespace TPI_PAV.InterfacesDeUsuario.Reportes
{
    public partial class FrmProductosMasVendidos : Form
    {
        private readonly RepProductosRepositorio repProductosRepositorio;
        public FrmProductosMasVendidos()
        {
            repProductosRepositorio = new RepProductosRepositorio();
            InitializeComponent();
        }


        public void CargarProductos()
        {
            var datos = repProductosRepositorio.GetProductosMasVendidos(DtpFechaDesde.Value, DtpFechaHasta.Value);

            this.RwProducto.LocalReport.DataSources.Clear();

            var ds = new ReportDataSource("DSProducto", datos);

            this.RwProducto.LocalReport.DataSources.Add(ds);

            var fechaHoy = DateTime.Now.ToString("dd/MM/yyyy");
            var paramHoy = new ReportParameter("ParamFechaHoy", fechaHoy);


            var parametros = new List<ReportParameter>();
            parametros.Add(paramHoy);

            this.RwProducto.LocalReport.SetParameters(parametros);

            this.RwProducto.RefreshReport();


        }

       
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
           
            CargarProductos();

          
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
