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
    public partial class VentaProyectoEditarVista : Form
    {
        int idx = 0;
        VentaProyecto v = new VentaProyecto();
        public VentaProyectoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }
        ProductoProyectoBss prbss = new ProductoProyectoBss();
        VentaProyectoBss vbss = new VentaProyectoBss();
        private void VentaProyectoEditarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vbss.ListarVentaProyectoBss();
            dataGridView2.DataSource = prbss.ListarProductosPrecioBss();
            v = vbss.ObtenerDetalleVentaBss(idx);
            textBox1.Text = v.IDDetalleVenta.ToString();
            textBox2.Text = v.IDVenta.ToString();
            textBox3.Text = v.IDProducto.ToString();
            numericUpDown1.Value = v.Cantidad;
            decimal valor = v.PrecioVenta;

            string valorFormateado = valor.ToString("0");

            textBox4.Text = valorFormateado;
            //textBox4.Text = v.PrecioVenta.ToString();
            decimal valor2 = v.Subtotal;

            string valorFormateado2 = valor.ToString("0");

            textBox5.Text = valorFormateado2;
            //textBox5.Text = v.Subtotal.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            v.IDDetalleVenta = Convert.ToInt32(textBox1.Text);
            v.IDVenta = Convert.ToInt32(textBox2.Text);
            v.IDProducto = Convert.ToInt32(textBox3.Text);
            v.Cantidad = Convert.ToInt32(numericUpDown1.Value);
            v.PrecioVenta = Convert.ToInt32(textBox4.Text);
            v.Subtotal = Convert.ToInt32(textBox5.Text);
            vbss.EditarDetalleVentabss(v);
            MessageBox.Show("Datos Actualizados");
            this.DialogResult = DialogResult.OK;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 0)
            {
                int b = Convert.ToInt32(textBox4.Text);
                int c = Convert.ToInt32(numericUpDown1.Value);
                int z = b * c;
                textBox5.Text = z.ToString();
            }
            
            
        }
    }
}
