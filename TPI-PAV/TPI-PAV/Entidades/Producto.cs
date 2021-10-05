using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_PAV.Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public DateTime FechaAlta { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public bool Estado { get; set; }


        public string EstadoFormateado
        {
            get
            {
                var result = "Activo";
                if (Estado != true)
                    result = "Inacivo";

                return result;
            }
        }

        public void ValidarNombre()
        {
            if (string.IsNullOrEmpty(NombreProducto))
                throw new ApplicationException("El nombre de producto es requerido.");
            if (NombreProducto.Length > 50)
                throw new ApplicationException("El nombre de producto no debe superar los 50 caracteres.");
            
        }



    }
}
