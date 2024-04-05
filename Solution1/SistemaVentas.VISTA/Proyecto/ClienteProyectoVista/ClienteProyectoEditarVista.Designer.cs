namespace SistemaVentas.VISTA.Proyecto.ClienteProyectoVista
{
    partial class ClienteProyectoEditarVista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 101);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "TipoCliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 163);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 1;
            label2.Text = "Codigo Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 253);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 2;
            label3.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 316);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 3;
            label4.Text = "IdCliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 376);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 4;
            label5.Text = "Id Persona";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(367, 376);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(67, 31);
            textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(367, 310);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(67, 31);
            textBox2.TabIndex = 13;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Activo", "Inactivo" });
            comboBox2.Location = new Point(252, 250);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(252, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 31);
            textBox1.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Regular", "Ocacional", "Frecuente" });
            comboBox1.Location = new Point(252, 101);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(523, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(158, 312);
            dataGridView1.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(512, 21);
            label6.Name = "label6";
            label6.Size = new Size(183, 25);
            label6.TabIndex = 16;
            label6.Text = "Seleccione La Persona";
            // 
            // button1
            // 
            button1.Location = new Point(128, 465);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 17;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(548, 405);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 18;
            button2.Text = "Seleccionar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ClienteProyectoEditarVista
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 534);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClienteProyectoEditarVista";
            Text = "ClienteProyectoEditarVista";
            Load += ClienteProyectoEditarVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Label label6;
        private Button button1;
        private Button button2;
    }
}