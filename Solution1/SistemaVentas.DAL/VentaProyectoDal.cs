using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.MODELOS;

namespace SistemaVentas.DAL
{
    public class VentaProyectoDal
    {
        public DataTable ListarVentaProyectoDal()
        {
            string consulta = "SELECT * FROM Venta";
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "tabla");
            return tabla;
        }
        public DataTable ListardetalleVentaProyectoDal()
        {
            string consulta = "SELECT * FROM Detalleventa";
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "tabla");
            return tabla;
        }
        public void InsertarVentaDal(VentaProyecto detalleVenta)
        {
            string consulta = "insert into DetalleVenta values(" +
                              "'" + detalleVenta.IDVenta + "'," +
                              "'" + detalleVenta.IDProducto + "'," +
                              "'" + detalleVenta.Cantidad + "'," +
                              "'" + detalleVenta.PrecioVenta + "'," +
                              "'" + detalleVenta.Subtotal + "'," +
                              "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public void EditarDetalleVenta(VentaProyecto detalleVenta)
        {
            string consulta = "UPDATE DetalleVenta SET " +
                              "IDVenta = '" + detalleVenta.IDVenta + "'," +
                              "IDProducto = '" + detalleVenta.IDProducto + "'," +
                              "Cantidad = '" + detalleVenta.Cantidad + "'," +
                              "PrecioVenta = '" + detalleVenta.PrecioVenta + "'," +
                              "Subtotal = '" + detalleVenta.Subtotal + "'," +
                              "Estado = 'Activo' " +
                              "WHERE IDDetalleVenta = " + detalleVenta.IDDetalleVenta;
            conexion.Ejecutar(consulta);
        }
        public VentaProyecto ObtenerDetalleVentaDal(int idDetalleVenta)
        {
            string consulta = "SELECT * FROM DETALLEVENTA WHERE IDDETALLEVENTA=" + idDetalleVenta;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asas");
            VentaProyecto detalleVenta = new VentaProyecto();

            if (tabla.Rows.Count > 0)
            {
                detalleVenta.IDDetalleVenta = Convert.ToInt32(tabla.Rows[0]["IDDETALLEVENTA"]);
                detalleVenta.IDVenta = Convert.ToInt32(tabla.Rows[0]["IDVENTA"]);
                detalleVenta.IDProducto = Convert.ToInt32(tabla.Rows[0]["IDPRODUCTO"]);
                detalleVenta.Cantidad = Convert.ToInt32(tabla.Rows[0]["CANTIDAD"]);
                detalleVenta.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["PRECIOVENTA"]);
                detalleVenta.Subtotal = Convert.ToDecimal(tabla.Rows[0]["SUBTOTAL"]);
                detalleVenta.Estado = tabla.Rows[0]["ESTADO"].ToString();
            }

            return detalleVenta;
        }
        public int ObtenerUltimoDetalleVentaId()
        {
            string consulta = "SELECT MAX(IDDETALLEVENTA) FROM DETALLEVENTA";
            int ultimoId = 0;

            try
            {
                ultimoId = Convert.ToInt32(conexion.EjecutarEscalar(consulta));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el último ID de detalle de venta: " + ex.Message);
            }

            return ultimoId + 1;
        }
        public void EliminarVentaDal(int idVenta)
        {
            string consulta = "DELETE FROM DETALLEVENTA WHERE IDDETALLEVENTA = " + idVenta;
            conexion.Ejecutar(consulta);
        }

    }


}
