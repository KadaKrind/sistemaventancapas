using SistemaVentas.DAL;
using System;
using System.Collections.Generic;

using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.BSS
{
    public class ExamenBss
    {

        ExamenDal dal=new ExamenDal();  
        public DataTable ListarNombreyApellidoBss()
        {
            return dal.ListarNombreyApellidoDal();
        }
        public DataTable ListarProveedorBss()
        {
            return dal.ListarProveedorDal();
        }
        public DataTable ListarMarcasVentaBss()
        {
            return dal.ListarVentaMarcaDal();
        }
        public DataTable ListarProductosCantidad()
        {
            return dal.ListarProductosCantidadDal();
        }
        public DataTable ListarVencimientoBss()
        {
            return dal.ListarVencimientoDal();
        }
        public DataTable ListaVendedorBss()
        {
            return dal.ListarVendedoresDal();
        }
        public DataTable ListarClienteIngresoBss()
        {
            return dal.ListarClienteIngresoDal();
        }
        public DataTable ListarProveedorProdBss()
        {
            return dal.ListarProveedorProdDal();
        }
        public DataTable ListarProductosVendidosbss()
        {
            return dal.ListarProductosVendidosDal();    
        }
        public DataTable ListarClienteMontoBss(int b)
        {
            int z = b;
            return dal.ListarClienteMontoDal(z);
        }
    }
}
