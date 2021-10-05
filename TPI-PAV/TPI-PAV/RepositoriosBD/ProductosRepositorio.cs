using System;
using System.Collections.Generic;
using TPI_PAV.Entidades;
using System.Data;

namespace TPI_PAV.RepositoriosBD
{
    public class ProductosRepositorio
    {
        public List<Producto> GetProductos()
        {
            var productos = new List<Producto>();
            var sentenciaSql = $"SELECT * FROM Productos";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var producto = MapearProducto(fila);
                productos.Add(producto);
            }
            return productos;
        }

        public List<Producto> GetProductos(Producto p, bool incluirTodos)
        {
            var productos = new List<Producto>();
            var sentenciaSql = $"SELECT * FROM Productos WHERE nombre like '%{p.NombreProducto}%'";
            if (!incluirTodos)
            {
                sentenciaSql += $" and estado='S'";
            }

            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var producto = MapearProducto(fila);
                productos.Add(producto);
            }
            return productos;
        }

        public int RegistrarProducto(Producto p)
        {
            var sentenciaSQL = $"INSERT INTO Productos (nombre, fecha_alta, precio, stock, estado) VALUES('{p.NombreProducto}', '{p.FechaAlta.ToString("yyyy-MM-dd")}', {p.Precio}, {p.Stock}, 'S')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }


        public int ActualizarProducto(Producto p)
        {
            var sentenciaSql = $"UPDATE Productos SET nombre='{p.NombreProducto}', fecha_alta='{p.FechaAlta.ToString("yyyy-MM-dd")}', precio={p.Precio.ToString().Replace(",",".")}, stock={p.Stock} WHERE id_producto={p.Id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }


        public int DarBajaProducto(Producto p)
        {
            var estado = p.Estado ? "S" : "N";
            var sentenciaSql = $"UPDATE Productos SET estado='{estado}' WHERE id_producto={p.Id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public Producto GetProducto(int id)
        {
            var producto = new Producto();
            var sentenciaSql = $"SELECT * FROM Productos WHERE id_producto={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {

                producto = MapearProducto(fila);


            }
            return producto;
        }

        private Producto MapearProducto(DataRow fila)
        {
            var producto = new Producto();
            producto.Id = Convert.ToInt32(fila["Id_producto"]);
            producto.NombreProducto = fila["nombre"].ToString();
            producto.FechaAlta = Convert.ToDateTime(fila["fecha_alta"]);
            producto.Precio = Convert.ToDecimal(fila["precio"]);
            producto.Stock = Convert.ToInt32(fila["stock"]);

            var estado = fila["estado"].ToString();
            producto.Estado = estado == "S";
            return producto;
        }





    }
}
