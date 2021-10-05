using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_PAV.Entidades;
using TPI_PAV.RepositoriosBD;

namespace TPI_PAV.Servicios
{
    public class ProductosServicio
    {
        private ProductosRepositorio productosRepositorio;

        public ProductosServicio()
        {
            productosRepositorio = new ProductosRepositorio();
        }

        public List<Producto> GetProductos()
        {
            return productosRepositorio.GetProductos();
        }

        public List<Producto> GetProductos(Producto p, bool incluitTodos)
        {
            return productosRepositorio.GetProductos(p, incluitTodos);
        }

        public void ValidarProducto(Producto producto)
        {
            producto.ValidarNombre();
        }

        public bool RegistrarProducto(Producto producto)
        {
            if (producto == null)
                throw new ApplicationException("Producto Requerido");
            var filasAfectadas = productosRepositorio.RegistrarProducto(producto);
            if (filasAfectadas == 1)
                return true;
            return false;
        }

        public Producto GetProducto(int id)
        {
            var producto = productosRepositorio.GetProducto(id);
            return producto;
        }

        public void ActualizarProducto(Producto p)
        {
            var filasAfectadas = productosRepositorio.ActualizarProducto(p);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }

        public void DarBajaProducto(Producto p)
        {
            var filasAfectadas = productosRepositorio.DarBajaProducto(p);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }
    }
}
