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

        public List<RepProductos> GetProductosMasVendidos(DateTime fechaDese, DateTime fechaHasta)
        {
            List<RepProductos> df = new List<RepProductos>();

            var sql = $" SELECT pro.nombre as producto ,fd.cantidad as cantidad, fa.total as total" +
                        " FROM FacturasDetalle fd" +
                        " INNER JOIN Productos pro ON  pro.id_producto = fd.id_producto" +
                        " INNER JOIN Facturas fa ON fa.id_factura = fd.id_factura" +
                        $" WHERE fa.fecha_alta between {fechaDese.ToString("yyyy-MM-dd")} and {fechaHasta.ToString("yyyy-MM-dd")}" +
                        " group by pro.nombre, fd.cantidad, fa.total" +
                        " order by fd.cantidad desc";
       
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sql);

            foreach (DataRow fila in tabla.Rows)
            {
                var detalle = Mapear(fila);
                df.Add(detalle);
            }
            return df;

        }

        private RepProductos Mapear(DataRow fila)
        {
            var repor = new RepProductos();

            repor.NombreProducto = fila["producto"].ToString();
            repor.Cantidad = Convert.ToInt32(fila["cantidad"]);
            repor.Total = Convert.ToDecimal(fila["total"]);
           
            return repor;

        }
    }
}
