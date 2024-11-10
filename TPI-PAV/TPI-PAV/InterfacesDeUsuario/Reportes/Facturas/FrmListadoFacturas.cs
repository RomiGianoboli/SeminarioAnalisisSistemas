using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TPI_PAV.Entidades;
using TPI_PAV.RepositoriosBD;
using TPI_PAV.Servicios;
using TPI_PAV.Utils;

namespace TPI_PAV.InterfacesDeUsuario.Reportes
{
    public partial class FrmListadoFacturas : Form
    {
        private readonly ClientesServicio clientesServicio;
        private readonly RepFacturasRepositorio repFacturasRepositorio;

        public List<Factura> listaFactura;
        public List<DetalleFactura> detalleFactura;


        public FrmListadoFacturas(Factura lsFa, List<DetalleFactura> lsDf)
        {
            repFacturasRepositorio = new RepFacturasRepositorio();
            clientesServicio = new ClientesServicio();
            listaFactura = new List<Factura>(); 
            listaFactura.Add(lsFa);
            detalleFactura = lsDf;
           
            InitializeComponent();

        }

        private void FrmListadoFacturas_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }


        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            

        }

        private void CargarReporte()
        {
           
            this.RwFactura.LocalReport.DataSources.Clear();

            var ds = new ReportDataSource("DSFactura", listaFactura);

            var ds2 = new ReportDataSource("DSDetalle", detalleFactura);



            this.RwFactura.LocalReport.DataSources.Add(ds);
            this.RwFactura.LocalReport.DataSources.Add(ds2);


            this.RwFactura.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
