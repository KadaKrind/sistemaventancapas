using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    internal class PersonaDal
    {
        public DataTable ListarPersonaDal()
        {
            string consulta = "select * from persona";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista; 
        }
    }
}
