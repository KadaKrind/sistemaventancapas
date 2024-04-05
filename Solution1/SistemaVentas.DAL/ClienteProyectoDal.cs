using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SistemaVentas.MODELOS;
namespace SistemaVentas.DAL
{
    public class ClienteProyectoDal
    {
        public DataTable ListarClienteProyectoDal()
        {
            string consulta = "select * from Cliente";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void AgregarClienteProyectoDal(ClienteProyecto c)
        {
            string consulta = "INSERT INTO Cliente VALUES (" + c.IdPersona + ", '" + c.TipoCliente + "', '" + c.CodigoCliente + "', '" + c.Estado + "')";
            conexion.Ejecutar(consulta);        
        }
        public ClienteProyecto ObtenerClienteProyectoDal(int idCliente)
        {
            string consulta = "SELECT * FROM Cliente WHERE IDCliente = " + idCliente;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "Clientes");
            ClienteProyecto cliente = new ClienteProyecto();

            if (tabla.Rows.Count > 0)
            {
                cliente.IdCliente = Convert.ToInt32(tabla.Rows[0]["IDCliente"]);
                cliente.IdPersona = Convert.ToInt32(tabla.Rows[0]["IDPersona"]);
                cliente.TipoCliente = tabla.Rows[0]["TipoCliente"].ToString();
                cliente.CodigoCliente = tabla.Rows[0]["CodigoCliente"].ToString();
                cliente.Estado = tabla.Rows[0]["Estado"].ToString();
            }
            return cliente;
        }
        public void EditarClienteProyectoDal(ClienteProyecto cliente)
        {
            string consulta = "UPDATE Cliente SET IDPersona = " + cliente.IdPersona + ", TipoCliente = '" + cliente.TipoCliente + "', CodigoCliente = '" + cliente.CodigoCliente + "', Estado = '" + cliente.Estado + "' WHERE IDCliente = " + cliente.IdCliente;
            conexion.Ejecutar(consulta);
        }
        public int ObtenerUltimoIdCliente()
        {
            string consulta = "SELECT MAX(IDCliente) FROM Cliente";
            int ultimoId = Convert.ToInt32(conexion.EjecutarEscalarComoString(consulta));
            return ultimoId + 1;
        }

        public int ObtenerUltimoIdPersona()
        {
            string consulta = "SELECT MAX(IDPersona) FROM Cliente";
            int ultimoId = Convert.ToInt32(conexion.EjecutarEscalarComoString(consulta));
            return ultimoId + 1;
        }
        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from Cliente where IDCliente=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
