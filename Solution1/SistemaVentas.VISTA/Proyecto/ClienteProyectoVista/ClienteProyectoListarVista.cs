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

namespace SistemaVentas.VISTA.Proyecto.ClienteProyectoVista
{
    public partial class ClienteProyectoListarVista : Form
    {
        public ClienteProyectoListarVista()
        {
            InitializeComponent();
        }
        ClienteProyectoBss cbss = new ClienteProyectoBss();
        private void button2_Click(object sender, EventArgs e)
        {
            int IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ClienteProyectoEditarVista fr = new ClienteProyectoEditarVista(IdClienteSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = cbss.ListarClienteProyectoBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idclienteseleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta Seguro de eliminar este pedido", "Eliminado", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cbss.EliminarClienteBss(idclienteseleccionado);
                dataGridView1.DataSource = cbss.ListarClienteProyectoBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteProyectoAgregarVista fr = new ClienteProyectoAgregarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = cbss.ListarClienteProyectoBss();
            }
        }

        private void ClienteProyectoListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cbss.ListarClienteProyectoBss();
        }
    }
}
