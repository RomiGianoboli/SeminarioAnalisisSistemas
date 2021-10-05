using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_PAV.Entidades;
using TPI_PAV.RepositoriosBD;

namespace TPI_PAV.Servicios
{
    public class PerfilesServicio
    {
        private PerfilesRepositorio perfilesRepositorio;

        public PerfilesServicio()
        {
            perfilesRepositorio = new PerfilesRepositorio();
        }

        public List<Perfil> GetPerfiles()
        {
            return perfilesRepositorio.GetPerfiles();
        }
    }
}
