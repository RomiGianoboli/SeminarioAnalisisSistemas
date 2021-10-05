using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_PAV.Entidades;

namespace TPI_PAV.RepositoriosBD
{
    public class UsuariosRepositorio
    {
        public Usuario LoginBD(Usuario usuarioIngresado)
        {
            Usuario usuarioResultado = null;
            var sentenciaSql = $"SELECT * FROM Usuarios where usuario='{usuarioIngresado.NombreUsuario}'and password='{usuarioIngresado.Contrasenia}'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tablaResultado.Rows.Count == 1)
            {
                var row = tablaResultado.Rows[0];
                usuarioResultado = new Usuario();
                usuarioResultado.NombreUsuario = row["usuario"].ToString();
                usuarioResultado.Id = Convert.ToInt32(row["id_usuario"]);
                var perfil = new Perfil();
                perfil.Id = Convert.ToInt32(row["id_perfil"]);
                usuarioResultado.Perfil = perfil;
            }
            return usuarioResultado;
        }

        public List<Usuario> GetUsuarios()
        {
            var usuarios = new List<Usuario>();
            var sentenciaSql = $"SELECT * from usuarios";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var usuario = MapearUsuario(fila);
                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public List<Usuario> GetUsuarios(Usuario u, bool incluirTodos)
        {
            var usuarios = new List<Usuario>();
            var sentenciaSql = $"SELECT u.*, p.nombre as perfil FROM Usuarios u LEFT JOIN Perfiles p ON u.id_perfil = p.id_perfil WHERE usuario like '%{u.NombreUsuario}%'";
            if (u.Perfil != null && u.Perfil.Id != 0)
            {
                sentenciaSql += $" and u.id_perfil={u.Perfil.Id}";
            }
            if (!incluirTodos)
            {
                sentenciaSql += $" and u.estado='S'";
            }
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var usuario = MapearUsuario(fila);
                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public int RegistrarUsuario(Usuario u)
        {
            var sentenciaSQL = $"INSERT INTO Usuarios (id_perfil, usuario, password, email, estado) VALUES({u.Perfil.Id}, '{u.NombreUsuario}', '{u.Contrasenia}', '{u.Email}', 'S')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }

        public int ActualizarUsuario(Usuario u)
        {
            var sentenciaSql = $"UPDATE Usuarios SET id_perfil='{u.Perfil.Id}', password='{u.Contrasenia}', email='{u.Email}' WHERE id_usuario={u.Id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public int DarBajaUsuario(Usuario u)
        {
            var estado = u.Estado ? "S" : "N";
            var sentenciaSql = $"UPDATE Usuarios SET estado='{estado}' WHERE id_usuario={u.Id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public Usuario GetUsuario(long id)
        {
            var usuario = new Usuario();
            var sentenciaSql = $"SELECT u.*, p.nombre as perfil FROM Usuarios u LEFT JOIN Perfiles p ON u.id_perfil = p.id_perfil WHERE u.id_usuario={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {

                usuario = MapearUsuario(fila);


            }
            return usuario;
        }
        private Usuario MapearUsuario(DataRow fila)
        {
            var usuario = new Usuario();
            usuario.Id = Convert.ToInt32(fila["id_usuario"]);
            usuario.NombreUsuario = fila["usuario"].ToString();
            usuario.Email = fila["email"].ToString();

            var perfil = new Perfil();
            perfil.Id = Convert.ToInt32(fila["id_perfil"]);
            if (!fila.IsNull("perfil"))
            {
                perfil.Nombre = fila["perfil"].ToString();
            }
            usuario.Perfil = perfil;

            // S o N en true o false
            var estado = fila["estado"].ToString();
            usuario.Estado = estado == "S";
            return usuario;
        }
    }
}
