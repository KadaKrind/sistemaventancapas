using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVentas.MODELOS;
using SistemaVentas.BSS;
namespace SistemaVentas.VISTA.Proyecto.ProductoProyectoVista
{
    public partial class ProductoProyectoEditarVista : Form
    {
        int idx = 0;
        ProductoProyecto pr = new ProductoProyecto();
        public ProductoProyectoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }
        ProductoProyectoBss prbss = new ProductoProyectoBss();
        private void ProductoProyectoEditarVista_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = prbss.ListarMarcaBss();
            pr = prbss.ObtenerProductoIdBss(idx);
            textBox1.Text = pr.IDProducto.ToString();
            comboBox1.Text = pr.IDTipoProducto.ToString();
            textBox3.Text = pr.IDMarca.ToString();
            textBox4.Text = pr.Nombre.ToString();
            numericUpDown1.Value = pr.Unidad;
            textBox5.Text = pr.CodigoBarra.ToString();
            textBox6.Text = pr.Descripcion;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idcliente = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            textBox3.Text = idcliente.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pr.IDProducto = Convert.ToInt32(textBox1.Text);
            pr.IDTipoProducto= Convert.ToInt32(comboBox1.Text);
            pr.IDMarca = Convert.ToInt32(textBox3.Text);
            pr.Nombre = textBox4.Text;
            pr.CodigoBarra = textBox5.Text;
            pr.Unidad=Convert.ToInt32(numericUpDown1.Value);
            pr.Descripcion= textBox6.Text;
            prbss.EditarProductoBss(pr);
            MessageBox.Show("Se guardo correctamente");
            this.DialogResult = DialogResult.OK;

        }
    }
}
