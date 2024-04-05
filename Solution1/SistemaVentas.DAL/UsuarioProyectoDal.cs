using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.MODELOS;

namespace SistemaVentas.DAL
{
    public class UsuarioProyectoDal
    {
        public DataTable ListarUsuarioProyectoDal()
        {
            string consulta = "select * from Usuario";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioProyectoDal(UsuarioProyecto u, PersonaProyecto p)
        {
            /*string consulta="insert into USUARIO values('"+p.IdPersona+"'" +","+"'"+u.NombreUsuario+"',"+"'"+u.Password+"',"+"'"+u.FechReg+"')";*/
            string consulta = "insert into usuario values('" + p.IdPersona + "'," + "'" + u.NombreUsuario + "'," + "'" + u.Password + "'," + "'" + u.FechReg + "')";
            conexion.Ejecutar(consulta);
            
        }
        public UsuarioProyecto ObtenerUsuarioProyectoDal(int uid)
        {
            string consulta = "select * from Usuario where IDUSUARIO=" + uid;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asas");
            UsuarioProyecto u = new UsuarioProyecto();
            PersonaProyecto p = new PersonaProyecto();
            if (tabla.Rows.Count > 0 ) 
            {
                u.IDUsuario = Convert.ToInt32(tabla.Rows[0]["IDUSUARIO"]);
                u.IDPersonas = Convert.ToInt32(tabla.Rows[0]["IDPERSONA"]);
                u.NombreUsuario = tabla.Rows[0]["NOMBREUSER"].ToString();
                u.Password = tabla.Rows[0]["CONTRASEÑA"].ToString();
                u.FechReg = Convert.ToDateTime(tabla.Rows[0]["FECHAREG"]);
                
            }
            return u;
        }
        public void EditarUsuarioDal(UsuarioProyecto u)
        {
            string consulta = "update USUARIO set IDPERSONA='" + u.IDPersonas + "', NOMBREUSER = '" + u.NombreUsuario + "', CONTRASEÑA = '" + u.Password + "',FECHAREG='"+u.FechReg+"'"+"WHERE IdUSUARIO = " + u.IDUsuario;
            conexion.Ejecutar(consulta);
        }
        public void EliminarUsuarioDal(int id)
        {
            string consulta = "delete from Usuario where IDUSUARIO=" + id;
            conexion.Ejecutar(consulta);
        }                                                       
    }
}
