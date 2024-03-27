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
        public DataTable ListarPersonaBss()
        {
            return dal.ListarPersonaDal();
        }
        public void  InsertarUsuarioBss(Usuario usuario)
        {
            dal.InsertarUsuarioDal(usuario);   
        }
    }
}
