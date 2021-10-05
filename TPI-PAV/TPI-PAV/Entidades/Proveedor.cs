using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_PAV.Entidades
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public int CUIT { get; set; }
        public string Email { get; set; }
        public DateTime FechaDeAlta { get; set; }
        public Barrio Barrio { get; set; }
        public bool Estado { get; set; }
    }
}
