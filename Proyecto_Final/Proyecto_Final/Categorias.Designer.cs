namespace Proyecto_Final
{
    partial class Categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorias));
            this.tabcategoria = new System.Windows.Forms.TabControl();
            this.tclistado = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvcate = new System.Windows.Forms.DataGridView();
            this.txtbuscarcate = new System.Windows.Forms.TextBox();
            this.tcmante = new System.Windows.Forms.TabPage();
            this.btneliminar_art = new System.Windows.Forms.Button();
            this.btnmodificar_art = new System.Windows.Forms.Button();
            this.btnagregar_art = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtest_cate = new System.Windows.Forms.TextBox();
            this.txtdesc_cate = new System.Windows.Forms.TextBox();
            this.txtnom_cate = new System.Windows.Forms.TextBox();
            this.txtid_cate = new System.Windows.Forms.TextBox();
            this.tabcategoria.SuspendLayout();
            this.tclistado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcate)).BeginInit();
            this.tcmante.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcategoria
            // 
            this.tabcategoria.Controls.Add(this.tclistado);
            this.tabcategoria.Controls.Add(this.tcmante);
            this.tabcategoria.Location = new System.Drawing.Point(0, 0);
            this.tabcategoria.Name = "tabcategoria";
            this.tabcategoria.SelectedIndex = 0;
            this.tabcategoria.Size = new System.Drawing.Size(679, 401);
            this.tabcategoria.TabIndex = 0;
            // 
            // tclistado
            // 
            this.tclistado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tclistado.BackgroundImage")));
            this.tclistado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tclistado.Controls.Add(this.pictureBox1);
            this.tclistado.Controls.Add(this.label11);
            this.tclistado.Controls.Add(this.dgvcate);
            this.tclistado.Controls.Add(this.txtbuscarcate);
            this.tclistado.Location = new System.Drawing.Point(4, 22);
            this.tclistado.Name = "tclistado";
            this.tclistado.Padding = new System.Windows.Forms.Padding(3);
            this.tclistado.Size = new System.Drawing.Size(671, 375);
            this.tclistado.TabIndex = 0;
            this.tclistado.Text = "Listado";
            this.tclistado.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 34);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(67, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Buscar por nombre";
            // 
            // dgvcate
            // 
            this.dgvcate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvcate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcate.Location = new System.Drawing.Point(28, 97);
            this.dgvcate.Name = "dgvcate";
            this.dgvcate.Size = new System.Drawing.Size(585, 204);
            this.dgvcate.TabIndex = 2;
            this.dgvcate.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvcate_RowHeaderMouseClick);
            // 
            // txtbuscarcate
            // 
            this.txtbuscarcate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtbuscarcate.Location = new System.Drawing.Point(169, 52);
            this.txtbuscarcate.Name = "txtbuscarcate";
            this.txtbuscarcate.Size = new System.Drawing.Size(444, 20);
            this.txtbuscarcate.TabIndex = 0;
            this.txtbuscarcate.TextChanged += new System.EventHandler(this.txtbuscarcate_TextChanged);
            // 
            // tcmante
            // 
            this.tcmante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tcmante.BackgroundImage")));
            this.tcmante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tcmante.Controls.Add(this.btneliminar_art);
            this.tcmante.Controls.Add(this.btnmodificar_art);
            this.tcmante.Controls.Add(this.btnagregar_art);
            this.tcmante.Controls.Add(this.label10);
            this.tcmante.Controls.Add(this.label8);
            this.tcmante.Controls.Add(this.label3);
            this.tcmante.Controls.Add(this.label2);
            this.tcmante.Controls.Add(this.txtest_cate);
            this.tcmante.Controls.Add(this.txtdesc_cate);
            this.tcmante.Controls.Add(this.txtnom_cate);
            this.tcmante.Controls.Add(this.txtid_cate);
            this.tcmante.Location = new System.Drawing.Point(4, 22);
            this.tcmante.Name = "tcmante";
            this.tcmante.Padding = new System.Windows.Forms.Padding(3);
            this.tcmante.Size = new System.Drawing.Size(671, 375);
            this.tcmante.TabIndex = 1;
            this.tcmante.Text = "Mantenimiento";
            this.tcmante.UseVisualStyleBackColor = true;
            // 
            // btneliminar_art
            // 
            this.btneliminar_art.Location = new System.Drawing.Point(412, 282);
            this.btneliminar_art.Name = "btneliminar_art";
            this.btneliminar_art.Size = new System.Drawing.Size(75, 23);
            this.btneliminar_art.TabIndex = 42;
            this.btneliminar_art.Text = "ELIMINAR";
            this.btneliminar_art.UseVisualStyleBackColor = true;
            this.btneliminar_art.Click += new System.EventHandler(this.btneliminar_art_Click);
            // 
            // btnmodificar_art
            // 
            this.btnmodificar_art.Location = new System.Drawing.Point(296, 282);
            this.btnmodificar_art.Name = "btnmodificar_art";
            this.btnmodificar_art.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar_art.TabIndex = 41;
            this.btnmodificar_art.Text = "MODIFICAR";
            this.btnmodificar_art.UseVisualStyleBackColor = true;
            this.btnmodificar_art.Click += new System.EventHandler(this.btnmodificar_art_Click);
            // 
            // btnagregar_art
            // 
            this.btnagregar_art.Location = new System.Drawing.Point(178, 282);
            this.btnagregar_art.Name = "btnagregar_art";
            this.btnagregar_art.Size = new System.Drawing.Size(75, 23);
            this.btnagregar_art.TabIndex = 40;
            this.btnagregar_art.Text = "AGREGAR";
            this.btnagregar_art.UseVisualStyleBackColor = true;
            this.btnagregar_art.Click += new System.EventHandler(this.btnagregar_art_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(159, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "ID Categoría";
            // 
            // txtest_cate
            // 
            this.txtest_cate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtest_cate.Location = new System.Drawing.Point(293, 195);
            this.txtest_cate.Name = "txtest_cate";
            this.txtest_cate.Size = new System.Drawing.Size(218, 20);
            this.txtest_cate.TabIndex = 30;
            // 
            // txtdesc_cate
            // 
            this.txtdesc_cate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtdesc_cate.Location = new System.Drawing.Point(293, 143);
            this.txtdesc_cate.Name = "txtdesc_cate";
            this.txtdesc_cate.Size = new System.Drawing.Size(218, 20);
            this.txtdesc_cate.TabIndex = 28;
            // 
            // txtnom_cate
            // 
            this.txtnom_cate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtnom_cate.Location = new System.Drawing.Point(293, 94);
            this.txtnom_cate.Name = "txtnom_cate";
            this.txtnom_cate.Size = new System.Drawing.Size(218, 20);
            this.txtnom_cate.TabIndex = 25;
            // 
            // txtid_cate
            // 
            this.txtid_cate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtid_cate.Location = new System.Drawing.Point(293, 44);
            this.txtid_cate.Name = "txtid_cate";
            this.txtid_cate.Size = new System.Drawing.Size(218, 20);
            this.txtid_cate.TabIndex = 23;
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 403);
            this.Controls.Add(this.tabcategoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Categorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.Categorias_Load);
            this.tabcategoria.ResumeLayout(false);
            this.tclistado.ResumeLayout(false);
            this.tclistado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcate)).EndInit();
            this.tcmante.ResumeLayout(false);
            this.tcmante.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcategoria;
        private System.Windows.Forms.TabPage tclistado;
        private System.Windows.Forms.TabPage tcmante;
        private System.Windows.Forms.DataGridView dgvcate;
        private System.Windows.Forms.TextBox txtbuscarcate;
        private System.Windows.Forms.Button btneliminar_art;
        private System.Windows.Forms.Button btnmodificar_art;
        private System.Windows.Forms.Button btnagregar_art;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtest_cate;
        private System.Windows.Forms.TextBox txtdesc_cate;
        private System.Windows.Forms.TextBox txtnom_cate;
        private System.Windows.Forms.TextBox txtid_cate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
    }
}