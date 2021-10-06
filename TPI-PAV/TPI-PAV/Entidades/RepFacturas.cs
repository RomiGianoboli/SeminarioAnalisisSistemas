using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_PAV.Entidades
{
    public class RepFacturas
    {
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public int ClienteId { get; set; }
        public int Id { get; set; }
        public DateTime FechaAlta { get; set; }
        public decimal Total { get; set; }


       
    }
}
