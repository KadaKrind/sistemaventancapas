using SistemaVentas.BSS;
using SistemaVentas.DAL;
using SistemaVentas.MODELOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA.Proyecto.ClienteProyectoVista
{
    public partial class ClienteProyectoEditarVista : Form
    {
        int idx = 0;
        ClienteProyecto c = new ClienteProyecto();
        ClienteProyectoBss cbss = new ClienteProyectoBss();
        public ClienteProyectoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }
        PersonaProyectoDal pdal = new PersonaProyectoDal();
        PersonaProyectoBss pbss = new PersonaProyectoBss();
        ClienteProyectoDal cdal = new ClienteProyectoDal();

        private void ClienteProyectoEditarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pbss.ListarPersonaBss();
            c = cbss.ObtenerClienteProyectoBss(idx);
            textBox2.Text = c.IdCliente.ToString();
            textBox3.Text = c.IdPersona.ToString();
            textBox1.Text = c.CodigoCliente.ToString();
            comboBox1.Text = c.TipoCliente.ToString();
            comboBox2.Text = c.Estado.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.TipoCliente = comboBox1.Text;
            c.CodigoCliente = textBox1.Text;
            c.Estado = comboBox2.Text;
            c.IdCliente = Convert.ToInt32(textBox2.Text);
            c.IdPersona = Convert.ToInt32(textBox3.Text);
            cbss.EditarClienteProyectoBss(c);
            MessageBox.Show("Se guardo correctamente");
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idpersona = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            textBox3.Text = idpersona.ToString();
        }
    }
}
