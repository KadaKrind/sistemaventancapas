using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class LoginDal
    {



        private static string CONECTAR = @"Data Source=(local); Initial Catalog=TIENDAJuan; Integrated Security=True; TrustServerCertificate=true;";

        public string ValidarCredenciales(string nombreUsuario, string contrasena)
        {
            string rol = null;

            string consulta = "SELECT ROL.IdROl " +
                              "FROM USUARIO " +
                              "INNER JOIN USUARIOROL ON USUARIO.IDUSUARIO = USUARIOROL.IDUSUARIO " +
                              "INNER JOIN ROL ON USUARIOROL.IDROL = ROL.IDROL " +
                              "WHERE USUARIO.NOMBREUSER = @NombreUsuario AND USUARIO.CONTRASEÑA = @Contrasena";

            using (SqlConnection conexion = new SqlConnection(CONECTAR))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    rol = result.ToString();
                }
            }

            return rol;
        }
        public void Logindal2()
        {
            string consulta = "SELECT USUARIO.NOMBREUSER, USUARIO.CONTRASEÑA, USUARIOROL.IDROL\r\nFROM   USUARIO INNER JOIN\r\n             USUARIOROL ON USUARIO.IDUSUARIO = USUARIOROL.IDUSUARIO";
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "tabla");

        }

    }
}
