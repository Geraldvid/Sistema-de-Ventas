namespace Proyecto_Final
{
    partial class Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            this.tabproveedores = new System.Windows.Forms.TabControl();
            this.tclistado_pro = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvpro = new System.Windows.Forms.DataGridView();
            this.txtbuscar_pro = new System.Windows.Forms.TextBox();
            this.tcmante_pro = new System.Windows.Forms.TabPage();
            this.txttipo_doc_pro = new System.Windows.Forms.ComboBox();
            this.btneliminar_pro = new System.Windows.Forms.Button();
            this.btnmodificar_pro = new System.Windows.Forms.Button();
            this.btnagregar_pro = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemail_pro = new System.Windows.Forms.TextBox();
            this.txttel_pro = new System.Windows.Forms.TextBox();
            this.txtdir_pro = new System.Windows.Forms.TextBox();
            this.txtdoc_pro = new System.Windows.Forms.TextBox();
            this.txtnom_pro = new System.Windows.Forms.TextBox();
            this.txttipo_pro = new System.Windows.Forms.TextBox();
            this.txtid_pro = new System.Windows.Forms.TextBox();
            this.tabproveedores.SuspendLayout();
            this.tclistado_pro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpro)).BeginInit();
            this.tcmante_pro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabproveedores
            // 
            this.tabproveedores.Controls.Add(this.tclistado_pro);
            this.tabproveedores.Controls.Add(this.tcmante_pro);
            this.tabproveedores.Location = new System.Drawing.Point(0, 0);
            this.tabproveedores.Name = "tabproveedores";
            this.tabproveedores.SelectedIndex = 0;
            this.tabproveedores.Size = new System.Drawing.Size(798, 452);
            this.tabproveedores.TabIndex = 1;
            // 
            // tclistado_pro
            // 
            this.tclistado_pro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tclistado_pro.BackgroundImage")));
            this.tclistado_pro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tclistado_pro.Controls.Add(this.pictureBox1);
            this.tclistado_pro.Controls.Add(this.label4);
            this.tclistado_pro.Controls.Add(this.dgvpro);
            this.tclistado_pro.Controls.Add(this.txtbuscar_pro);
            this.tclistado_pro.Location = new System.Drawing.Point(4, 22);
            this.tclistado_pro.Name = "tclistado_pro";
            this.tclistado_pro.Padding = new System.Windows.Forms.Padding(3);
            this.tclistado_pro.Size = new System.Drawing.Size(790, 426);
            this.tclistado_pro.TabIndex = 0;
            this.tclistado_pro.Text = "Listado";
            this.tclistado_pro.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 34);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Buscar por nombre";
            // 
            // dgvpro
            // 
            this.dgvpro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvpro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpro.Location = new System.Drawing.Point(28, 97);
            this.dgvpro.Name = "dgvpro";
            this.dgvpro.Size = new System.Drawing.Size(740, 293);
            this.dgvpro.TabIndex = 2;
            this.dgvpro.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvpro_RowHeaderMouseClick);
            // 
            // txtbuscar_pro
            // 
            this.txtbuscar_pro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtbuscar_pro.Location = new System.Drawing.Point(208, 47);
            this.txtbuscar_pro.Name = "txtbuscar_pro";
            this.txtbuscar_pro.Size = new System.Drawing.Size(541, 20);
            this.txtbuscar_pro.TabIndex = 0;
            this.txtbuscar_pro.TextChanged += new System.EventHandler(this.txtbuscar_pro_TextChanged);
            // 
            // tcmante_pro
            // 
            this.tcmante_pro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tcmante_pro.BackgroundImage")));
            this.tcmante_pro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tcmante_pro.Controls.Add(this.txttipo_doc_pro);
            this.tcmante_pro.Controls.Add(this.btneliminar_pro);
            this.tcmante_pro.Controls.Add(this.btnmodificar_pro);
            this.tcmante_pro.Controls.Add(this.btnagregar_pro);
            this.tcmante_pro.Controls.Add(this.label10);
            this.tcmante_pro.Controls.Add(this.label7);
            this.tcmante_pro.Controls.Add(this.label8);
            this.tcmante_pro.Controls.Add(this.label5);
            this.tcmante_pro.Controls.Add(this.label6);
            this.tcmante_pro.Controls.Add(this.label3);
            this.tcmante_pro.Controls.Add(this.label2);
            this.tcmante_pro.Controls.Add(this.label1);
            this.tcmante_pro.Controls.Add(this.txtemail_pro);
            this.tcmante_pro.Controls.Add(this.txttel_pro);
            this.tcmante_pro.Controls.Add(this.txtdir_pro);
            this.tcmante_pro.Controls.Add(this.txtdoc_pro);
            this.tcmante_pro.Controls.Add(this.txtnom_pro);
            this.tcmante_pro.Controls.Add(this.txttipo_pro);
            this.tcmante_pro.Controls.Add(this.txtid_pro);
            this.tcmante_pro.Location = new System.Drawing.Point(4, 22);
            this.tcmante_pro.Name = "tcmante_pro";
            this.tcmante_pro.Padding = new System.Windows.Forms.Padding(3);
            this.tcmante_pro.Size = new System.Drawing.Size(790, 426);
            this.tcmante_pro.TabIndex = 1;
            this.tcmante_pro.Text = "Mantenimiento";
            this.tcmante_pro.UseVisualStyleBackColor = true;
            // 
            // txttipo_doc_pro
            // 
            this.txttipo_doc_pro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txttipo_doc_pro.FormattingEnabled = true;
            this.txttipo_doc_pro.Items.AddRange(new object[] {
            "Cedula de identidad",
            "DIMEX",
            "Residencia"});
            this.txttipo_doc_pro.Location = new System.Drawing.Point(353, 141);
            this.txttipo_doc_pro.Name = "txttipo_doc_pro";
            this.txttipo_doc_pro.Size = new System.Drawing.Size(218, 21);
            this.txttipo_doc_pro.TabIndex = 62;
            // 
            // btneliminar_pro
            // 
            this.btneliminar_pro.Location = new System.Drawing.Point(474, 368);
            this.btneliminar_pro.Name = "btneliminar_pro";
            this.btneliminar_pro.Size = new System.Drawing.Size(75, 23);
            this.btneliminar_pro.TabIndex = 61;
            this.btneliminar_pro.Text = "ELIMINAR";
            this.btneliminar_pro.UseVisualStyleBackColor = true;
            this.btneliminar_pro.Click += new System.EventHandler(this.btneliminar_pro_Click);
            // 
            // btnmodificar_pro
            // 
            this.btnmodificar_pro.Location = new System.Drawing.Point(358, 368);
            this.btnmodificar_pro.Name = "btnmodificar_pro";
            this.btnmodificar_pro.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar_pro.TabIndex = 60;
            this.btnmodificar_pro.Text = "MODIFICAR";
            this.btnmodificar_pro.UseVisualStyleBackColor = true;
            this.btnmodificar_pro.Click += new System.EventHandler(this.btnmodificar_pro_Click);
            // 
            // btnagregar_pro
            // 
            this.btnagregar_pro.Location = new System.Drawing.Point(240, 368);
            this.btnagregar_pro.Name = "btnagregar_pro";
            this.btnagregar_pro.Size = new System.Drawing.Size(75, 23);
            this.btnagregar_pro.TabIndex = 59;
            this.btnagregar_pro.Text = "AGREGAR";
            this.btnagregar_pro.UseVisualStyleBackColor = true;
            this.btnagregar_pro.Click += new System.EventHandler(this.btnagregar_pro_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Télefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Número de Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Tipo Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Tipo Persona";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "ID Proveedor";
            // 
            // txtemail_pro
            // 
            this.txtemail_pro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtemail_pro.Location = new System.Drawing.Point(353, 287);
            this.txtemail_pro.Name = "txtemail_pro";
            this.txtemail_pro.Size = new System.Drawing.Size(218, 20);
            this.txtemail_pro.TabIndex = 50;
            // 
            // txttel_pro
            // 
            this.txttel_pro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txttel_pro.Location = new System.Drawing.Point(353, 250);
            this.txttel_pro.Name = "txttel_pro";
            this.txttel_pro.Size = new System.Drawing.Size(218, 20);
            this.txttel_pro.TabIndex = 49;
            // 
            // txtdir_pro
            // 
            this.txtdir_pro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtdir_pro.Location = new System.Drawing.Point(353, 213);
            this.txtdir_pro.Name = "txtdir_pro";
            this.txtdir_pro.Size = new System.Drawing.Size(218, 20);
            this.txtdir_pro.TabIndex = 48;
            // 
            // txtdoc_pro
            // 
            this.txtdoc_pro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtdoc_pro.Location = new System.Drawing.Point(353, 176);
            this.txtdoc_pro.Name = "txtdoc_pro";
            this.txtdoc_pro.Size = new System.Drawing.Size(218, 20);
            this.txtdoc_pro.TabIndex = 47;
            // 
            // txtnom_pro
            // 
            this.txtnom_pro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtnom_pro.Location = new System.Drawing.Point(353, 105);
            this.txtnom_pro.Name = "txtnom_pro";
            this.txtnom_pro.Size = new System.Drawing.Size(218, 20);
            this.txtnom_pro.TabIndex = 45;
            // 
            // txttipo_pro
            // 
            this.txttipo_pro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txttipo_pro.Enabled = false;
            this.txttipo_pro.Location = new System.Drawing.Point(353, 70);
            this.txttipo_pro.Name = "txttipo_pro";
            this.txttipo_pro.Size = new System.Drawing.Size(218, 20);
            this.txttipo_pro.TabIndex = 44;
            this.txttipo_pro.Text = "Proveedor";
            // 
            // txtid_pro
            // 
            this.txtid_pro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtid_pro.Location = new System.Drawing.Point(353, 35);
            this.txtid_pro.Name = "txtid_pro";
            this.txtid_pro.Size = new System.Drawing.Size(218, 20);
            this.txtid_pro.TabIndex = 43;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabproveedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            this.tabproveedores.ResumeLayout(false);
            this.tclistado_pro.ResumeLayout(false);
            this.tclistado_pro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpro)).EndInit();
            this.tcmante_pro.ResumeLayout(false);
            this.tcmante_pro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabproveedores;
        private System.Windows.Forms.TabPage tclistado_pro;
        private System.Windows.Forms.DataGridView dgvpro;
        private System.Windows.Forms.TextBox txtbuscar_pro;
        private System.Windows.Forms.TabPage tcmante_pro;
        private System.Windows.Forms.Button btneliminar_pro;
        private System.Windows.Forms.Button btnmodificar_pro;
        private System.Windows.Forms.Button btnagregar_pro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemail_pro;
        private System.Windows.Forms.TextBox txttel_pro;
        private System.Windows.Forms.TextBox txtdir_pro;
        private System.Windows.Forms.TextBox txtdoc_pro;
        private System.Windows.Forms.TextBox txtnom_pro;
        private System.Windows.Forms.TextBox txttipo_pro;
        private System.Windows.Forms.TextBox txtid_pro;
        private System.Windows.Forms.ComboBox txttipo_doc_pro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}