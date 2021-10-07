using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_PAV.Entidades;
using TPI_PAV.RepositoriosBD;

namespace TPI_PAV.Servicios
{
    public class RepProductosServicio
    {
        private RepProductosRepositorio repProductosRepositrios;

        public RepProductosServicio()
        {
            repProductosRepositrios = new RepProductosRepositorio();
        }

        public List<RepProductos> GetProductosMasVendidos(DateTime fechaDese, DateTime fechaHasta)
        {

            return repProductosRepositrios.GetProductosMasVendidos(fechaDese, fechaHasta);
        }
    }
}
