using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.DAL;
using System.Data;
using SistemaVentas.MODELOS;

namespace SistemaVentas.DAL
{
    public class ProductoProyectoDal
    {
        public DataTable ListarProductosPrecioDal()
        {
            string consulta = "SELECT PRODUCTO.IDPRODUCTO, PRODUCTO.NOMBRE, DETALLEING.PRECIOVENTA\r\nFROM   PRODUCTO INNER JOIN\r\n             DETALLEING ON PRODUCTO.IDPRODUCTO = DETALLEING.IDPRODUCTO";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "Lista");
            return lista;
        }
        public DataTable ListarProductosDal()
        {
            string consulta = "SELECT * FROM Producto";
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "tabla");
            return tabla;
        }
        public void AgregarProductoDal(ProductoProyecto producto)
        {
            string consulta = "insert into Producto values("/* +
                              "'" + producto.IDProducto + "'," */+
                              "'" + producto.IDTipoProducto + "'," +
                              "'" + producto.IDMarca + "'," +
                              "'" + producto.Nombre + "'," +
                              "'" + producto.CodigoBarra + "'," +
                              "'" + producto.Unidad + "'," +
                              "'" + producto.Descripcion + "'," +
                              "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public ProductoProyecto ObtenerProductoIdDal(int idProducto)
        {
            string consulta = "SELECT * FROM Producto WHERE IDPRODUCTO = " + idProducto;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "tabla");
            ProductoProyecto producto = new ProductoProyecto();

            if (tabla.Rows.Count > 0)
            {
                producto.IDProducto = Convert.ToInt32(tabla.Rows[0]["IDPRODUCTO"]);
                producto.IDTipoProducto = Convert.ToInt32(tabla.Rows[0]["IDTIPOPROD"]);
                producto.IDMarca = Convert.ToInt32(tabla.Rows[0]["IDMARCA"]);
                producto.Nombre = tabla.Rows[0]["NOMBRE"].ToString();
                producto.CodigoBarra = tabla.Rows[0]["CODIGOBARRA"].ToString();
                producto.Unidad = Convert.ToInt32(tabla.Rows[0]["UNIDAD"]);
                producto.Descripcion = tabla.Rows[0]["DESCRIPCION"].ToString();
                producto.Estado = tabla.Rows[0]["ESTADO"].ToString();
            }

            return producto;
        }
        public void EditarProductoDal(ProductoProyecto producto)
        {
            string consulta = "UPDATE Producto SET " +
                              "IDTIPOPROD = '" + producto.IDTipoProducto + "', " +
                              "IDMARCA = '" + producto.IDMarca + "', " +
                              "NOMBRE = '" + producto.Nombre + "', " +
                              "CODIGOBARRA = '" + producto.CodigoBarra + "', " +
                              "UNIDAD = '" + producto.Unidad + "', " +
                              "DESCRIPCION = '" + producto.Descripcion + "', " +
                              "ESTADO = 'Activo' " +
                              "WHERE IDPRODUCTO = " + producto.IDProducto;

            conexion.Ejecutar(consulta);
        }
        public int ObtenerUltimoIdProductoDal()
        {
            string consulta = "SELECT MAX(IDPRODUCTO) FROM Producto";
            object result = conexion.EjecutarEscalarComoString(consulta);
            if (result != null && int.TryParse(result.ToString(), out int ultimoId))
            {
                return ultimoId + 1;
            }
            else
            {
                
                return 1;
            }
        }
        public DataTable ListarMarcaDal()
        {
            string consulta = "select * from MARCA";
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "tabla");
            return tabla;
        }
        public DataTable ObtenerTiposProductoDAl()
        {
            string consulta = "SELECT * FROM TipoProducto";
            return conexion.EjecutarDataTabla(consulta, "TipoProducto");
        }
        public void EliminarProductooDal(int id)
        {
            string consulta = "delete from Producto where IDProducto=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
