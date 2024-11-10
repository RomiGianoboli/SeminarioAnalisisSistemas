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

        //public List<RepProductos> GetProductosMasVendidos(RepProductos rep)
        //{
        //    if (rep.fechaDesde.HasValue)
        //        rep.fechaDesde = new DateTime(rep.fechaDesde.Value.Year,
        //                                           rep.fechaDesde.Value.Month,
        //                                            rep.fechaDesde.Value.Day);
        //    if (rep.fechaHasta.HasValue)
        //        rep.fechaHasta = new DateTime(rep.fechaHasta.Value.Year,
        //                                            rep.fechaHasta.Value.Month,
        //                                            rep.fechaHasta.Value.Day);
        //    if (rep.fechaDesde.HasValue && rep.fechaHasta.HasValue &&
        //        rep.fechaDesde > rep.fechaHasta)
        //        throw new ApplicationException("La fecha desde no puede ser mayor a la fecha hasta");

        //    return repProductosRepositrios.GetProductosMasVendidos(rep);
        //}
    }
}
