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
using SistemaVentas.MODELOS;
using SistemaVentas.BSS;
namespace SistemaVentas.VISTA.Proyecto.ClienteProyectoVista
{
    public partial class ClienteProyectoAgregarVista : Form
    {
        public ClienteProyectoAgregarVista()
        {
            InitializeComponent();
        }
        ClienteProyectoDal cdal = new ClienteProyectoDal();
        ClienteProyectoBss cbss= new ClienteProyectoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            ClienteProyecto c= new ClienteProyecto();
            c.IdCliente=Convert.ToInt32(textBox2.Text);
            c.IdPersona=Convert.ToInt32(textBox3.Text);
            c.TipoCliente = comboBox1.Text;
            c.Estado= comboBox2.Text;
            cbss.AgregarClienteProyectoBss(c);
            MessageBox.Show("Se guardo Correctamente");
            this.DialogResult = DialogResult.OK;

        }

        private void ClienteProyectoAgregarVista_Load(object sender, EventArgs e)
        {
            int Sidcliente = cdal.ObtenerUltimoIdCliente();
            int Sidpersona = cdal.ObtenerUltimoIdPersona();
            textBox2.Text= Sidcliente.ToString();
            textBox3.Text = Sidpersona.ToString();
        }
    }
}
