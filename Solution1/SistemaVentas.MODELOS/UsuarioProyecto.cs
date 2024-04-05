using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.MODELOS
{
    public class UsuarioProyecto
    {
        public int IDUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public DateTime FechReg{ get; set; }
        public string Rol { get; set; }
        public int IDPersonas { get; set; }
    }
}
