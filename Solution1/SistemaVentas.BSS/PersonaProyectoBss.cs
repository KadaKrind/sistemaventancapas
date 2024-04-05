using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.DAL;
using System.Data;

namespace SistemaVentas.BSS
{
    public class PersonaProyectoBss
    {
        PersonaProyectoDal pdal=new PersonaProyectoDal();
        public void ObtenerSiguienteIdPersonaBss()
        {
            pdal.ObtenerSiguienteIdPersonaDal();
        }
        public DataTable ListarPersonaBss()
        {
            return pdal.ListarPersonadal();
        }
    }
}
