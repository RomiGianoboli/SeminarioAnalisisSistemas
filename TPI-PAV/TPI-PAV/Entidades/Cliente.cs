using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_PAV.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public string Calle { get; set; }
        public int NumeroCalle { get; set; }
        public DateTime FechaAlta {get;set; }
        public Barrio Barrio { get; set; }
        public string Email { get; set; }
        public bool Estado { get; set; }

        //falta validar los demas atributos

        
        public void ValidarNombre()
        {
            if (string.IsNullOrEmpty(NombreCliente))
                throw new ApplicationException("El nombre de cliente es requerido.");
            if (NombreCliente.Length > 50)
                throw new ApplicationException("El nombre de cliente no debe superar los 50 caracteres.");
        }

        public void ValidarCalle()
        {
            if (string.IsNullOrEmpty(this.Calle))
                throw new ApplicationException("La calle es requerida");
            if (this.Calle.Length > 50)
                throw new ApplicationException("Calle inválida. La calle no debe superar los 10 caracteres");
        }

        public void ValidarEmail()
        {
            if (!string.IsNullOrEmpty(this.Email) && this.Email.Length > 50)
                throw new ApplicationException("Email inválido. El email no debe superar los 50 caracteres");
        }

        public void ValidarFecha()
        {
            if (FechaAlta == DateTime.MinValue)
                throw new ApplicationException("la fecha de alta es requerida");
            FechaAlta = new DateTime(FechaAlta.Year, FechaAlta.Month, FechaAlta.Day);
            if (FechaAlta > DateTime.Today)
                throw new ApplicationException("la fecha de alta debe ser menor o igual que la fecha actual");
        }

        public void ValidarBarrio()
        {
            if (Barrio != null && Barrio.Id == 0)
                throw new ApplicationException("Barrio Inválido");
        }


    }







}
