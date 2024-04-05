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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaVentas.VISTA.Proyecto.ProductoProyectoVista
{
    public partial class ProductoAgregarVista : Form
    {
        public ProductoAgregarVista()
        {
            InitializeComponent();
        }
        ProductoProyectoBss prbss = new ProductoProyectoBss();
        private void ProductoAgregarVista_Load(object sender, EventArgs e)
        {

            dataGridView2.DataSource = prbss.ListarMarcaBss();
            int a = prbss.ObtenerUltimoIdProductoBss();
            textBox1.Text = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idcliente = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            textBox3.Text = idcliente.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductoProyecto pr = new ProductoProyecto();
            pr.IDProducto = Convert.ToInt32(textBox1.Text);
            pr.IDTipoProducto= Convert.ToInt32(comboBox1.Text);
            pr.IDMarca= Convert.ToInt32(textBox3.Text);
            pr.Nombre=textBox4.Text;
            pr.CodigoBarra=textBox5.Text;
            pr.Unidad=Convert.ToInt32(numericUpDown1.Value);
            pr.Descripcion = textBox6.Text;
            prbss.AgregarProductoBss(pr);
            MessageBox.Show(" Se Guardo Correctamente");
            this.DialogResult = DialogResult.OK;
        }
    }
}
