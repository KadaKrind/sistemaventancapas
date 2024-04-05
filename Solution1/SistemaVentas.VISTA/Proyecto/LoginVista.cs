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

namespace SistemaVentas.VISTA.Proyecto
{
    public partial class LoginVista : Form
    {
        public LoginVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBox1.Text;
            string contrasena = textBox2.Text;

            LoginDal loginDal = new LoginDal();
            string rol = loginDal.ValidarCredenciales(nombreUsuario, contrasena);

            if (rol != null)
            {
                MessageBox.Show("¡Inicio de sesión exitoso!", "Inicio de Sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int seleccion = Convert.ToInt32(rol);

                switch (seleccion)
                {
                    case 1:
                        int a = 1;
                        GerenteProyectoVista.GerenteProyectoVista fr = new GerenteProyectoVista.GerenteProyectoVista(a);
                        fr.Show();
                        break;
                    case 2:
                        int b = 2;
                        GerenteProyectoVista.GerenteProyectoVista fr1 = new GerenteProyectoVista.GerenteProyectoVista(b);
                        fr1.Show();
                        break;
                    case 3:
                        int c = 3;
                        GerenteProyectoVista.GerenteProyectoVista fr2 = new GerenteProyectoVista.GerenteProyectoVista(c);
                        fr2.Show();
                        break;
                    default:

                        break;
                }
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Inicio de Sesión Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginVista_Load(object sender, EventArgs e)
        {

        }
    }
}
