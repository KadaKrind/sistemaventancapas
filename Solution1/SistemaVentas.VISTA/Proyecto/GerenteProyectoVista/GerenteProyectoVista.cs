using SistemaVentas.MODELOS;
using SistemaVentas.VISTA.Proyecto.ClienteProyectoVista;
using SistemaVentas.VISTA.Proyecto.ProductoProyectoVista;
using SistemaVentas.VISTA.Proyecto.UsuarioProyectoVista;
using SistemaVentas.VISTA.Proyecto.VentaProyectoVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA.Proyecto.GerenteProyectoVista
{
    public partial class GerenteProyectoVista : Form
    {
        int ids = 0;
        public GerenteProyectoVista(int a)
        {   
            ids = a;
            InitializeComponent();
            if (ids == 2) 
            {
                MessageBox.Show("Bienvenido Vendedor");
                button1.Enabled= false;
                button2.Enabled= false;
                button3.Enabled= true;
                button4.Enabled= false;
                
            
            }
            else if(ids == 3)
            {
                MessageBox.Show("Bienvenido Encargado de almacen");
                button1.Enabled= false;
                button2.Enabled= false;
                    
                button3.Enabled= false;
                button4.Enabled= true;
            }
            else
            {
                MessageBox.Show("Bienvenido Gerente");
            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioProyectoListarVista fr = new UsuarioProyectoListarVista();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClienteProyectoListarVista fr = new ClienteProyectoListarVista();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentaProyectoListarVista fr = new VentaProyectoListarVista();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductoListarVista fr = new ProductoListarVista();
            fr.Show();
        }
        public int a = 2;
        private void button8_Click(object sender, EventArgs e)
        {
            
            if(a%2 == 0)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
            a++;
        }
    }
}
