using SistemaVentas.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.MODELOS;

namespace SistemaVentas.BSS
{
    public class UsuarioBss
    {
        public UsuarioBss() { } 
        UsuarioDal dal=new UsuarioDal();
        public void  InsertarUsuarioBss(Usuario usuario)
        {
            dal.InsertarUsuarioDal(usuario);   
        }
    }
}
