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
using SistemaVentas.DAL;
using SistemaVentas.VISTA.UsuarioVistar;

namespace SistemaVentas.VISTA.GerenteVistas
{
    public partial class GerenteAgregarVista : Form
    {
        public GerenteAgregarVista()
        {
            InitializeComponent();
        }
        UsuarioBss bss = new UsuarioBss();

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.NombreUser = textBox1.Text;
            u.Contrasena = textBox2.Text;
            u.Fechareg = dateTimePicker1.Value;
            bss.InsertarUsuarioBss(u);
            MessageBox.Show("Usuario agregado correctamente");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
