using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_PAV.Entidades;

namespace TPI_PAV.RepositoriosBD
{
    public class FacturasRepositorio
    {
        public int ObtenerSiguienteNumeroFactura()
        {
            var sentenciaSql = $"select max(numero_factura) as ultimoNumero from facturas";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            var ultimoNumero = (int)tablaResultado.Rows[0]["ultimoNumero"];

            return ultimoNumero + 1;


        }

        public void GenerarFactura(Factura fa,  List<DetalleFactura> ld)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var sql = $"INSERT INTO Facturas (id_cliente, fecha_alta, id_usuario_creador, total, estado, numero_factura) " +
                        $"VALUES({fa.Cliente.Id}, '{fa.FechaAlta.ToString("yyyy-MM-dd")}',{fa.Usuario.Id}, {fa.Total.ToString().Replace(",", ".")},'S',{fa.NumeroFactura})";

                    //capturamos el id de la factura porque el detalle factura lo necesita en la tabla

                    fa.Id = DBHelper.GetDBHelper().EjecutarTransaccionSQL(sql);

                    foreach (DetalleFactura df in ld)
                    {
                        var sqlDetalleFa = $"INSERT INTO FacturasDetalle (id_factura, id_producto, cantidad, estado, precio) " +
                       $"VALUES ({fa.Id}, {df.producto.Id},{df.Cantidad},'S',{df.Precio.ToString().Replace(",", ".")})";
                        DBHelper.GetDBHelper().EjecutarTransaccionSQL(sqlDetalleFa);
                    }
                   


                    tx.Commit(); // con esto le indico que realmente se registro la tabla
                }
                catch (Exception ex )
                {
                    tx.Rollback(); // los datos tienen que volver a su estado inicial de haber empezado la transaccion 
                    throw new ApplicationException("No se pudo registrar la factura.");
                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }

            ////Inserto Encabezado Factura
            //var sentenciaSql = $"Insert into Factura blalala{fa.Cliente.Id}";
            //var resultado = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);

            ////Obtener el ultimo id de factura
            // sentenciaSql = $"select max(Id_Factira) as ultimoId from facturas";
            // var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            // var ultimoNumero = (int)tablaResultado.Rows[0]["ultimoId"];

            ////Inserto Detalle
            //foreach (var detalleFactura in listaDetalle)
            //{
            //    var sentenciaSql = $"Insert into FacturaDetalle blalala{fa.Cliente.Id}";
            //    var tablaResultado = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            //}


        }
    }
}
