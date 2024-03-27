using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.MODELOS;
using SistemaVentas.DAL;


namespace SistemaVentas.DAL
{
    public class UsuarioDal
    {
        
        public UsuarioDal() { }
        /*public void InsertarUsuarioDal(Usuario u) 
        {
            string consulta = "insert into usuario values(" + u.IdPersona + "','" + u.NombreUser + "','" + u.Contrasena + "','" + u.Fechareg + "'')";
            conexion.Ejecutar(consulta);
        }*/
        public DataTable ListarPersonaDal()
        {
            string consulta = "select * from persona";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioDal(Usuario usuario)
        {
            //usuario.IdPersona= Convert.ToInt32(tabla.Rows[0]["idpersona"]);
            string consulta = "insert into usuario values('" +usuario.IdPersona+ "',"+ "'" + usuario.NombreUser + "'," + "'" + usuario.Contrasena + "'," + "'" + usuario.Fechareg + "')";
            conexion.Ejecutar(consulta);
        }
    }
}
