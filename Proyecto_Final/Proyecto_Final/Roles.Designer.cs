namespace Proyecto_Final
{
    partial class Roles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roles));
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.tcmante = new System.Windows.Forms.TabPage();
            this.dgvroles = new System.Windows.Forms.DataGridView();
            this.tabcontrol1.SuspendLayout();
            this.tcmante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvroles)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.tcmante);
            this.tabcontrol1.Location = new System.Drawing.Point(1, -1);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(798, 452);
            this.tabcontrol1.TabIndex = 2;
            // 
            // tcmante
            // 
            this.tcmante.Controls.Add(this.dgvroles);
            this.tcmante.Location = new System.Drawing.Point(4, 22);
            this.tcmante.Name = "tcmante";
            this.tcmante.Padding = new System.Windows.Forms.Padding(3);
            this.tcmante.Size = new System.Drawing.Size(790, 426);
            this.tcmante.TabIndex = 1;
            this.tcmante.Text = "Listado";
            this.tcmante.UseVisualStyleBackColor = true;
            // 
            // dgvroles
            // 
            this.dgvroles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvroles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvroles.Location = new System.Drawing.Point(8, 6);
            this.dgvroles.Name = "dgvroles";
            this.dgvroles.Size = new System.Drawing.Size(371, 150);
            this.dgvroles.TabIndex = 0;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 185);
            this.Controls.Add(this.tabcontrol1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Roles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.Roles_Load);
            this.tabcontrol1.ResumeLayout(false);
            this.tcmante.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvroles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.TabPage tcmante;
        private System.Windows.Forms.DataGridView dgvroles;
    }
}