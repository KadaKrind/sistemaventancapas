using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.DAL;
using SistemaVentas.MODELOS;

namespace SistemaVentas.BSS
{
    public class ProductoProyectoBss
    {
        ProductoProyectoDal prdal = new ProductoProyectoDal();
        public DataTable ListarProductosPrecioBss()
        {
            return prdal.ListarProductosPrecioDal();
        }
        public DataTable ListarProductosBss()
        {
            return prdal.ListarProductosDal();
        }
        public void AgregarProductoBss(ProductoProyecto producto)
        {
            prdal.AgregarProductoDal(producto);
        }
        public ProductoProyecto ObtenerProductoIdBss(int idProducto)
        {
            return prdal.ObtenerProductoIdDal(idProducto);
        }
        public void EditarProductoBss(ProductoProyecto producto)
        {

            prdal.EditarProductoDal(producto);
        }
        public int ObtenerUltimoIdProductoBss()
        {
            return prdal.ObtenerUltimoIdProductoDal();
        }
        public DataTable ListarMarcaBss()
        {
            return prdal.ListarMarcaDal();
        }
        public void EliminarPedidoBss(int id)
        {
            prdal.EliminarProductooDal(id);      }
    }
}
