using System;
using System.Collections.Generic;
using System.Data;
using TPI_PAV.Entidades;

namespace TPI_PAV.RepositoriosBD
{
    public class PerfilesRepositorio
    {
        public List<Perfil> GetPerfiles()
        {
            var perfiles = new List<Perfil>();
            var sentenciaSql = $"SELECT * from perfiles";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var perfil = new Perfil();
                perfil.Id = Convert.ToInt32(fila["id_perfil"]);
                perfil.Nombre = fila["nombre"].ToString();
                perfiles.Add(perfil);
            }
            return perfiles;
        }
    }
}
