using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_PAV.Entidades;

namespace TPI_PAV.RepositoriosBD
{
    public class RepProductosRepositorio
    {

        public DataTable GetProductosMasVendidos(DateTime fechaDesde, DateTime fechaHasta)
        { 

            var sql = $" SELECT pro.nombre as producto, SUM(fd.cantidad) as cantidad, SUM(fa.total) as total" +
                        " FROM FacturasDetalle fd" +
                        " INNER JOIN Productos pro ON  pro.id_producto = fd.id_producto" +
                        " INNER JOIN Facturas fa ON fa.id_factura = fd.id_factura" +
                        $" WHERE fa.fecha_alta between '{fechaDesde.ToString("yyyy-MM-dd")}' and '{fechaHasta.ToString("yyyy-MM-dd")}'" +
                        " group by nombre" +
                        " order by cantidad desc";

       
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sql);

            return tabla;

        }

    }
}
