using SistemaVentas.BSS;
using SistemaVentas.DAL;
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
    public partial class ExamenPedidoDatos : Form
    {
        public ExamenPedidoDatos()
        {
            InitializeComponent();
        }
        public int A = 0;
        ExamenBss bss = new ExamenBss();
        private void button1_Click(object sender, EventArgs e)
        {
            A = Convert.ToInt32(textBox1.Text);
            bss.ListarClienteMontoBss(A);
            dataGridView1.DataSource = bss.ListarClienteMontoBss(A); 
        }

        private void ExamenPedidoDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
