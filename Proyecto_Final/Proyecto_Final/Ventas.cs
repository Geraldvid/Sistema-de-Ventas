using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        //instanciar clase
        Operaciones Oope = new Operaciones();
        Articulo Oart = new Articulo();
        Venta Oven = new Venta();
        Cliente Ocli = new Cliente();
        private void btninsertar_Click(object sender, EventArgs e)
        {
            //validaciones 
            if (txt_id_venta.Text.Equals("") || txtcliente.Text.Equals("") || txtuser.Text.Equals("") || txtcompro.Text.Equals("") || txtserie.Text.Equals("") ||
                txtnum.Text.Equals("") || txtfecha.Text.Equals("") || txtimpuesto.Text.Equals("") || txtestado.Text.Equals("") ||
                txtdetalle.Text.Equals("") || txtid_art.Text.Equals("") || txtcant.Text.Equals("") || txtprecio.Text.Equals("") || txtdesc.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar todos los espacios solicitados");

            }
            else
            {
                //llamar metodo para calcular subtotal
                txtsub.Text = Oope.calcularsubtotalventa(decimal.Parse(txtprecio.Text), decimal.Parse(txtcant.Text)).ToString();

                //llamar metodo para calcular impuesto
                txttotal_impu.Text = Oope.total_impuesto_venta(double.Parse(txtsub.Text)).ToString();

                //llamar metodo para calcular descuento
                txt_t_desc.Text = Oope.total_descuento(double.Parse(txtsub.Text), double.Parse(txtdesc.Text)).ToString();
               
                //llamar metodo para calcular total
                txttotal.Text = Oope.total_venta(decimal.Parse(txtsub.Text), decimal.Parse(txttotal_impu.Text), decimal.Parse(txt_t_desc.Text)).ToString();

                //llamar metodos para agregar
                Oope.agregarventa(new Venta(int.Parse(txt_id_venta.Text), int.Parse(txtcliente.Text), int.Parse(txtuser.Text), txtcompro.Text,
                        txtserie.Text, txtnum.Text, txtfecha.Text, decimal.Parse(txtimpuesto.Text), decimal.Parse(txttotal.Text), txtestado.Text));

                Oope.agregarDetalle_venta(new Detalle_venta(int.Parse(txtdetalle.Text), int.Parse(txt_id_venta.Text), int.Parse(txtid_art.Text), decimal.Parse(txtcant.Text), decimal.Parse(txtprecio.Text), decimal.Parse(txtdesc.Text)));


                MessageBox.Show("¡Compra registrada con éxito!");

                // reestablecer la fuente de origen
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = Oope.mostrardetalle_venta();
                dataGridView2.Refresh();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal pantalla = new Principal();
            pantalla.Show();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txt_id_venta.Clear();
            txtdetalle.Clear();
            txtcliente.Clear();
            txtuser.Clear();
            txtcompro.ResetText();
            txtserie.Clear();
            txtnum.Clear();
            txtid_art.Clear();
            txtcant.Clear();
            txtprecio.Clear();
            txtfecha.ResetText();
            txt_t_desc.Clear();
            txttotal.Clear();
            txtestado.Clear();
            txtsub.Clear();
            txttotal_impu.Clear();
            txtdesc.Clear();

        }

        private void txtbuscar_art_TextChanged(object sender, EventArgs e)
        {
            //validar
            if (txtbuscar_art.Text != "")
            {
                //instanciar mendiante un objeto a los atributos y metodos
                Oart.Nombre = txtbuscar_art.Text;

                DataTable dt = new DataTable();
                dt = Oope.Buscararticulo(Oart);

                dgvart.DataSource = dt;
            }
            else
            {
                dgvart.DataSource = Oope.mostrarArticulo();
            }
        }

        private void dgvart_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtid_art.Text = dgvart.CurrentRow.Cells[0].Value.ToString();
            txtprecio.Text = dgvart.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            txtdetalle.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_id_venta.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtcliente.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txtuser.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txtcompro.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txtserie.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txtnum.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txtid_art.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txtcant.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
            txtprecio.Text = dataGridView2.CurrentRow.Cells[9].Value.ToString();
            txtfecha.Text = dataGridView2.CurrentRow.Cells[10].Value.ToString();
            txtimpuesto.Text = dataGridView2.CurrentRow.Cells[11].Value.ToString();
            txtdesc.Text = dataGridView2.CurrentRow.Cells[12].Value.ToString();
            txttotal.Text = dataGridView2.CurrentRow.Cells[13].Value.ToString();
            txtestado.Text = dataGridView2.CurrentRow.Cells[14].Value.ToString();

        }

        private void txtbuscar_venta_TextChanged(object sender, EventArgs e)
        {
            //validar
            if (txtbuscar_venta.Text != "")
            {
                //instanciar mendiante un objeto a los atributos y metodos
                Oven.num_comprobante = txtbuscar_venta.Text;

                DataTable dt = new DataTable();
                dt = Oope.Buscarventa(Oven);

                dataGridView2.DataSource = dt;
            }
            else
            {
                dataGridView2.DataSource = Oope.mostrardetalle_venta();
            }
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Oope.mostrardetalle_venta();
            dataGridView1.DataSource = Oope.mostrarCliente();
            dgvart.DataSource = Oope.mostrarArticulo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //validar
            if (textBox1.Text != "")
            {
                //instanciar mendiante un objeto a los atributos y metodos
                Ocli.nombre = textBox1.Text;

                DataTable dt = new DataTable();
                dt = Oope.BuscarCliente(Ocli);

                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = Oope.mostrarCliente();
            }
        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtcliente.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
