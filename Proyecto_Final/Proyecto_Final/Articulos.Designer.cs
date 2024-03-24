namespace Proyecto_Final
{
    partial class Articulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Articulos));
            this.tabarticulos = new System.Windows.Forms.TabControl();
            this.tclistado_art = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvart = new System.Windows.Forms.DataGridView();
            this.txtbuscar_arti = new System.Windows.Forms.TextBox();
            this.tcmante_art = new System.Windows.Forms.TabPage();
            this.btneliminar_art = new System.Windows.Forms.Button();
            this.btnmodificar_art = new System.Windows.Forms.Button();
            this.btnagregar_art = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtestado_arti = new System.Windows.Forms.TextBox();
            this.txtima_arti = new System.Windows.Forms.TextBox();
            this.txtdesc_arti = new System.Windows.Forms.TextBox();
            this.txtstock_arti = new System.Windows.Forms.TextBox();
            this.txtprecio_arti = new System.Windows.Forms.TextBox();
            this.txtnombre_arti = new System.Windows.Forms.TextBox();
            this.txtcodigo_arti = new System.Windows.Forms.TextBox();
            this.txtid_cate_arti = new System.Windows.Forms.TextBox();
            this.txtid_arti = new System.Windows.Forms.TextBox();
            this.tabarticulos.SuspendLayout();
            this.tclistado_art.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvart)).BeginInit();
            this.tcmante_art.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabarticulos
            // 
            this.tabarticulos.Controls.Add(this.tclistado_art);
            this.tabarticulos.Controls.Add(this.tcmante_art);
            this.tabarticulos.Location = new System.Drawing.Point(0, 0);
            this.tabarticulos.Name = "tabarticulos";
            this.tabarticulos.SelectedIndex = 0;
            this.tabarticulos.Size = new System.Drawing.Size(720, 412);
            this.tabarticulos.TabIndex = 1;
            // 
            // tclistado_art
            // 
            this.tclistado_art.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tclistado_art.BackgroundImage")));
            this.tclistado_art.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tclistado_art.Controls.Add(this.pictureBox1);
            this.tclistado_art.Controls.Add(this.label11);
            this.tclistado_art.Controls.Add(this.dgvart);
            this.tclistado_art.Controls.Add(this.txtbuscar_arti);
            this.tclistado_art.Location = new System.Drawing.Point(4, 22);
            this.tclistado_art.Name = "tclistado_art";
            this.tclistado_art.Padding = new System.Windows.Forms.Padding(3);
            this.tclistado_art.Size = new System.Drawing.Size(712, 386);
            this.tclistado_art.TabIndex = 0;
            this.tclistado_art.Text = "Listado";
            this.tclistado_art.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 34);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(76, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Buscar por nombre";
            // 
            // dgvart
            // 
            this.dgvart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvart.Location = new System.Drawing.Point(28, 97);
            this.dgvart.Name = "dgvart";
            this.dgvart.Size = new System.Drawing.Size(639, 245);
            this.dgvart.TabIndex = 2;
            this.dgvart.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvart_RowHeaderMouseClick);
            // 
            // txtbuscar_arti
            // 
            this.txtbuscar_arti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtbuscar_arti.Location = new System.Drawing.Point(187, 38);
            this.txtbuscar_arti.Name = "txtbuscar_arti";
            this.txtbuscar_arti.Size = new System.Drawing.Size(393, 20);
            this.txtbuscar_arti.TabIndex = 0;
            this.txtbuscar_arti.TextChanged += new System.EventHandler(this.txtbuscar_arti_TextChanged);
            // 
            // tcmante_art
            // 
            this.tcmante_art.BackColor = System.Drawing.Color.White;
            this.tcmante_art.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tcmante_art.BackgroundImage")));
            this.tcmante_art.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tcmante_art.Controls.Add(this.btneliminar_art);
            this.tcmante_art.Controls.Add(this.btnmodificar_art);
            this.tcmante_art.Controls.Add(this.btnagregar_art);
            this.tcmante_art.Controls.Add(this.label10);
            this.tcmante_art.Controls.Add(this.label7);
            this.tcmante_art.Controls.Add(this.label8);
            this.tcmante_art.Controls.Add(this.label5);
            this.tcmante_art.Controls.Add(this.label6);
            this.tcmante_art.Controls.Add(this.label3);
            this.tcmante_art.Controls.Add(this.label4);
            this.tcmante_art.Controls.Add(this.label2);
            this.tcmante_art.Controls.Add(this.label1);
            this.tcmante_art.Controls.Add(this.txtestado_arti);
            this.tcmante_art.Controls.Add(this.txtima_arti);
            this.tcmante_art.Controls.Add(this.txtdesc_arti);
            this.tcmante_art.Controls.Add(this.txtstock_arti);
            this.tcmante_art.Controls.Add(this.txtprecio_arti);
            this.tcmante_art.Controls.Add(this.txtnombre_arti);
            this.tcmante_art.Controls.Add(this.txtcodigo_arti);
            this.tcmante_art.Controls.Add(this.txtid_cate_arti);
            this.tcmante_art.Controls.Add(this.txtid_arti);
            this.tcmante_art.Location = new System.Drawing.Point(4, 22);
            this.tcmante_art.Name = "tcmante_art";
            this.tcmante_art.Padding = new System.Windows.Forms.Padding(3);
            this.tcmante_art.Size = new System.Drawing.Size(712, 386);
            this.tcmante_art.TabIndex = 1;
            this.tcmante_art.Text = "Mantenimiento";
            // 
            // btneliminar_art
            // 
            this.btneliminar_art.Location = new System.Drawing.Point(377, 353);
            this.btneliminar_art.Name = "btneliminar_art";
            this.btneliminar_art.Size = new System.Drawing.Size(75, 23);
            this.btneliminar_art.TabIndex = 21;
            this.btneliminar_art.Text = "ELIMINAR";
            this.btneliminar_art.UseVisualStyleBackColor = true;
            this.btneliminar_art.Click += new System.EventHandler(this.btneliminar_art_Click);
            // 
            // btnmodificar_art
            // 
            this.btnmodificar_art.Location = new System.Drawing.Point(261, 353);
            this.btnmodificar_art.Name = "btnmodificar_art";
            this.btnmodificar_art.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar_art.TabIndex = 20;
            this.btnmodificar_art.Text = "MODIFICAR";
            this.btnmodificar_art.UseVisualStyleBackColor = true;
            this.btnmodificar_art.Click += new System.EventHandler(this.btnmodificar_art_Click);
            // 
            // btnagregar_art
            // 
            this.btnagregar_art.Location = new System.Drawing.Point(143, 353);
            this.btnagregar_art.Name = "btnagregar_art";
            this.btnagregar_art.Size = new System.Drawing.Size(75, 23);
            this.btnagregar_art.TabIndex = 19;
            this.btnagregar_art.Text = "AGREGAR";
            this.btnagregar_art.UseVisualStyleBackColor = true;
            this.btnagregar_art.Click += new System.EventHandler(this.btnagregar_art_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(122, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Imagen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Descripción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Precio de Venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID Categoría";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Artículo";
            // 
            // txtestado_arti
            // 
            this.txtestado_arti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtestado_arti.Location = new System.Drawing.Point(256, 312);
            this.txtestado_arti.Name = "txtestado_arti";
            this.txtestado_arti.Size = new System.Drawing.Size(218, 20);
            this.txtestado_arti.TabIndex = 8;
            // 
            // txtima_arti
            // 
            this.txtima_arti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtima_arti.Location = new System.Drawing.Point(256, 275);
            this.txtima_arti.Name = "txtima_arti";
            this.txtima_arti.Size = new System.Drawing.Size(218, 20);
            this.txtima_arti.TabIndex = 7;
            // 
            // txtdesc_arti
            // 
            this.txtdesc_arti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtdesc_arti.Location = new System.Drawing.Point(256, 238);
            this.txtdesc_arti.Name = "txtdesc_arti";
            this.txtdesc_arti.Size = new System.Drawing.Size(218, 20);
            this.txtdesc_arti.TabIndex = 6;
            // 
            // txtstock_arti
            // 
            this.txtstock_arti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtstock_arti.Location = new System.Drawing.Point(256, 201);
            this.txtstock_arti.Name = "txtstock_arti";
            this.txtstock_arti.Size = new System.Drawing.Size(218, 20);
            this.txtstock_arti.TabIndex = 5;
            // 
            // txtprecio_arti
            // 
            this.txtprecio_arti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtprecio_arti.Location = new System.Drawing.Point(256, 166);
            this.txtprecio_arti.Name = "txtprecio_arti";
            this.txtprecio_arti.Size = new System.Drawing.Size(218, 20);
            this.txtprecio_arti.TabIndex = 4;
            // 
            // txtnombre_arti
            // 
            this.txtnombre_arti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtnombre_arti.Location = new System.Drawing.Point(256, 130);
            this.txtnombre_arti.Name = "txtnombre_arti";
            this.txtnombre_arti.Size = new System.Drawing.Size(218, 20);
            this.txtnombre_arti.TabIndex = 3;
            // 
            // txtcodigo_arti
            // 
            this.txtcodigo_arti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtcodigo_arti.Location = new System.Drawing.Point(256, 93);
            this.txtcodigo_arti.Name = "txtcodigo_arti";
            this.txtcodigo_arti.Size = new System.Drawing.Size(218, 20);
            this.txtcodigo_arti.TabIndex = 2;
            // 
            // txtid_cate_arti
            // 
            this.txtid_cate_arti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtid_cate_arti.Location = new System.Drawing.Point(256, 55);
            this.txtid_cate_arti.Name = "txtid_cate_arti";
            this.txtid_cate_arti.Size = new System.Drawing.Size(218, 20);
            this.txtid_cate_arti.TabIndex = 1;
            // 
            // txtid_arti
            // 
            this.txtid_arti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtid_arti.Location = new System.Drawing.Point(256, 20);
            this.txtid_arti.Name = "txtid_arti";
            this.txtid_arti.Size = new System.Drawing.Size(218, 20);
            this.txtid_arti.TabIndex = 0;
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 410);
            this.Controls.Add(this.tabarticulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Articulos_Load);
            this.tabarticulos.ResumeLayout(false);
            this.tclistado_art.ResumeLayout(false);
            this.tclistado_art.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvart)).EndInit();
            this.tcmante_art.ResumeLayout(false);
            this.tcmante_art.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabarticulos;
        private System.Windows.Forms.TabPage tclistado_art;
        private System.Windows.Forms.DataGridView dgvart;
        private System.Windows.Forms.TextBox txtbuscar_arti;
        private System.Windows.Forms.TabPage tcmante_art;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtestado_arti;
        private System.Windows.Forms.TextBox txtima_arti;
        private System.Windows.Forms.TextBox txtdesc_arti;
        private System.Windows.Forms.TextBox txtstock_arti;
        private System.Windows.Forms.TextBox txtprecio_arti;
        private System.Windows.Forms.TextBox txtnombre_arti;
        private System.Windows.Forms.TextBox txtcodigo_arti;
        private System.Windows.Forms.TextBox txtid_cate_arti;
        private System.Windows.Forms.TextBox txtid_arti;
        private System.Windows.Forms.Button btneliminar_art;
        private System.Windows.Forms.Button btnmodificar_art;
        private System.Windows.Forms.Button btnagregar_art;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
    }
}