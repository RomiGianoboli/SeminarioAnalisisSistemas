using System;
using System.Collections.Generic;
using System.Data;
using TPI_PAV.Entidades;

namespace TPI_PAV.RepositoriosBD
{
    public class ClientesRepositorio
    {
        public List<Cliente> GetClientes()
        {
            var clientes = new List<Cliente>();
            var sentenciaSql = $"SELECT * from clientes";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var cliente = MapearClienteSinBarrio(fila);
                clientes.Add(cliente);
            }
            return clientes;
        }

        public List<Cliente> GetClientes(Cliente c, bool incluirTodos)
        {
            var clientes = new List<Cliente>();
            var sentenciaSql = $"SELECT c.*, b.nombre as barrio FROM Clientes c LEFT JOIN Barrios b ON c.id_barrio = b.id_barrio WHERE c.nombre like '%{c.NombreCliente}%'";
            if (c.Barrio != null && c.Barrio.Id != 0)
            {
                sentenciaSql += $" and c.id_barrio={c.Barrio.Id}";
            }
            if (!incluirTodos)
            {
                sentenciaSql += $" and c.estado='S'";
            }
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var cliente = MapearCliente(fila);
                clientes.Add(cliente);
            }
            return clientes;
        }

        public Cliente GetCliente(long id)
        {
            var cliente = new Cliente();
            var sentenciaSql = $"SELECT c.*, b.nombre as barrio FROM Clientes c LEFT JOIN Barrios b ON c.id_barrio = b.id_barrio WHERE c.id_cliente={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {

                cliente = MapearCliente(fila);


            }
            return cliente;
        }
        private Cliente MapearCliente(DataRow fila)
        {
            var cliente = new Cliente();
            cliente.Id = Convert.ToInt32(fila["id_cliente"]);
            cliente.NombreCliente = fila["nombre"].ToString();
            cliente.Email = fila["email"].ToString();
            cliente.Calle = fila["calle"].ToString();
            cliente.NumeroCalle = Convert.ToInt32(fila["numero"]);
            cliente.FechaAlta = Convert.ToDateTime(fila["fecha_alta"]);

            var barrio = new Barrio();
            barrio.Id = Convert.ToInt32(fila["id_barrio"]);
            if (!fila.IsNull("barrio"))
            {
                barrio.NombreBarrio = fila["barrio"].ToString();
            }
            cliente.Barrio = barrio;

            // S o N en true o false
            var estado = fila["estado"].ToString();
            cliente.Estado = estado == "S";
            return cliente;
        }
        private Cliente MapearClienteSinBarrio(DataRow fila)
        {
            var cliente = new Cliente();
            cliente.Id = Convert.ToInt32(fila["id_cliente"]);
            cliente.NombreCliente = fila["nombre"].ToString();
            cliente.Email = fila["email"].ToString();
            cliente.Calle = fila["calle"].ToString();
            cliente.NumeroCalle = Convert.ToInt32(fila["numero"]);
            cliente.FechaAlta = Convert.ToDateTime(fila["fecha_alta"]);

            // S o N en true o false
            var estado = fila["estado"].ToString();
            cliente.Estado = estado == "S";
            return cliente;
        }

        public int RegistrarCliente(Cliente c)
        {
            var sentenciaSQL = $"INSERT INTO Clientes (calle, numero, fecha_alta,id_barrio,nombre,estado,email) VALUES('{c.Calle}', {c.NumeroCalle}, '{c.FechaAlta.ToString("yyyy-MM-dd")}', {c.Barrio.Id},'{c.NombreCliente}','S','{c.Email}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }

        public int ActualizarCliente(Cliente c)
        {
            var sentenciaSql = $"UPDATE Clientes SET id_barrio={c.Barrio.Id}, calle='{c.Calle}', numero={c.NumeroCalle}, email='{c.Email}' WHERE id_cliente={c.Id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public int DarBajaCliente(Cliente c)
        {
            var estado = c.Estado ? "S" : "N";
            var sentenciaSql = $"UPDATE Clientes SET estado='{estado}' WHERE id_cliente={c.Id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
    }
}
