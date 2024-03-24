using Entidades;
using Negocios;
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
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        Operaciones Oope = new Operaciones();
        Categoria Ocate = new Categoria();

        private void btnagregar_art_Click(object sender, EventArgs e)
        {
            //validar campos 

            if (txtid_cate.Text.Equals("") || txtnom_cate.Text.Equals("") || txtdesc_cate.Text.Equals("") || txtest_cate.Text.Equals(""))
            {
                MessageBox.Show("Debe de llenar los datos solicitados");
            }
            else
            {
                Oope.agregarCategoria(new Categoria(int.Parse(txtid_cate.Text), txtnom_cate.Text, txtdesc_cate.Text, int.Parse(txtest_cate.Text)));


                MessageBox.Show("Dato agregado correctamente");
                // reestablecer la fuente de origen
                dgvcate.DataSource = null;
                dgvcate.DataSource = Oope.mostrarcategoria();
                dgvcate.Refresh();

                //limpiar los campos de texto 
                txtid_cate.Clear();
                txtnom_cate.Clear();
                txtdesc_cate.Clear();
                txtest_cate.Clear();
            }
        }

        private void btnmodificar_art_Click(object sender, EventArgs e)
        {
            //validar campos 

            if (txtid_cate.Text.Equals("") || txtnom_cate.Text.Equals("") || txtdesc_cate.Text.Equals("") || txtest_cate.Text.Equals(""))
            {
                MessageBox.Show("Debe de llenar los datos solicitados");
            }
            else
            {
                Oope.modificarCategoria(new Categoria(int.Parse(txtid_cate.Text), txtnom_cate.Text, txtdesc_cate.Text, int.Parse(txtest_cate.Text)));


                MessageBox.Show("Dato actualizado correctamente");
                // reestablecer la fuente de origen
                dgvcate.DataSource = null;
                dgvcate.DataSource = Oope.mostrarcategoria();
                dgvcate.Refresh();

                //limpiar los campos de texto 
                txtid_cate.Clear();
                txtnom_cate.Clear();
                txtdesc_cate.Clear();
                txtest_cate.Clear();
            }
        }

        private void btneliminar_art_Click(object sender, EventArgs e)
        {
            //validar campos 

            if (txtid_cate.Text.Equals("") || txtnom_cate.Text.Equals("") || txtdesc_cate.Text.Equals("") || txtest_cate.Text.Equals(""))
            {
                MessageBox.Show("Debe de llenar los datos solicitados");
            }
            else
            {
                Oope.eliminarcategoria(new Categoria(int.Parse(txtid_cate.Text), txtnom_cate.Text, txtdesc_cate.Text, int.Parse(txtest_cate.Text)));


                MessageBox.Show("Dato eliminado correctamente");
                // reestablecer la fuente de origen
                dgvcate.DataSource = null;
                dgvcate.DataSource = Oope.mostrarcategoria();
                dgvcate.Refresh();

                //limpiar los campos de texto 
                txtid_cate.Clear();
                txtnom_cate.Clear();
                txtdesc_cate.Clear();
                txtest_cate.Clear();
            }
        }

        private void btnbuscar_cate_Click(object sender, EventArgs e)
        {

        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            dgvcate.DataSource = Oope.mostrarcategoria();
        }

        private void dgvcate_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtid_cate.Text = dgvcate.CurrentRow.Cells[0].Value.ToString();
            txtnom_cate.Text = dgvcate.CurrentRow.Cells[1].Value.ToString();
            txtdesc_cate.Text = dgvcate.CurrentRow.Cells[2].Value.ToString();
            txtest_cate.Text = dgvcate.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtbuscarcate_TextChanged(object sender, EventArgs e)
        {
            //validar
            if (txtbuscarcate.Text != "")
            {
                //instanciar mendiante un objeto a los atributos y metodos
                Ocate.nombre = txtbuscarcate.Text;

                DataTable dt = new DataTable();
                dt = Oope.Buscarcategoria(Ocate);

                dgvcate.DataSource = dt;
            }
            else
            {
                dgvcate.DataSource = Oope.mostrarcategoria();
            }
        }
    }
}
