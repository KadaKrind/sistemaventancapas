using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using SistemaVentas.DAL;
using System.Threading.Tasks;
using SistemaVentas.MODELOS;

namespace SistemaVentas.BSS
{
    public class VentaProyectoBss
    {
        VentaProyectoDal vdal=new VentaProyectoDal();
        public DataTable ListarVentaProyectoBss()
        {
            return vdal.ListarVentaProyectoDal();
        }
        public DataTable ListarDetalleVentaProyectoBss()
        {
            return vdal.ListardetalleVentaProyectoDal();
        }
        public int ObtenerSiguienteIdDetalleVentBss()
        {
            
            return vdal.ObtenerUltimoDetalleVentaId();
        }
        public void InsertarVentaDal(VentaProyecto detalleVenta)
        {
            vdal.InsertarVentaDal(detalleVenta);
        }
        public VentaProyecto ObtenerDetalleVentaBss(int idDetalleVenta)
        {
            return vdal.ObtenerDetalleVentaDal(idDetalleVenta);
        }
        public void EditarDetalleVentabss(VentaProyecto detalleVenta)
        {
            vdal.EditarDetalleVenta(detalleVenta);  
        }
        public void EliminarVentaBss(int idVenta)
        {
            vdal.EliminarVentaDal(idVenta);
        }
    }
}
