namespace Proyecto_Final
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.tabclientes = new System.Windows.Forms.TabControl();
            this.tclistado_cli = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_cli = new System.Windows.Forms.DataGridView();
            this.txtbuscar_cli = new System.Windows.Forms.TextBox();
            this.tcmante_cli = new System.Windows.Forms.TabPage();
            this.txt_tipo_doc_cli = new System.Windows.Forms.ComboBox();
            this.btneliminar_cli = new System.Windows.Forms.Button();
            this.btnmodificar_cli = new System.Windows.Forms.Button();
            this.btnagregar_cli = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemail_cli = new System.Windows.Forms.TextBox();
            this.txttel_cli = new System.Windows.Forms.TextBox();
            this.txtdir_cli = new System.Windows.Forms.TextBox();
            this.txtdoc_cli = new System.Windows.Forms.TextBox();
            this.txtnom_cli = new System.Windows.Forms.TextBox();
            this.txttipo_cli = new System.Windows.Forms.TextBox();
            this.txtid_cli = new System.Windows.Forms.TextBox();
            this.tabclientes.SuspendLayout();
            this.tclistado_cli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cli)).BeginInit();
            this.tcmante_cli.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabclientes
            // 
            this.tabclientes.Controls.Add(this.tclistado_cli);
            this.tabclientes.Controls.Add(this.tcmante_cli);
            this.tabclientes.Location = new System.Drawing.Point(-1, -1);
            this.tabclientes.Name = "tabclientes";
            this.tabclientes.SelectedIndex = 0;
            this.tabclientes.Size = new System.Drawing.Size(801, 453);
            this.tabclientes.TabIndex = 1;
            // 
            // tclistado_cli
            // 
            this.tclistado_cli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tclistado_cli.BackgroundImage")));
            this.tclistado_cli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tclistado_cli.Controls.Add(this.pictureBox1);
            this.tclistado_cli.Controls.Add(this.label4);
            this.tclistado_cli.Controls.Add(this.dgv_cli);
            this.tclistado_cli.Controls.Add(this.txtbuscar_cli);
            this.tclistado_cli.Location = new System.Drawing.Point(4, 22);
            this.tclistado_cli.Name = "tclistado_cli";
            this.tclistado_cli.Padding = new System.Windows.Forms.Padding(3);
            this.tclistado_cli.Size = new System.Drawing.Size(793, 427);
            this.tclistado_cli.TabIndex = 0;
            this.tclistado_cli.Text = "Listado";
            this.tclistado_cli.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 34);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Buscar por nombre";
            // 
            // dgv_cli
            // 
            this.dgv_cli.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgv_cli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cli.Location = new System.Drawing.Point(28, 97);
            this.dgv_cli.Name = "dgv_cli";
            this.dgv_cli.Size = new System.Drawing.Size(740, 293);
            this.dgv_cli.TabIndex = 2;
            this.dgv_cli.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cli_CellContentClick);
            this.dgv_cli.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_cli_RowHeaderMouseClick);
            // 
            // txtbuscar_cli
            // 
            this.txtbuscar_cli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtbuscar_cli.Location = new System.Drawing.Point(213, 53);
            this.txtbuscar_cli.Name = "txtbuscar_cli";
            this.txtbuscar_cli.Size = new System.Drawing.Size(541, 20);
            this.txtbuscar_cli.TabIndex = 0;
            this.txtbuscar_cli.TextChanged += new System.EventHandler(this.txtbuscar_cli_TextChanged);
            // 
            // tcmante_cli
            // 
            this.tcmante_cli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tcmante_cli.BackgroundImage")));
            this.tcmante_cli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tcmante_cli.Controls.Add(this.txt_tipo_doc_cli);
            this.tcmante_cli.Controls.Add(this.btneliminar_cli);
            this.tcmante_cli.Controls.Add(this.btnmodificar_cli);
            this.tcmante_cli.Controls.Add(this.btnagregar_cli);
            this.tcmante_cli.Controls.Add(this.label10);
            this.tcmante_cli.Controls.Add(this.label7);
            this.tcmante_cli.Controls.Add(this.label8);
            this.tcmante_cli.Controls.Add(this.label5);
            this.tcmante_cli.Controls.Add(this.label6);
            this.tcmante_cli.Controls.Add(this.label3);
            this.tcmante_cli.Controls.Add(this.label2);
            this.tcmante_cli.Controls.Add(this.label1);
            this.tcmante_cli.Controls.Add(this.txtemail_cli);
            this.tcmante_cli.Controls.Add(this.txttel_cli);
            this.tcmante_cli.Controls.Add(this.txtdir_cli);
            this.tcmante_cli.Controls.Add(this.txtdoc_cli);
            this.tcmante_cli.Controls.Add(this.txtnom_cli);
            this.tcmante_cli.Controls.Add(this.txttipo_cli);
            this.tcmante_cli.Controls.Add(this.txtid_cli);
            this.tcmante_cli.Location = new System.Drawing.Point(4, 22);
            this.tcmante_cli.Name = "tcmante_cli";
            this.tcmante_cli.Padding = new System.Windows.Forms.Padding(3);
            this.tcmante_cli.Size = new System.Drawing.Size(793, 427);
            this.tcmante_cli.TabIndex = 1;
            this.tcmante_cli.Text = "Mantenimiento";
            this.tcmante_cli.UseVisualStyleBackColor = true;
            // 
            // txt_tipo_doc_cli
            // 
            this.txt_tipo_doc_cli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_tipo_doc_cli.FormattingEnabled = true;
            this.txt_tipo_doc_cli.Items.AddRange(new object[] {
            "Cedula de identidad",
            "DIMEX",
            "Residencia"});
            this.txt_tipo_doc_cli.Location = new System.Drawing.Point(354, 141);
            this.txt_tipo_doc_cli.Name = "txt_tipo_doc_cli";
            this.txt_tipo_doc_cli.Size = new System.Drawing.Size(218, 21);
            this.txt_tipo_doc_cli.TabIndex = 43;
            // 
            // btneliminar_cli
            // 
            this.btneliminar_cli.Location = new System.Drawing.Point(475, 368);
            this.btneliminar_cli.Name = "btneliminar_cli";
            this.btneliminar_cli.Size = new System.Drawing.Size(75, 23);
            this.btneliminar_cli.TabIndex = 42;
            this.btneliminar_cli.Text = "ELIMINAR";
            this.btneliminar_cli.UseVisualStyleBackColor = true;
            this.btneliminar_cli.Click += new System.EventHandler(this.btneliminar_cli_Click);
            // 
            // btnmodificar_cli
            // 
            this.btnmodificar_cli.Location = new System.Drawing.Point(359, 368);
            this.btnmodificar_cli.Name = "btnmodificar_cli";
            this.btnmodificar_cli.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar_cli.TabIndex = 41;
            this.btnmodificar_cli.Text = "MODIFICAR";
            this.btnmodificar_cli.UseVisualStyleBackColor = true;
            this.btnmodificar_cli.Click += new System.EventHandler(this.btnmodificar_cli_Click);
            // 
            // btnagregar_cli
            // 
            this.btnagregar_cli.Location = new System.Drawing.Point(241, 368);
            this.btnagregar_cli.Name = "btnagregar_cli";
            this.btnagregar_cli.Size = new System.Drawing.Size(75, 23);
            this.btnagregar_cli.TabIndex = 40;
            this.btnagregar_cli.Text = "AGREGAR";
            this.btnagregar_cli.UseVisualStyleBackColor = true;
            this.btnagregar_cli.Click += new System.EventHandler(this.btnagregar_cli_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(220, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Télefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Número de Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tipo Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tipo Persona";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID Cliente";
            // 
            // txtemail_cli
            // 
            this.txtemail_cli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtemail_cli.Location = new System.Drawing.Point(354, 287);
            this.txtemail_cli.Name = "txtemail_cli";
            this.txtemail_cli.Size = new System.Drawing.Size(218, 20);
            this.txtemail_cli.TabIndex = 30;
            // 
            // txttel_cli
            // 
            this.txttel_cli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txttel_cli.Location = new System.Drawing.Point(354, 250);
            this.txttel_cli.Name = "txttel_cli";
            this.txttel_cli.Size = new System.Drawing.Size(218, 20);
            this.txttel_cli.TabIndex = 29;
            // 
            // txtdir_cli
            // 
            this.txtdir_cli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtdir_cli.Location = new System.Drawing.Point(354, 213);
            this.txtdir_cli.Name = "txtdir_cli";
            this.txtdir_cli.Size = new System.Drawing.Size(218, 20);
            this.txtdir_cli.TabIndex = 28;
            // 
            // txtdoc_cli
            // 
            this.txtdoc_cli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtdoc_cli.Location = new System.Drawing.Point(354, 176);
            this.txtdoc_cli.Name = "txtdoc_cli";
            this.txtdoc_cli.Size = new System.Drawing.Size(218, 20);
            this.txtdoc_cli.TabIndex = 27;
            // 
            // txtnom_cli
            // 
            this.txtnom_cli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtnom_cli.Location = new System.Drawing.Point(354, 105);
            this.txtnom_cli.Name = "txtnom_cli";
            this.txtnom_cli.Size = new System.Drawing.Size(218, 20);
            this.txtnom_cli.TabIndex = 25;
            // 
            // txttipo_cli
            // 
            this.txttipo_cli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txttipo_cli.Enabled = false;
            this.txttipo_cli.Location = new System.Drawing.Point(354, 70);
            this.txttipo_cli.Name = "txttipo_cli";
            this.txttipo_cli.Size = new System.Drawing.Size(218, 20);
            this.txttipo_cli.TabIndex = 23;
            this.txttipo_cli.Text = "Cliente";
            // 
            // txtid_cli
            // 
            this.txtid_cli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtid_cli.Location = new System.Drawing.Point(354, 35);
            this.txtid_cli.Name = "txtid_cli";
            this.txtid_cli.Size = new System.Drawing.Size(218, 20);
            this.txtid_cli.TabIndex = 22;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabclientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.tabclientes.ResumeLayout(false);
            this.tclistado_cli.ResumeLayout(false);
            this.tclistado_cli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cli)).EndInit();
            this.tcmante_cli.ResumeLayout(false);
            this.tcmante_cli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabclientes;
        private System.Windows.Forms.TabPage tclistado_cli;
        private System.Windows.Forms.TextBox txtbuscar_cli;
        private System.Windows.Forms.TabPage tcmante_cli;
        private System.Windows.Forms.Button btneliminar_cli;
        private System.Windows.Forms.Button btnmodificar_cli;
        private System.Windows.Forms.Button btnagregar_cli;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgv_cli;
        public System.Windows.Forms.TextBox txtemail_cli;
        public System.Windows.Forms.TextBox txttel_cli;
        public System.Windows.Forms.TextBox txtdir_cli;
        public System.Windows.Forms.TextBox txtdoc_cli;
        public System.Windows.Forms.TextBox txtnom_cli;
        public System.Windows.Forms.TextBox txttipo_cli;
        public System.Windows.Forms.TextBox txtid_cli;
        private System.Windows.Forms.ComboBox txt_tipo_doc_cli;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}