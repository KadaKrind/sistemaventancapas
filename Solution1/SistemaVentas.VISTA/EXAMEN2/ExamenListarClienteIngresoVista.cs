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
    public partial class ExamenListarClienteIngresoVista : Form
    {
        public ExamenListarClienteIngresoVista()
        {
            InitializeComponent();
        }
        ExamenBss bss = new ExamenBss();
        private void ExamenListarClienteIngresoVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClienteIngresoBss();
        }
    }
}
