using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_PAV.Entidades;
using TPI_PAV.RepositoriosBD;

namespace TPI_PAV.Servicios
{
    
    public class FacturasServicio
    {
        public FacturasRepositorio facturasRepositorio;
        public FacturasServicio()
        {
            facturasRepositorio = new FacturasRepositorio();
        }
        public int ObtenerSiguienteNumeroFactura()
        {
            return facturasRepositorio.ObtenerSiguienteNumeroFactura();
        }

        internal void GenerarFactura(Factura fa, DetalleFactura ld)
        {
            facturasRepositorio.GenerarFactura(fa, ld);
        }
    }
}
