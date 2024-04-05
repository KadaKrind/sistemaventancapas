using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class ExamenDal
    {
        public DataTable ListarNombreyApellidoDal()
        {
            string consulta = "SELECT        NOMBRE, APELLIDO\r\nFROM            PERSONA";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable ListarProveedorDal()
        {
            string consulta = "SELECT PROVEEDOR.NOMBRE, SUM(INGRESO.TOTAL) AS total_ingresos\r\nFROM INGRESO\r\nINNER JOIN PROVEEDOR ON INGRESO.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR\r\nINNER JOIN PROVEE ON PROVEEDOR.IDPROVEEDOR = PROVEE.IDPROVEEDOR\r\nGROUP BY PROVEEDOR.NOMBRE;";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable ListarVentaMarcaDal()
        {
            string consulta = "SELECT M.NOMBRE AS Marca, COUNT(V.IDVENTA) AS TotalVentas\r\nFROM PRODUCTO P\r\nINNER JOIN MARCA M ON P.IDMARCA = M.IDMARCA\r\nINNER JOIN DETALLEVENTA DV ON P.IDPRODUCTO = DV.IDPRODUCTO\r\nINNER JOIN VENTA V ON DV.IDVENTA = V.IDVENTA\r\nGROUP BY M.NOMBRE\r\nORDER BY TotalVentas DESC;";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable ListarProductosCantidadDal()
        {
            string consulta = "SELECT NOMBRE, SUM(UNIDAD) AS CantidadTotalEnInventario\r\nFROM PRODUCTO\r\nGROUP BY NOMBRE;\r\n";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable ListarVencimientoDal()
        {
            string consulta = "SELECT IDPRODUCTO, FECHAVENC, CANTIDAD\r\nFROM DETALLEING\r\nWHERE FECHAVENC >= GETDATE()\r\nORDER BY FECHAVENC ASC;\r\n";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable ListarVendedoresDal()
        {
            string consulta = "SELECT U.NOMBREUSER AS Vendedor, COUNT(DV.IDDETALLEVENTA) AS CantidadProductosVendidos\r\nFROM VENTA V\r\nINNER JOIN USUARIO U ON V.IDVENDEDOR = U.IDUSUARIO\r\nINNER JOIN DETALLEVENTA DV ON V.IDVENTA = DV.IDVENTA\r\nGROUP BY U.NOMBREUSER;\r\n";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable ListarClienteIngresoDal()
        {
            string consulta = "SELECT C.IDCLIENTE, P.NOMBRE AS NombreCliente, SUM(V.TOTAL) AS TotalIngresos\r\nFROM CLIENTE C\r\nINNER JOIN VENTA V ON C.IDCLIENTE = V.IDCLIENTE\r\nINNER JOIN PERSONA P ON C.IDPERSONA = P.IDPERSONA\r\nGROUP BY C.IDCLIENTE, P.NOMBRE;";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable ListarProveedorProdDal()
        {
            string consulta = "SELECT PR.NOMBRE AS NombreProveedor, COUNT(PRV.IDPRODUCTO) AS TotalProductosSuministrados\r\nFROM PROVEEDOR PR\r\nINNER JOIN PROVEE PRV ON PR.IDPROVEEDOR = PRV.IDPROVEEDOR\r\nGROUP BY PR.NOMBRE\r\nORDER BY TotalProductosSuministrados DESC;";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable ListarProductosVendidosDal()
        {
            string consulta = "SELECT TP.NOMBRE AS TipoProducto, SUM(DV.CANTIDAD) AS CantidadTotalVendida\r\nFROM DETALLEVENTA DV\r\nINNER JOIN PRODUCTO P ON DV.IDPRODUCTO = P.IDPRODUCTO\r\nINNER JOIN TIPOPROD TP ON P.IDTIPOPROD = TP.IDTIPOPROD\r\nGROUP BY TP.NOMBRE;";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable ListarClienteMontoDal(int a)
        {
            int monto = a;
            string consulta = "SELECT C.IDCLIENTE, P.NOMBRE AS NombreCliente, SUM(V.TOTAL) AS TotalCompras\r\n\t\tFROM CLIENTE C\r\n\t\tINNER JOIN VENTA V ON C.IDCLIENTE = V.IDCLIENTE\r\n\t\tINNER JOIN PERSONA P ON C.IDPERSONA = P.IDPERSONA\r\n\t\tGROUP BY C.IDCLIENTE, P.NOMBRE\r\n\t\tHAVING SUM(V.TOTAL) > "+monto;
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}
