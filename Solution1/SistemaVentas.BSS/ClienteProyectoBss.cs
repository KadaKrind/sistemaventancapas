using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SistemaVentas.DAL;
using SistemaVentas.MODELOS;
namespace SistemaVentas.BSS
{
    public class ClienteProyectoBss
    {
        ClienteProyectoDal cdal = new ClienteProyectoDal();
        public DataTable ListarClienteProyectoBss()
        {
            return cdal.ListarClienteProyectoDal();
        }
        public void AgregarClienteProyectoBss(ClienteProyecto c)
        {
            cdal.AgregarClienteProyectoDal(c);
        }
        public void EditarClienteProyectoBss(ClienteProyecto c)
        {
            cdal.EditarClienteProyectoDal(c);
        }
        public ClienteProyecto ObtenerClienteProyectoBss(int idCliente)
        {
            return cdal.ObtenerClienteProyectoDal(idCliente);
        }
        public int ObtenerUltimoIdClienteBss()
        {
            return cdal.ObtenerUltimoIdCliente();
        }
        public int ObtenerUltimoIdPersonabss()
        {
            return cdal.ObtenerUltimoIdPersona();
        }
        public void EliminarClienteBss(int id)
        {
            cdal.EliminarClienteDal(id);
        }
    }
}
