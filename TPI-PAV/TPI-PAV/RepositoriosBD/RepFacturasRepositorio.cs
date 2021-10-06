using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_PAV.Entidades;

namespace TPI_PAV.RepositoriosBD
{
    public class RepFacturasRepositorio
    {
        public List<RepFacturas> Obtener(RepFacturas filtros)
        {
            List<RepFacturas> facturas = new List<RepFacturas>();
            var sql = $"SELECT fa.*, fa.fecha_alta as fechaDeAlta, cl.nombre as cliente, fa.total as total, " +
                        " FROM FacturasDetalle fd " +
                        "LEFT JOIN Productos pro ON fd.id_producto = pro.id_producto " +
                        "LEFT JOIN Facturas fa ON fa.id_factura = fd.id_factura " +
                        "LEFT JOIN Clientes cl ON fa.id_cliente = cl.id_cliente " +
                        "WHERE fa.id_factura like '%%'";
            if(filtros.FechaDesde.HasValue)
                sql += $" AND fa.fecha_alta > '{filtros.FechaDesde.Value.ToString("yyyy-MM-dd")}'";
            if (filtros.FechaHasta.HasValue)
                sql += $" AND fa.fecha_alta < '{filtros.FechaHasta.Value.ToString("yyyy-MM-dd")}'";
            if(filtros.ClienteId != 0)
                sql += $" AND fa.id_cliente = {filtros.ClienteId}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sql);

            foreach (DataRow fila in tabla.Rows)
            {
                var factura = Mapear(fila);
                facturas.Add(factura);
            }
            return facturas;

        }

        private object Mapear(DataRow fila)
        {
            var rp = new RepFacturas();
            rp.Id = Convert.ToInt32(fila["id_detalleFactura"].ToString());
            if (fila.Table.Columns.Contains("fecha_alta"))
                rp.FechaAlta = Convert.ToDateTime(fila["fecha_alta"].ToString());
            if (!fila.IsNull("id_cliente"))
                rp.ClienteId = new Cliente();
                {
                    Id = Convert.ToInt64(fila["id_cliente"].ToString());
                    NombreCliente = fila["nombreCliente"].ToString();
                };
            rp.Total = Convert.ToDecimal(fila["total"].ToString());

            return rp;
        }
    }

    
}
