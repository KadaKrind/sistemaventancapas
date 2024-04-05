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

namespace SistemaVentas.VISTA.Proyecto.ProductoProyectoVista
{
    public partial class ProductoListarVista : Form
    {
        public ProductoListarVista()
        {
            InitializeComponent();
        }
        ProductoProyectoBss prbss = new ProductoProyectoBss();
        private void ProductoListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = prbss.ListarProductosBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoAgregarVista fr = new ProductoAgregarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = prbss.ListarProductosBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProductoProyectoEditarVista fr = new ProductoProyectoEditarVista(IdProductoSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = prbss.ListarProductosBss();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta Seguro de eliminar este pedido", "Eliminado", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                prbss.EliminarPedidoBss(idProductoSeleccionado);
                dataGridView1.DataSource=prbss.ListarProductosBss();
            }
        }
    }
}
