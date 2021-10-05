using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_PAV.Entidades;
using TPI_PAV.RepositoriosBD;

namespace TPI_PAV.Servicios
{
    public class BarriosServicio
    {
        private BarriosRepositorio barriosRepositorio;

        public BarriosServicio()
        {
            barriosRepositorio = new BarriosRepositorio();
        }

        public List<Barrio> GetBarrios()
        {
            return barriosRepositorio.GetBarrios();
        }

    }
}
