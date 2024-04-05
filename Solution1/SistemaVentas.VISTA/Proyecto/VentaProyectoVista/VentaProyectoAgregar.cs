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
using SistemaVentas.MODELOS;

namespace SistemaVentas.VISTA.Proyecto.VentaProyectoVista
{
    public partial class VentaProyectoAgregar : Form
    {
        ProductoProyectoBss prbss = new ProductoProyectoBss();
        VentaProyectoBss vbss = new VentaProyectoBss();
        public VentaProyectoAgregar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void VentaProyectoAgregar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vbss.ListarVentaProyectoBss();
            dataGridView2.DataSource = prbss.ListarProductosPrecioBss();
            int a = vbss.ObtenerSiguienteIdDetalleVentBss();
            textBox1.Text = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idventa = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            textBox2.Text = idventa.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idproducto = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            textBox3.Text = idproducto.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox4.Text);
            int c = Convert.ToInt32(numericUpDown1.Value);
            int z = b * c;
            textBox5.Text = z.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentaProyecto d = new VentaProyecto();
            d.IDDetalleVenta = Convert.ToInt32(textBox1.Text);
            d.IDVenta = Convert.ToInt32(textBox2.Text);
            d.IDProducto = Convert.ToInt32(textBox3.Text);
            d.Cantidad = Convert.ToInt32(numericUpDown1.Value);
            d.PrecioVenta = Convert.ToInt32(textBox4.Text);
            d.Subtotal = Convert.ToInt32(textBox5.Text);
            vbss.InsertarVentaDal(d);
            MessageBox.Show("Guardado Correctamente");
            this.DialogResult = DialogResult.OK;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox4.Text);
            int c = Convert.ToInt32(numericUpDown1.Value);
            int z = b * c;
            textBox5.Text = z.ToString();
        }
    }
}
