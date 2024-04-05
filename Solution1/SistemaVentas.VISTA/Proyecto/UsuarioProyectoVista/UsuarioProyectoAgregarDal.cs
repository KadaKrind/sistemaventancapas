using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVentas.DAL;
using SistemaVentas.BSS;
using SistemaVentas.MODELOS;
using static SistemaVentas.DAL.PersonaProyectoDal;

namespace SistemaVentas.VISTA.Proyecto.UsuarioProyectoVista
{
    public partial class UsuarioProyectoAgregarDal : Form
    {
        public UsuarioProyectoAgregarDal()
        {
            InitializeComponent();
        }
        PersonaProyectoBss pbss = new PersonaProyectoBss();
        PersonaProyectoDal pdal = new PersonaProyectoDal();
        UsuarioProyectoBss ubss = new UsuarioProyectoBss();
        

        private void UsuarioProyectoAgregarDal_Load(object sender, EventArgs e)
        {
            int SiguienteIdPersona = pdal.ObtenerSiguienteIdPersonaDal();
            textBox3.Text = SiguienteIdPersona.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonaProyecto p = new PersonaProyecto();
            UsuarioProyecto u = new UsuarioProyecto();
            u.NombreUsuario=textBox1.Text;
            u.Password=textBox2.Text;
            u.FechReg = dateTimePicker1.Value;
            p.IdPersona = Convert.ToInt32(textBox3.Text);
            ubss.InsertarUsuarioProyectoBss(u,p);
            MessageBox.Show("Se Guardo Correctamente");
            this.DialogResult= DialogResult.OK;

        }
    }
}
