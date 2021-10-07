using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_PAV.Entidades;
using TPI_PAV.RepositoriosBD;

namespace TPI_PAV.Servicios
{
    public class RepFacturasServicio
    {
        private RepFacturasRepositorio repFacturasRepositorio;
        //public List<RepFacturas> Obtener(RepFacturas filtros)
        //{
        //    if (filtros.FechaDesde.HasValue)
        //        filtros.FechaDesde = new DateTime(filtros.FechaDesde.Value.Year,
        //                                           filtros.FechaDesde.Value.Month,
        //                                            filtros.FechaDesde.Value.Day);
        //    if (filtros.FechaHasta.HasValue)
        //        filtros.FechaHasta = new DateTime(filtros.FechaHasta.Value.Year,
        //                                            filtros.FechaHasta.Value.Month,
        //                                            filtros.FechaHasta.Value.Day);
        //    if (filtros.FechaDesde.HasValue && filtros.FechaHasta.HasValue &&
        //        filtros.FechaDesde > filtros.FechaHasta)
        //        throw new ApplicationException("La fecha desde no puede ser mayor a la fecha hasta");
        //    return repFacturasRepositorio.Obtener(filtros);
        //}
    }
}
