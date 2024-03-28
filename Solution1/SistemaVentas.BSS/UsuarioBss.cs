using SistemaVentas.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.BSS;
using SistemaVentas.MODELOS;
using System.Data;

namespace SistemaVentas.BSS
{
    public class UsuarioBss
    {
        
        public UsuarioBss() { }
        
        UsuarioDal dal=new UsuarioDal();
        public DataTable ListarUsuarioBss()
        {
            return dal.ListarUsuarioDal();
        }
        public void  InsertarUsuarioBss(Usuario usuario)
        {
            dal.InsertarUsuarioDal(usuario);   
        }
        public DataTable ListarIdUsuarioBss()
        {
            return dal.ListarIdUsuarioDal();
        }
    }
}
