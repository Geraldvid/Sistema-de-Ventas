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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        Operaciones Oope = new Operaciones();
        Cliente Ocli = new Cliente();
        private void btnagregar_cli_Click(object sender, EventArgs e)
        {

            //validar campos 

            if (txtid_cli.Text.Equals("") || txttipo_cli.Text.Equals("") || txtnom_cli.Text.Equals("") || txt_tipo_doc_cli.Text.Equals("") || txtdoc_cli.Text.Equals("") || txtdir_cli.Text.Equals("")
                || txttel_cli.Text.Equals("") || txtemail_cli.Text.Equals(""))
            {
                MessageBox.Show("Debe de llenar los datos solicitados");
            }
            else
            {
                Oope.agregarCliente(new Cliente(int.Parse(txtid_cli.Text), txttipo_cli.Text, txtnom_cli.Text, txt_tipo_doc_cli.Text, txtdoc_cli.Text, txtdir_cli.Text, txttel_cli.Text, txtemail_cli.Text));


                MessageBox.Show("Dato agregado correctamente");
                // reestablecer la fuente de origen
                dgv_cli.DataSource = null;
                dgv_cli.DataSource = Oope.mostrarCliente();
                dgv_cli.Refresh();

                //limpiar los campos de texto 
                txtid_cli.Clear();
                txtnom_cli.Clear();
                txttel_cli.Clear();
                txtdir_cli.Clear();
                txtemail_cli.Clear();
                txtdoc_cli.Clear();
                
            }
        }

        private void btnmodificar_cli_Click(object sender, EventArgs e)
        {
            if (txtid_cli.Text.Equals("") || txttipo_cli.Text.Equals("") || txtnom_cli.Text.Equals("") || txt_tipo_doc_cli.Text.Equals("") || txtdoc_cli.Text.Equals("") || txtdir_cli.Text.Equals("")
                || txttel_cli.Text.Equals("") || txtemail_cli.Text.Equals(""))
            {
                MessageBox.Show("Debe de llenar los datos solicitados");
            }
            else
            {
                Oope.actualizarCliente(new Cliente(int.Parse(txtid_cli.Text), txttipo_cli.Text, txtnom_cli.Text, txt_tipo_doc_cli.Text, txtdoc_cli.Text, txtdir_cli.Text, txttel_cli.Text, txtemail_cli.Text));


                MessageBox.Show("Dato modificado correctamente");
                // reestablecer la fuente de origen
                dgv_cli.DataSource = null;
                dgv_cli.DataSource = Oope.mostrarCliente();
                dgv_cli.Refresh();

                //limpiar los campos de texto 
                txtid_cli.Clear();
                txtnom_cli.Clear();
                txttel_cli.Clear();
                txtdir_cli.Clear();
                txtemail_cli.Clear();
                txtdoc_cli.Clear();
            }
        }

        private void btneliminar_cli_Click(object sender, EventArgs e)
        {
            if (txtid_cli.Text.Equals("") || txttipo_cli.Text.Equals("") || txtnom_cli.Text.Equals("") || txt_tipo_doc_cli.Text.Equals("") || txtdoc_cli.Text.Equals("") || txtdir_cli.Text.Equals("")
                || txttel_cli.Text.Equals("") || txtemail_cli.Text.Equals(""))
            {
                MessageBox.Show("Debe de llenar los datos solicitados");
            }
            else
            {
                Oope.eliminarCliente(new Cliente(int.Parse(txtid_cli.Text), txttipo_cli.Text, txtnom_cli.Text, txt_tipo_doc_cli.Text, txtdoc_cli.Text, txtdir_cli.Text, txttel_cli.Text, txtemail_cli.Text));


                MessageBox.Show("Dato eliminado correctamente");
                // reestablecer la fuente de origen
                dgv_cli.DataSource = null;
                dgv_cli.DataSource = Oope.mostrarCliente();
                dgv_cli.Refresh();

                //limpiar los campos de texto 
                txtid_cli.Clear();
                txtnom_cli.Clear();
                txttel_cli.Clear();
                txtdir_cli.Clear();
                txtemail_cli.Clear();
                txtdoc_cli.Clear();
            }
        }

        private void btnbuscar_cli_Click(object sender, EventArgs e)
        {

        }

        private void dgv_cli_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtid_cli.Text = dgv_cli.CurrentRow.Cells[0].Value.ToString();
            txttipo_cli.Text = dgv_cli.CurrentRow.Cells[1].Value.ToString();
            txtnom_cli.Text = dgv_cli.CurrentRow.Cells[2].Value.ToString();
            txt_tipo_doc_cli.Text = dgv_cli.CurrentRow.Cells[3].Value.ToString();
            txtdoc_cli.Text = dgv_cli.CurrentRow.Cells[4].Value.ToString();
            txtdir_cli.Text = dgv_cli.CurrentRow.Cells[5].Value.ToString();
            txttel_cli.Text = dgv_cli.CurrentRow.Cells[6].Value.ToString();         
            txtemail_cli.Text = dgv_cli.CurrentRow.Cells[7].Value.ToString();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            dgv_cli.DataSource = Oope.mostrarCliente();
        }

        private void txtbuscar_cli_TextChanged(object sender, EventArgs e)
        {
            //validar
            if (txtbuscar_cli.Text != "")
            {
                //instanciar mendiante un objeto a los atributos y metodos
                Ocli.nombre = txtbuscar_cli.Text;

                DataTable dt = new DataTable();
                dt = Oope.BuscarCliente(Ocli);

                dgv_cli.DataSource = dt;
            }
            else
            {
                dgv_cli.DataSource = Oope.mostrarCliente();
            }
        }

        private void dgv_cli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
