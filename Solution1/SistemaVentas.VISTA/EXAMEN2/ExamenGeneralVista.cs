using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA.EXAMEN2
{
    public partial class ExamenGeneralVista : Form
    {
        public ExamenGeneralVista()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExamenMarcasVentasVista fr = new ExamenMarcasVentasVista();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExamenFechaVencimientoVista fr = new ExamenFechaVencimientoVista();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExamenNombreyApellidoVista fr = new ExamenNombreyApellidoVista();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExamenListarProveedorVista fr = new ExamenListarProveedorVista();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExamenCantidadInventarioVista fr = new ExamenCantidadInventarioVista();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ExamenListarVendedorVentasVista fr = new ExamenListarVendedorVentasVista();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ExamenListarClienteIngresoVista fr = new ExamenListarClienteIngresoVista();
            fr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ExamenListarProveedorVista fr = new ExamenListarProveedorVista();
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ExamenListarProductosVentasVista fr = new ExamenListarProductosVentasVista();
            fr.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ExamenPedidoDatos fr = new ExamenPedidoDatos();
            fr.Show(); 
        }
    }
}
