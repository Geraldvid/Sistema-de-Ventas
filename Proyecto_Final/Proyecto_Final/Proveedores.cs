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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        Operaciones Oope = new Operaciones();
        Proveedor Opro = new Proveedor();

        private void btnagregar_pro_Click(object sender, EventArgs e)
        {
            //validar campos 

            if (txtid_pro.Text.Equals("") || txttipo_pro.Text.Equals("") || txtnom_pro.Text.Equals("") || txttipo_doc_pro.Text.Equals("") || txtdoc_pro.Text.Equals("") || txtdir_pro.Text.Equals("")
                || txttel_pro.Text.Equals("") || txtemail_pro.Text.Equals(""))
            {
                MessageBox.Show("Debe de llenar los datos solicitados");
            }
            else
            {
                Oope.agregarProveedor(new Proveedor(int.Parse(txtid_pro.Text), txttipo_pro.Text, txtnom_pro.Text, txttipo_doc_pro.Text, txtdoc_pro.Text, txtdir_pro.Text, txttel_pro.Text, txtemail_pro.Text));


                MessageBox.Show("Dato agregado correctamente");
                // reestablecer la fuente de origen
                dgvpro.DataSource = null;
                dgvpro.DataSource = Oope.mostrarProveedor();
                dgvpro.Refresh();

                //limpiar los campos de texto 
                txtid_pro.Clear();
                txtnom_pro.Clear();
                txttel_pro.Clear();
                txtdir_pro.Clear();
                txtemail_pro.Clear();
                txtdoc_pro.Clear();

            }
        }

        private void btnmodificar_pro_Click(object sender, EventArgs e)
        {
            if (txtid_pro.Text.Equals("") || txttipo_pro.Text.Equals("") || txtnom_pro.Text.Equals("") || txttipo_doc_pro.Text.Equals("") || txtdoc_pro.Text.Equals("") || txtdir_pro.Text.Equals("")
                || txttel_pro.Text.Equals("") || txtemail_pro.Text.Equals(""))
            {
                MessageBox.Show("Debe de llenar los datos solicitados");
            }
            else
            {
                Oope.actualizarCliente(new Cliente(int.Parse(txtid_pro.Text), txttipo_pro.Text, txtnom_pro.Text, txttipo_doc_pro.Text, txtdoc_pro.Text, txtdir_pro.Text, txttel_pro.Text, txtemail_pro.Text));


                MessageBox.Show("Dato modificado correctamente");
                // reestablecer la fuente de origen
                dgvpro.DataSource = null;
                dgvpro.DataSource = Oope.mostrarProveedor();
                dgvpro.Refresh();

                //limpiar los campos de texto 
                txtid_pro.Clear();
                txtnom_pro.Clear();
                txttel_pro.Clear();
                txtdir_pro.Clear();
                txtemail_pro.Clear();
                txtdoc_pro.Clear();
            }
        }

        private void btneliminar_pro_Click(object sender, EventArgs e)
        {
            if (txtid_pro.Text.Equals("") || txttipo_pro.Text.Equals("") || txtnom_pro.Text.Equals("") || txttipo_doc_pro.Text.Equals("") || txtdoc_pro.Text.Equals("") || txtdir_pro.Text.Equals("")
               || txttel_pro.Text.Equals("") || txtemail_pro.Text.Equals(""))
            {
                MessageBox.Show("Debe de llenar los datos solicitados");
            }
            else
            {
                Oope.eliminarCliente(new Cliente(int.Parse(txtid_pro.Text), txttipo_pro.Text, txtnom_pro.Text, txttipo_doc_pro.Text, txtdoc_pro.Text, txtdir_pro.Text, txttel_pro.Text, txtemail_pro.Text));


                MessageBox.Show("Dato eliminado correctamente");
                // reestablecer la fuente de origen
                dgvpro.DataSource = null;
                dgvpro.DataSource = Oope.mostrarProveedor();
                dgvpro.Refresh();

                //limpiar los campos de texto 
                txtid_pro.Clear();
                txtnom_pro.Clear();
                txttel_pro.Clear();
                txtdir_pro.Clear();
                txtemail_pro.Clear();
                txtdoc_pro.Clear();
            }
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            dgvpro.DataSource = Oope.mostrarProveedor();
        }

        private void btnbuscar_pro_Click(object sender, EventArgs e)
        {

        }

        private void dgvpro_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtid_pro.Text = dgvpro.CurrentRow.Cells[0].Value.ToString();
            txttipo_pro.Text = dgvpro.CurrentRow.Cells[1].Value.ToString();
            txtnom_pro.Text = dgvpro.CurrentRow.Cells[2].Value.ToString();
            txttipo_doc_pro.Text = dgvpro.CurrentRow.Cells[3].Value.ToString();
            txtdoc_pro.Text = dgvpro.CurrentRow.Cells[4].Value.ToString();
            txtdir_pro.Text = dgvpro.CurrentRow.Cells[5].Value.ToString();
            txttel_pro.Text = dgvpro.CurrentRow.Cells[6].Value.ToString();
            txtemail_pro.Text = dgvpro.CurrentRow.Cells[7].Value.ToString();

        }

        private void txtbuscar_pro_TextChanged(object sender, EventArgs e)
        {
            //validar
            if (txtbuscar_pro.Text != "")
            {
                //instanciar mendiante un objeto a los atributos y metodos
                Opro.nombre = txtbuscar_pro.Text;

                DataTable dt = new DataTable();
                dt = Oope.BuscarProveedor(Opro);

                dgvpro.DataSource = dt;
            }
            else
            {
                dgvpro.DataSource = Oope.mostrarProveedor();
            }
        }
    }
}
