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
    public partial class Articulos : Form
    {
        public Articulos()
        {
            InitializeComponent();
        }

        Operaciones Oope = new Operaciones();
        Articulo Oart = new Articulo(); 

        private void btnagregar_art_Click(object sender, EventArgs e)
        {
            //validar campos 

            if (txtid_arti.Text.Equals("") || txtid_cate_arti.Text.Equals("") || txtnombre_arti.Text.Equals("") || txtcodigo_arti.Text.Equals("") || txtdesc_arti.Text.Equals("") || txtestado_arti.Text.Equals("")
                || txtprecio_arti.Text.Equals("") || txtstock_arti.Text.Equals("") || txtima_arti.Text.Equals(""))
            {
                MessageBox.Show("Debe de llenar los datos solicitados");
            }
            else
            {
                Oope.agregarArticulo(new Articulo(int.Parse(txtid_arti.Text), int.Parse(txtid_cate_arti.Text), txtcodigo_arti.Text, txtnombre_arti.Text, decimal.Parse(txtprecio_arti.Text),
                    int.Parse(txtstock_arti.Text), txtdesc_arti.Text, txtima_arti.Text, txtestado_arti.Text));


                MessageBox.Show("Dato agregado correctamente");
                // reestablecer la fuente de origen
                dgvart.DataSource = null;
                dgvart.DataSource = Oope.mostrarArticulo();
                dgvart.Refresh();

                //limpiar los campos de texto 
                txtid_arti.Clear();
                txtid_cate_arti.Clear();
                txtcodigo_arti.Clear();
                txtnombre_arti.Clear();
                txtprecio_arti.Clear();
                txtstock_arti.Clear();
                txtdesc_arti.Clear();
                txtima_arti.Clear();
                txtestado_arti.Clear();
            }
        }

        private void btnmodificar_art_Click(object sender, EventArgs e)
        {
            //validar campos 

            if (txtid_arti.Text.Equals("") || txtid_cate_arti.Text.Equals("") || txtnombre_arti.Text.Equals("") || txtcodigo_arti.Text.Equals("") || txtdesc_arti.Text.Equals("") || txtestado_arti.Text.Equals("")
                || txtprecio_arti.Text.Equals("") || txtstock_arti.Text.Equals("") || txtima_arti.Text.Equals(""))
            {
                MessageBox.Show("Debe de llenar los datos solicitados");
            }
            else
            {
                Oope.actualizarArticulo(new Articulo(int.Parse(txtid_arti.Text), int.Parse(txtid_cate_arti.Text), txtcodigo_arti.Text, txtnombre_arti.Text, decimal.Parse(txtprecio_arti.Text),
                    int.Parse(txtstock_arti.Text), txtdesc_arti.Text, txtima_arti.Text, txtestado_arti.Text));


                MessageBox.Show("Dato actualizado correctamente");
                // reestablecer la fuente de origen
                dgvart.DataSource = null;
                dgvart.DataSource = Oope.mostrarArticulo();
                dgvart.Refresh();

                //limpiar los campos de texto 
                txtid_arti.Clear();
                txtid_cate_arti.Clear();
                txtcodigo_arti.Clear();
                txtnombre_arti.Clear();
                txtprecio_arti.Clear();
                txtstock_arti.Clear();
                txtdesc_arti.Clear();
                txtima_arti.Clear();
                txtestado_arti.Clear();
            }
        }

        private void btneliminar_art_Click(object sender, EventArgs e)
        {
            if (txtid_arti.Text.Equals("") || txtid_cate_arti.Text.Equals("") || txtnombre_arti.Text.Equals("") || txtcodigo_arti.Text.Equals("") || txtdesc_arti.Text.Equals("") || txtestado_arti.Text.Equals("")
                || txtprecio_arti.Text.Equals("") || txtstock_arti.Text.Equals("") || txtima_arti.Text.Equals(""))
            {
                MessageBox.Show("Debe de llenar los datos solicitados");
            }
            else
            {
                Oope.eliminarArticulo(new Articulo(int.Parse(txtid_arti.Text), int.Parse(txtid_cate_arti.Text), txtcodigo_arti.Text, txtnombre_arti.Text, decimal.Parse(txtprecio_arti.Text),
                    int.Parse(txtstock_arti.Text), txtdesc_arti.Text, txtima_arti.Text, txtestado_arti.Text));


                MessageBox.Show("Dato eliminado correctamente");
                // reestablecer la fuente de origen
                dgvart.DataSource = null;
                dgvart.DataSource = Oope.mostrarArticulo();
                dgvart.Refresh();

                //limpiar los campos de texto 
                txtid_arti.Clear();
                txtid_cate_arti.Clear();
                txtcodigo_arti.Clear();
                txtnombre_arti.Clear();
                txtprecio_arti.Clear();
                txtstock_arti.Clear();
                txtdesc_arti.Clear();
                txtima_arti.Clear();
                txtestado_arti.Clear();
            }
        }

        private void btnbuscar_arti_Click(object sender, EventArgs e)
        {

        }

        private void Articulos_Load(object sender, EventArgs e)
        {
            dgvart.DataSource = Oope.mostrarArticulo();
        }

        private void dgvart_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            txtid_arti.Text = dgvart.CurrentRow.Cells[0].Value.ToString();
            txtid_cate_arti.Text = dgvart.CurrentRow.Cells[1].Value.ToString();
            txtcodigo_arti.Text = dgvart.CurrentRow.Cells[2].Value.ToString();
            txtnombre_arti.Text = dgvart.CurrentRow.Cells[3].Value.ToString();
            txtprecio_arti.Text = dgvart.CurrentRow.Cells[4].Value.ToString();
            txtstock_arti.Text = dgvart.CurrentRow.Cells[5].Value.ToString();
            txtdesc_arti.Text = dgvart.CurrentRow.Cells[6].Value.ToString();
            txtima_arti.Text = dgvart.CurrentRow.Cells[7].Value.ToString();
            txtestado_arti.Text = dgvart.CurrentRow.Cells[8].Value.ToString();
        }

        private void txtbuscar_arti_TextChanged(object sender, EventArgs e)
        {

            //validar
            if (txtbuscar_arti.Text != "")
            {
                //instanciar mendiante un objeto a los atributos y metodos
                Oart.Nombre = txtbuscar_arti.Text;

                DataTable dt = new DataTable();
                dt = Oope.Buscararticulo(Oart);

                dgvart.DataSource = dt;
            }
            else
            {
                dgvart.DataSource = Oope.mostrarArticulo();
            }
        }
    }
}
