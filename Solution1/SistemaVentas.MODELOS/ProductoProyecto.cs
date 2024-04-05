using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.MODELOS
{
    public class ProductoProyecto
    {
        public int IDProducto { get; set; }
        public int IDTipoProducto { get; set; }
        public int IDMarca { get; set; }
        public string Nombre { get; set; }
        public string CodigoBarra { get; set; }
        public int Unidad { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    }
}
