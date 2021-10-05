using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_PAV.Entidades;
using TPI_PAV.RepositoriosBD;

namespace TPI_PAV.Servicios
{
    public class UsuariosServicio
    {
        private UsuariosRepositorio usuariosRepositorio;
        public static Usuario UsuarioLogueado;

        public UsuariosServicio(UsuariosRepositorio usuariosRepo)
        {
            usuariosRepositorio = usuariosRepo;
        }

        public UsuariosServicio()
        {
            usuariosRepositorio = new UsuariosRepositorio();
        }

        public Usuario Login(Usuario usuarioIngresado)
        {
            var usuario = usuariosRepositorio.LoginBD(usuarioIngresado);
            UsuarioLogueado = usuario;
            return usuario;
        }

        public List<Usuario> GetUsuarios()
        {
            return usuariosRepositorio.GetUsuarios();
        }

        public List<Usuario> GetUsuarios(Usuario u, bool incluirTodos)
        {
            return usuariosRepositorio.GetUsuarios(u, incluirTodos);
        }

        public void ValidarUsuario(Usuario usuario)
        {
            usuario.ValidarNombre();
            usuario.ValidarPassword();
            usuario.ValidarEmail();
        }

        public bool RegistrarUsuario(Usuario usuario)
        {
            if (usuario == null)
                throw new ApplicationException("Usuario Requerido");
            var filasAfectadas = usuariosRepositorio.RegistrarUsuario(usuario);
            if (filasAfectadas == 1)
                return true;
            return false;
        }

        public Usuario GetUsuario(long id)
        {
            var usuario = usuariosRepositorio.GetUsuario(id);
            return usuario;
        }

        public void ActualizarUsuario(Usuario u)
        {
            var filasAfectadas = usuariosRepositorio.ActualizarUsuario(u);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }

        public void DarBajaUsuario(Usuario u)
        {
            var filasAfectadas = usuariosRepositorio.DarBajaUsuario(u);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }
        


    }
}
