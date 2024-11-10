using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_PAV.Entidades;

namespace TPI_PAV.RepositoriosBD
{
    public class RepFacturasRepositorio
    {
        public DataTable ObtenerFacturas(DateTime? fechaDesde, DateTime? fechaHasta)
        {
            var sentenciaSql = "SELECT fa.fecha_alta as fechaDeAlta, cl.nombre as cliente, fa.total as total" +
                                " FROM FacturasDetalle fd" +
                                " LEFT JOIN Productos pro ON fd.id_producto = pro.id_producto" +
                                " LEFT JOIN Facturas fa ON fa.id_factura = fd.id_factura" +
                                " LEFT JOIN Clientes cl ON fa.id_cliente = cl.id_cliente" +
                                " WHERE fd.id_detalle_factura like '%%'";
            if (fechaDesde.HasValue)
                 sentenciaSql += $" AND fa.fecha_alta > '{fechaDesde.Value.ToString("yyyy-MM-dd")}'";
            if (fechaHasta.HasValue)
                 sentenciaSql += $" AND fa.fecha_alta <= '{fechaHasta.Value.ToString("yyyy-MM-dd")}'";
         

            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            return tabla;
        }

    }
}
