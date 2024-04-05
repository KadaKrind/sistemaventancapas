using SistemaVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA
{
    public partial class ExamenListarProductosVentasVista : Form
    {
        public ExamenListarProductosVentasVista()
        {
            InitializeComponent();
        }
        ExamenBss bss = new ExamenBss();
        private void ExamenListarProductosVentasVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProductosVendidosbss();    
        }
    }
}
