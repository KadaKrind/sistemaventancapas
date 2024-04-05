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

namespace SistemaVentas.VISTA.EXAMEN2
{
    public partial class ExamenMarcasVentasVista : Form
    {
        public ExamenMarcasVentasVista()
        {
            InitializeComponent();
        }
        ExamenBss bss = new ExamenBss();
        private void ExamenMarcasVentasVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarMarcasVentaBss(); ;
        }
    }
}
