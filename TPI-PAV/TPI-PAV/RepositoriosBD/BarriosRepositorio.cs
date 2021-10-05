using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_PAV.Entidades;

namespace TPI_PAV.RepositoriosBD
{
    public class BarriosRepositorio
    {
        public List<Barrio> GetBarrios()
        {
            var barrios = new List<Barrio>();
            var sentenciaSql = $"SELECT * from barrios";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var barrio = new Barrio();
                barrio.Id = Convert.ToInt32(fila["id_barrio"]);
                barrio.NombreBarrio = fila["nombre"].ToString();
                barrios.Add(barrio);
            }
            return barrios;
        }

    }
}
