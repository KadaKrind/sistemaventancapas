using SistemaVentas.BSS;
using SistemaVentas.VISTA.PersonaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace SistemaVentas.VISTA.GerenteVistas
{
    public partial class GerenteUsuarioSeleccionarVista : Form
    {
        PersonaBss bss = new PersonaBss();
        UsuarioBss ubss= new UsuarioBss();
        public GerenteUsuarioSeleccionarVista()
        {
            InitializeComponent();
        }

        private void GerenteUsuarioSeleccionarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ubss.ListarUsuarioBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
