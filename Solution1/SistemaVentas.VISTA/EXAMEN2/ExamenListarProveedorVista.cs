﻿using SistemaVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA.EXAMEN2
{
    public partial class ExamenListarProveedorVista : Form
    {
        public ExamenListarProveedorVista()
        {
            InitializeComponent();
        }
        ExamenBss bss = new ExamenBss();
        private void ExamenListarProveedorVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProveedorBss();
        }
    }
}
