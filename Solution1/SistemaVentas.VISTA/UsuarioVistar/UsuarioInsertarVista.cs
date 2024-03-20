using SistemaVentas.VISTA.PersonaVistas;
using SistemaVentas.MODELOS;
using SistemaVentas.BSS;
using SistemaVentas.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA.UsuarioVistar
{
    public partial class UsuarioInsertarVista : Form
    {
        public UsuarioInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bss = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                persona persona = bss.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
        UsuarioBss bssuser=new UsuarioBss();    

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.IdPersona = IdPersonaSeleccionada;
            usuario.NombreUser=textBox2.Text;
            usuario.Contrasena=textBox3.Text;
            usuario.Fechareg = dateTimePicker1.Value;
            bssuser.InsertarUsuarioBss(usuario);
            MessageBox.Show("Usuario Ingresado");
        }
    }
}
