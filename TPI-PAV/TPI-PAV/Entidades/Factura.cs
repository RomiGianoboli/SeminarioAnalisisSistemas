using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_PAV.Entidades
{
    public class Factura
    {
        public int Id { get; set; }
        public int Sucursal { get; set; }
        public int NumeroFactura { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaAlta { get; set; }
        public Usuario Usuario { get; set; }
        public decimal Total { get; set; }
        public bool Estado { get; set; }
    
        public string NombreCliente
        {
            get
            {
                return Cliente.NombreCliente;
            }
        }

    }

 
}
