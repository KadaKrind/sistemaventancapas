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

namespace SistemaVentas.VISTA.Proyecto.UsuarioProyectoVista
{
    public partial class UsuarioProyectoListarVista : Form
    {
        public UsuarioProyectoListarVista()
        {
            InitializeComponent();
        }
        UsuarioProyectoBss ubss = new UsuarioProyectoBss();
        private void UsuarioProyectoListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ubss.ListarUsuarioProyectoBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioProyectoAgregarDal fr = new UsuarioProyectoAgregarDal();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = ubss.ListarUsuarioProyectoBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta Seguro de eliminar este pedido", "Eliminado", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ubss.EliminarUsuarioProyectoBss(IdUsuarioSeleccionado);
                dataGridView1.DataSource = ubss.ListarUsuarioProyectoBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioProyectoEditarVista fr= new UsuarioProyectoEditarVista(IdUsuarioSeleccionado);
            if (fr.ShowDialog()==DialogResult.OK)
            {
                dataGridView1.DataSource = ubss.ListarUsuarioProyectoBss();
            }
        }
    }
}
