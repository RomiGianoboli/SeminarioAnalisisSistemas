using System;
using System.Collections.Generic;
using TPI_PAV.Entidades;
using TPI_PAV.RepositoriosBD;

namespace TPI_PAV.Servicios
{
    public class ClientesServicio
    {
        private ClientesRepositorio clientesRepositorio;
        public static Cliente ClienteLogueado;

        public ClientesServicio()
        {
            clientesRepositorio = new ClientesRepositorio();
        }

        public List<Cliente> GetClientes()
        {
            return clientesRepositorio.GetClientes();
        }

        public List<Cliente> GetClientes(Cliente c, bool incluirTodos)
        {
            return clientesRepositorio.GetClientes(c, incluirTodos);
        }

        public bool RegistrarCliente(Cliente cliente)
        {
            if (cliente == null)
                throw new ApplicationException("Cliente Requerido");
            var filasAfectadas = clientesRepositorio.RegistrarCliente(cliente);
            if (filasAfectadas == 1)
                return true;
            return false;
        }

        public Cliente GetCliente(long id)
        {
            var usuario = clientesRepositorio.GetCliente(id);
            return usuario;
        }

        public void ValidarCliente(Cliente cliente)
        {
            cliente.ValidarNombre();
            cliente.ValidarCalle();
            cliente.ValidarEmail();
            cliente.ValidarBarrio();
            cliente.ValidarFecha();

        }

        public void ActualizarCliente(Cliente c)
        {
            var filasAfectadas = clientesRepositorio.ActualizarCliente(c);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }

        public void DarBajaCliente(Cliente c)
        {
            var filasAfectadas = clientesRepositorio.DarBajaCliente(c);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }

    }
}
