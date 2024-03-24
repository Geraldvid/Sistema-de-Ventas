using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //ABRIR FORM categorias 
            Categorias pantalla = new Categorias();
            pantalla.Show();

        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ABRIR FORM articulos 
            Articulos pantalla = new Articulos();
            pantalla.Show();

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ABRIR FORM proveedores
            Proveedores pantalla = new Proveedores();
            pantalla.Show();

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ABRIR FORM compras 
            Compras pantalla = new Compras();
            pantalla.Show();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ABRIR FORM clinetes
            Clientes pantalla = new Clientes();
            pantalla.Show();

        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //ABRIR FORM ventas 
            Ventas pantalla = new Ventas();
            pantalla.Show();

        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ABRIR FORM Roles
            Roles pantalla = new Roles();
            pantalla.Show();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ABRIR FORM Usuario
            Usuario pantalla = new Usuario();
            pantalla.Show();

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
