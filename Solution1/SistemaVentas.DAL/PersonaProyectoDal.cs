using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaVentas.DAL
{
    public class PersonaProyectoDal
    {
        
            public int ObtenerSiguienteIdPersonaDal()
            {
                string consulta = "SELECT MAX(IdPersona) FROM Usuario";

                object resultado = conexion.EjecutarEscalar(consulta);

                if (resultado == null || resultado == DBNull.Value)
                {
                    return 1;
                }
                else
                {
                    int ultimoId = Convert.ToInt32(resultado);
                    return ultimoId + 1;
                }
            }
        public DataTable ListarPersonadal()
        {
            string consulta = "select * from persona";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public string ValidarCredenciales(string nombreUsuario, string contrasena)
        {
            string consulta = @"SELECT USUARIO.NOMBREUSER, USUARIO.CONTRASEÑA, USUARIOROL.IDROL
                            FROM USUARIO
                            INNER JOIN USUARIOROL ON USUARIO.IDUSUARIO = USUARIOROL.IDUSUARIO";

            try
            {
                DataTable resultado = conexion.EjecutarDataTabla(consulta, "credenciales");

                DataRow usuario = resultado.AsEnumerable()
                                            .FirstOrDefault(row => row.Field<string>("NOMBREUSER") == nombreUsuario &&
                                                                   row.Field<string>("CONTRASEÑA") == contrasena);

                if (usuario != null)
                {
                    int idRol = usuario.Field<int>("IDROL");
                    return ObtenerNombreRol(idRol);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al validar las credenciales: " + ex.Message);
                return null;
            }

        }
        private string ObtenerNombreRol(int idRol)
        {
            switch (idRol)
            {
                case 1:
                    return "Gerente";
                case 2:
                    return "Vendedor";
                case 3:
                    return "Almacenero";
                default:
                    return "Desconocido";
            }
        }

    }
}
