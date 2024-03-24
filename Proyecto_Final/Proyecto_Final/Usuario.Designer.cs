namespace Proyecto_Final
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.tclistado_user = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvuser = new System.Windows.Forms.DataGridView();
            this.txtbuscar_user = new System.Windows.Forms.TextBox();
            this.tcmante_user = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txttipo_doc_user = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtestado_user = new System.Windows.Forms.TextBox();
            this.txtclave_user = new System.Windows.Forms.TextBox();
            this.btneliminar_user = new System.Windows.Forms.Button();
            this.btnmodificar_user = new System.Windows.Forms.Button();
            this.btnagregar_user = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemail_user = new System.Windows.Forms.TextBox();
            this.txttel_user = new System.Windows.Forms.TextBox();
            this.txtdir_user = new System.Windows.Forms.TextBox();
            this.txt_num_doc_user = new System.Windows.Forms.TextBox();
            this.txtroluser = new System.Windows.Forms.TextBox();
            this.txtnom_user = new System.Windows.Forms.TextBox();
            this.txtid_user = new System.Windows.Forms.TextBox();
            this.tabcontrol1.SuspendLayout();
            this.tclistado_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).BeginInit();
            this.tcmante_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.tclistado_user);
            this.tabcontrol1.Controls.Add(this.tcmante_user);
            this.tabcontrol1.Location = new System.Drawing.Point(1, 0);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(798, 450);
            this.tabcontrol1.TabIndex = 2;
            // 
            // tclistado_user
            // 
            this.tclistado_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tclistado_user.BackgroundImage")));
            this.tclistado_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tclistado_user.Controls.Add(this.pictureBox1);
            this.tclistado_user.Controls.Add(this.label11);
            this.tclistado_user.Controls.Add(this.dgvuser);
            this.tclistado_user.Controls.Add(this.txtbuscar_user);
            this.tclistado_user.Location = new System.Drawing.Point(4, 22);
            this.tclistado_user.Name = "tclistado_user";
            this.tclistado_user.Padding = new System.Windows.Forms.Padding(3);
            this.tclistado_user.Size = new System.Drawing.Size(790, 424);
            this.tclistado_user.TabIndex = 0;
            this.tclistado_user.Text = "Listado";
            this.tclistado_user.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 34);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(96, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Buscar por nombre";
            // 
            // dgvuser
            // 
            this.dgvuser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuser.Location = new System.Drawing.Point(28, 97);
            this.dgvuser.Name = "dgvuser";
            this.dgvuser.Size = new System.Drawing.Size(740, 293);
            this.dgvuser.TabIndex = 2;
            this.dgvuser.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvuser_RowHeaderMouseClick);
            // 
            // txtbuscar_user
            // 
            this.txtbuscar_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtbuscar_user.Location = new System.Drawing.Point(212, 44);
            this.txtbuscar_user.Name = "txtbuscar_user";
            this.txtbuscar_user.Size = new System.Drawing.Size(541, 20);
            this.txtbuscar_user.TabIndex = 0;
            this.txtbuscar_user.TextChanged += new System.EventHandler(this.txtbuscar_user_TextChanged);
            // 
            // tcmante_user
            // 
            this.tcmante_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tcmante_user.BackgroundImage")));
            this.tcmante_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tcmante_user.Controls.Add(this.button1);
            this.tcmante_user.Controls.Add(this.txttipo_doc_user);
            this.tcmante_user.Controls.Add(this.label4);
            this.tcmante_user.Controls.Add(this.label9);
            this.tcmante_user.Controls.Add(this.txtestado_user);
            this.tcmante_user.Controls.Add(this.txtclave_user);
            this.tcmante_user.Controls.Add(this.btneliminar_user);
            this.tcmante_user.Controls.Add(this.btnmodificar_user);
            this.tcmante_user.Controls.Add(this.btnagregar_user);
            this.tcmante_user.Controls.Add(this.label10);
            this.tcmante_user.Controls.Add(this.label7);
            this.tcmante_user.Controls.Add(this.label8);
            this.tcmante_user.Controls.Add(this.label5);
            this.tcmante_user.Controls.Add(this.label6);
            this.tcmante_user.Controls.Add(this.label3);
            this.tcmante_user.Controls.Add(this.label2);
            this.tcmante_user.Controls.Add(this.label1);
            this.tcmante_user.Controls.Add(this.txtemail_user);
            this.tcmante_user.Controls.Add(this.txttel_user);
            this.tcmante_user.Controls.Add(this.txtdir_user);
            this.tcmante_user.Controls.Add(this.txt_num_doc_user);
            this.tcmante_user.Controls.Add(this.txtroluser);
            this.tcmante_user.Controls.Add(this.txtnom_user);
            this.tcmante_user.Controls.Add(this.txtid_user);
            this.tcmante_user.Location = new System.Drawing.Point(4, 22);
            this.tcmante_user.Name = "tcmante_user";
            this.tcmante_user.Padding = new System.Windows.Forms.Padding(3);
            this.tcmante_user.Size = new System.Drawing.Size(790, 424);
            this.tcmante_user.TabIndex = 1;
            this.tcmante_user.Text = "Mantenimiento";
            this.tcmante_user.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(582, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 26);
            this.button1.TabIndex = 67;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttipo_doc_user
            // 
            this.txttipo_doc_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txttipo_doc_user.FormattingEnabled = true;
            this.txttipo_doc_user.Items.AddRange(new object[] {
            "Cedula de identidad",
            "DIMEX",
            "Residensia"});
            this.txttipo_doc_user.Location = new System.Drawing.Point(358, 127);
            this.txttipo_doc_user.Name = "txttipo_doc_user";
            this.txttipo_doc_user.Size = new System.Drawing.Size(218, 21);
            this.txttipo_doc_user.TabIndex = 66;
            this.txttipo_doc_user.SelectedIndexChanged += new System.EventHandler(this.txttipo_doc_user_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(225, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Clave";
            // 
            // txtestado_user
            // 
            this.txtestado_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtestado_user.Location = new System.Drawing.Point(358, 341);
            this.txtestado_user.Name = "txtestado_user";
            this.txtestado_user.Size = new System.Drawing.Size(218, 20);
            this.txtestado_user.TabIndex = 63;
            // 
            // txtclave_user
            // 
            this.txtclave_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtclave_user.Location = new System.Drawing.Point(358, 304);
            this.txtclave_user.Name = "txtclave_user";
            this.txtclave_user.Size = new System.Drawing.Size(218, 20);
            this.txtclave_user.TabIndex = 62;
            // 
            // btneliminar_user
            // 
            this.btneliminar_user.Location = new System.Drawing.Point(474, 380);
            this.btneliminar_user.Name = "btneliminar_user";
            this.btneliminar_user.Size = new System.Drawing.Size(75, 23);
            this.btneliminar_user.TabIndex = 61;
            this.btneliminar_user.Text = "ELIMINAR";
            this.btneliminar_user.UseVisualStyleBackColor = true;
            this.btneliminar_user.Click += new System.EventHandler(this.btneliminar_user_Click);
            // 
            // btnmodificar_user
            // 
            this.btnmodificar_user.Location = new System.Drawing.Point(358, 380);
            this.btnmodificar_user.Name = "btnmodificar_user";
            this.btnmodificar_user.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar_user.TabIndex = 60;
            this.btnmodificar_user.Text = "MODIFICAR";
            this.btnmodificar_user.UseVisualStyleBackColor = true;
            this.btnmodificar_user.Click += new System.EventHandler(this.btnmodificar_user_Click);
            // 
            // btnagregar_user
            // 
            this.btnagregar_user.Location = new System.Drawing.Point(240, 380);
            this.btnagregar_user.Name = "btnagregar_user";
            this.btnagregar_user.Size = new System.Drawing.Size(75, 23);
            this.btnagregar_user.TabIndex = 59;
            this.btnagregar_user.Text = "AGREGAR";
            this.btnagregar_user.UseVisualStyleBackColor = true;
            this.btnagregar_user.Click += new System.EventHandler(this.btnagregar_user_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Télefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Número de Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Tipo Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "ID Usuario";
            // 
            // txtemail_user
            // 
            this.txtemail_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtemail_user.Location = new System.Drawing.Point(358, 270);
            this.txtemail_user.Name = "txtemail_user";
            this.txtemail_user.Size = new System.Drawing.Size(218, 20);
            this.txtemail_user.TabIndex = 50;
            // 
            // txttel_user
            // 
            this.txttel_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txttel_user.Location = new System.Drawing.Point(358, 233);
            this.txttel_user.Name = "txttel_user";
            this.txttel_user.Size = new System.Drawing.Size(218, 20);
            this.txttel_user.TabIndex = 49;
            // 
            // txtdir_user
            // 
            this.txtdir_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtdir_user.Location = new System.Drawing.Point(358, 196);
            this.txtdir_user.Name = "txtdir_user";
            this.txtdir_user.Size = new System.Drawing.Size(218, 20);
            this.txtdir_user.TabIndex = 48;
            // 
            // txt_num_doc_user
            // 
            this.txt_num_doc_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_num_doc_user.Location = new System.Drawing.Point(358, 159);
            this.txt_num_doc_user.Name = "txt_num_doc_user";
            this.txt_num_doc_user.Size = new System.Drawing.Size(218, 20);
            this.txt_num_doc_user.TabIndex = 47;
            // 
            // txtroluser
            // 
            this.txtroluser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtroluser.Location = new System.Drawing.Point(358, 53);
            this.txtroluser.Name = "txtroluser";
            this.txtroluser.Size = new System.Drawing.Size(218, 20);
            this.txtroluser.TabIndex = 46;
            // 
            // txtnom_user
            // 
            this.txtnom_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtnom_user.Location = new System.Drawing.Point(358, 88);
            this.txtnom_user.Name = "txtnom_user";
            this.txtnom_user.Size = new System.Drawing.Size(218, 20);
            this.txtnom_user.TabIndex = 45;
            // 
            // txtid_user
            // 
            this.txtid_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtid_user.Location = new System.Drawing.Point(358, 18);
            this.txtid_user.Name = "txtid_user";
            this.txtid_user.Size = new System.Drawing.Size(218, 20);
            this.txtid_user.TabIndex = 43;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabcontrol1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.tabcontrol1.ResumeLayout(false);
            this.tclistado_user.ResumeLayout(false);
            this.tclistado_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).EndInit();
            this.tcmante_user.ResumeLayout(false);
            this.tcmante_user.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.TabPage tclistado_user;
        private System.Windows.Forms.DataGridView dgvuser;
        private System.Windows.Forms.TextBox txtbuscar_user;
        private System.Windows.Forms.TabPage tcmante_user;
        private System.Windows.Forms.ComboBox txttipo_doc_user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtestado_user;
        private System.Windows.Forms.TextBox txtclave_user;
        private System.Windows.Forms.Button btneliminar_user;
        private System.Windows.Forms.Button btnmodificar_user;
        private System.Windows.Forms.Button btnagregar_user;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemail_user;
        private System.Windows.Forms.TextBox txttel_user;
        private System.Windows.Forms.TextBox txtdir_user;
        private System.Windows.Forms.TextBox txt_num_doc_user;
        private System.Windows.Forms.TextBox txtroluser;
        private System.Windows.Forms.TextBox txtnom_user;
        private System.Windows.Forms.TextBox txtid_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}