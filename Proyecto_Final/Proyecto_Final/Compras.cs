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
using Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }
        //instanciar clase
        Operaciones Oope = new Operaciones();
        Articulo Oart = new Articulo();
        Ingreso Oing = new Ingreso();
        Proveedor Opro = new Proveedor();
        private void btninsertar_Click(object sender, EventArgs e)
        {
            //validaciones 
            if (txt_id_ingreso.Text.Equals("") || txtproveedor_com.Text.Equals("") || txtuser_com.Text.Equals("") || txtcompro.Text.Equals("") || txtserie.Text.Equals("") ||
                txtnum.Text.Equals("") || txtfecha.Text.Equals("") || txtimpuesto.Text.Equals("") || txtestado.Text.Equals("") ||
                txtdetalle.Text.Equals("") || txtid_art_com.Text.Equals("") || txtcant.Text.Equals("") || txtprecio.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar todos los espacios solicitados");

            }
            else
            {
                //llamar metodo para calcular subtotal
                txtsub.Text = Oope.calcularsubtotal(decimal.Parse(txtprecio.Text), decimal.Parse(txtcant.Text)).ToString();

                //llamar metodo para calcular impuesto
                txttotal_impu.Text = Oope.total_impuesto(double.Parse(txtsub.Text)).ToString();
               
                //llamar metodo para calcular total
                txttotal.Text = Oope.total(decimal.Parse(txttotal_impu.Text), decimal.Parse(txtsub.Text)).ToString();

                //llamar metodo para agregar
                Oope.agregaringreso(new Ingreso(int.Parse(txt_id_ingreso.Text), int.Parse(txtproveedor_com.Text), int.Parse(txtuser_com.Text), txtcompro.Text,
                                                           txtserie.Text, txtnum.Text, txtfecha.Text, decimal.Parse(txtimpuesto.Text), decimal.Parse(txttotal.Text),txtestado.Text));

                Oope.agregarDetalle(new Detalle_ingreso(int.Parse(txtdetalle.Text), int.Parse(txt_id_ingreso.Text), int.Parse(txtid_art_com.Text), decimal.Parse(txtcant.Text),decimal.Parse(txtprecio.Text)));


                MessageBox.Show("¡Compra registrada con éxito!");

                // reestablecer la fuente de origen
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = Oope.mostrardetalle();
                dataGridView2.Refresh();
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal pantalla = new Principal();
            pantalla.Show();

        }

        private void txtbuscar_art_com_TextChanged(object sender, EventArgs e)
        {
            //validar
            if (txtbuscar_art_com.Text != "")
            {
                //instanciar mendiante un objeto a los atributos y metodos
                Oart.Nombre = txtbuscar_art_com.Text;

                DataTable dt = new DataTable();
                dt = Oope.Buscararticulo(Oart);

                dgvart_com.DataSource = dt;
            }
            else
            {
                dgvart_com.DataSource = Oope.mostrarArticulo();
            }
        }

        private void dgvart_com_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            txtid_art_com.Text = dgvart_com.CurrentRow.Cells[0].Value.ToString();
            txtprecio.Text = dgvart_com.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtdetalle.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_id_ingreso.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtproveedor_com.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txtuser_com.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txtcompro.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txtserie.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txtnum.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txtid_art_com.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txtcant.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
            txtprecio.Text = dataGridView2.CurrentRow.Cells[9].Value.ToString();
            txtfecha.Text = dataGridView2.CurrentRow.Cells[10].Value.ToString();
            txtimpuesto.Text = dataGridView2.CurrentRow.Cells[11].Value.ToString();
            txttotal.Text = dataGridView2.CurrentRow.Cells[12].Value.ToString();
            txtestado.Text = dataGridView2.CurrentRow.Cells[13].Value.ToString();
        }

        private void txtbuscar_com_TextChanged(object sender, EventArgs e)
        {
            //validar
            if (txtbuscar_com.Text != "")
            {
                //instanciar mendiante un objeto a los atributos y metodos
                Oing.num_comprobante = txtbuscar_com.Text;

                DataTable dt = new DataTable();
                dt = Oope.Buscarcompra(Oing);

                dataGridView2.DataSource = dt;
            }
            else
            {
                dataGridView2.DataSource = Oope.mostrardetalle();
            }
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Oope.mostrardetalle();
            dgvart_com.DataSource = Oope.mostrarArticulo();
            dataGridView1.DataSource = Oope.mostrarProveedor();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtdetalle.Clear();
            txt_id_ingreso.Clear();
            txtproveedor_com.Clear();
            txtuser_com.Clear();
            txtcompro.Items.Clear();
            txtserie.Clear();
            txtnum.Clear();
            txtid_art_com.Clear();
            txtcant.Clear();
            txtprecio.Clear();
            txtfecha.ResetText();
            txtsub.Clear();
            txttotal.Clear();
            txtestado.Clear();
            txttotal_impu.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtproveedor_com.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //validar
            if (textBox1.Text != "")
            {
                //instanciar mendiante un objeto a los atributos y metodos
                Opro.nombre = textBox1.Text;

                DataTable dt = new DataTable();
                dt = Oope.BuscarProveedor(Opro);

                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = Oope.mostrarProveedor();
            }
        }
    }
}
