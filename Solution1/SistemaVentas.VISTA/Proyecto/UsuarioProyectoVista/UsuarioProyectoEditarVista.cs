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


namespace SistemaVentas.VISTA.Proyecto.UsuarioProyectoVista
{
    public partial class UsuarioProyectoEditarVista : Form
    {
        int idx = 0;
        UsuarioProyecto u = new UsuarioProyecto();
        PersonaProyecto p = new PersonaProyecto();

        public UsuarioProyectoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }
        PersonaProyectoBss pbss = new PersonaProyectoBss();
        UsuarioProyectoBss ubss = new UsuarioProyectoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            u.NombreUsuario = textBox1.Text;
            u.Password= textBox2.Text;
            u.FechReg = dateTimePicker1.Value;
            u.IDPersonas=Convert.ToInt32(textBox3.Text);
            u.IDUsuario=Convert.ToInt32(textBox4.Text);
            ubss.EditarUsuarioProyectoBss(u);
            MessageBox.Show("Datos Actualizados");
            DialogResult = DialogResult.OK;
        }

        private void UsuarioProyectoEditarVista_Load(object sender, EventArgs e)
        {
            u = ubss.ObtenerUsuarioProyectoBss(idx);
            textBox1.Text = u.NombreUsuario;
            textBox2.Text = u.Password;
            dateTimePicker1.Value = u.FechReg;
            textBox3.Text = u.IDPersonas.ToString();
            textBox4.Text=u.IDUsuario.ToString();

        }
    }
}
