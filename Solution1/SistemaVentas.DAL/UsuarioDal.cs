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
        public DataTable ListarUsuarioDal()
        {
            string consulta = "SELECT        USUARIO.NOMBREUSER, USUARIO.CONTRASEÑA, PERSONA.IDPERSONA, PERSONA.NOMBRE, PERSONA.APELLIDO, USUARIOROL.ESTADO\r\nFROM            USUARIO INNER JOIN\r\n                         PERSONA ON USUARIO.IDPERSONA = PERSONA.IDPERSONA INNER JOIN\r\n                         USUARIOROL ON USUARIO.IDUSUARIO = USUARIOROL.IDUSUARIO";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable ListarIdUsuarioDal()
        {
            string consulta = "SELECT        PERSONA.IDPERSONA, USUARIO.IDUSUARIO, PERSONA.NOMBRE, USUARIO.NOMBREUSER, PERSONA.APELLIDO\r\nFROM            PERSONA INNER JOIN\r\n                         USUARIO ON PERSONA.IDPERSONA = USUARIO.IDPERSONA INNER JOIN\r\n                         USUARIOROL ON USUARIO.IDUSUARIO = USUARIOROL.IDUSUARIO";
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
