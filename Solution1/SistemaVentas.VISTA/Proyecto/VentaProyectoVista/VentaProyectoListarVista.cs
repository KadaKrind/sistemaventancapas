using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVentas.BSS;

namespace SistemaVentas.VISTA.Proyecto.VentaProyectoVista
{
    public partial class VentaProyectoListarVista : Form
    {
        VentaProyectoBss vbss = new VentaProyectoBss();
        public VentaProyectoListarVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentaProyectoAgregar fr = new VentaProyectoAgregar();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = vbss.ListarDetalleVentaProyectoBss();
            }
        }

        private void VentaProyectoListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vbss.ListarDetalleVentaProyectoBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            VentaProyectoEditarVista fr = new VentaProyectoEditarVista(idVentaSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = vbss.ListarDetalleVentaProyectoBss();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idVentaSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta Seguro de eliminar este pedido", "Eliminado", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                vbss.EliminarVentaBss(idVentaSeleccionado);
                dataGridView1.DataSource = vbss.ListarDetalleVentaProyectoBss();
            }
        }
    }
}
