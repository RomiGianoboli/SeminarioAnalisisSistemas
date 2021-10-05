using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_PAV.Entidades
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public Factura Factura { get; set; }
        public int NumeroOrden { get; set; }
        public Producto producto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public bool Estado { get; set; }
        public string NombreProducto
        {
            get
            {
                return producto.NombreProducto;
            }
        }
        public decimal Total 
        { 
            get
            {
                return Precio * Cantidad;
            } 
        }
    }
}
