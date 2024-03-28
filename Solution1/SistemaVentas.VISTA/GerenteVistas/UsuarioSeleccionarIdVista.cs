using SistemaVentas.BSS;
using SistemaVentas.VISTA.UsuarioVistar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA.GerenteVistas
{
    public partial class UsuarioSeleccionarIdVista : Form
    {
        PersonaBss bss = new PersonaBss();
        UsuarioBss ubss = new UsuarioBss();
        public UsuarioSeleccionarIdVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioInsertarVista.IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>a = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            MessageBox.Show("Seleccionada");
            
        }

        private void UsuarioSeleccionarIdVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ubss.ListarIdUsuarioBss();
        }
    }
}
