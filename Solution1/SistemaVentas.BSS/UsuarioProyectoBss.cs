using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.DAL;
using System.Data;
using SistemaVentas.MODELOS;

namespace SistemaVentas.BSS
{
    
    public class UsuarioProyectoBss
    {
        UsuarioProyectoDal udal= new UsuarioProyectoDal();
        public DataTable ListarUsuarioProyectoBss()
        {
            return udal.ListarUsuarioProyectoDal();
        }
        public void InsertarUsuarioProyectoBss(UsuarioProyecto u, PersonaProyecto p) 
        { 
            udal.InsertarUsuarioProyectoDal(u,p);
        }
        public void EditarUsuarioProyectoBss(UsuarioProyecto u)
        {
            udal.EditarUsuarioDal(u);
        }
        public UsuarioProyecto ObtenerUsuarioProyectoBss(int id)
        {
            return udal.ObtenerUsuarioProyectoDal(id);
        }
        public void EliminarUsuarioProyectoBss(int id)
        {
            udal.EliminarUsuarioDal(id);
        }
    }
}
