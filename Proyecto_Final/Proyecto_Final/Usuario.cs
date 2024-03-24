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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        Operaciones Oope = new Operaciones();
        Usuarios Ouser = new Usuarios();
        private void btnagregar_user_Click(object sender, EventArgs e)
        {
            //validar campos 

            if (txtid_user.Text.Equals("") || txttipo_doc_user.Text.Equals("") || txtnom_user.Text.Equals("") || txtroluser.Text.Equals("") || txt_num_doc_user.Text.Equals("") || txtdir_user.Text.Equals("")
                || txttel_user.Text.Equals("") || txtemail_user.Text.Equals("") || txtclave_user.Text.Equals(""))
            {
                MessageBox.Show("Debe de llenar los datos solicitados");
            }
            else
            {
                Oope.agregarusuario(new Usuarios(int.Parse(txtid_user.Text), int.Parse(txtroluser.Text), txtnom_user.Text, txttipo_doc_user.Text, txt_num_doc_user.Text, 
                                                 txtdir_user.Text, txttel_user.Text, txtemail_user.Text, txtclave_user.Text, txtestado_user.Text));


                MessageBox.Show("Dato agregado correctamente");
                // reestablecer la fuente de origen
                dgvuser.DataSource = null;
                dgvuser.DataSource = Oope.mostrarusuario();
                dgvuser.Refresh();

                //limpiar los campos de texto 
                txtid_user.Clear();
                txtroluser.Clear();
                txtnom_user.Clear();
                txttipo_doc_user.Text.Equals("");
                txt_num_doc_user.Clear();
                txtdir_user.Clear();
                txttel_user.Clear();
                txtemail_user.Clear();
                txtclave_user.Clear();
                txtestado_user.Clear();

            }

        }

        private void btnmodificar_user_Click(object sender, EventArgs e)
        {
            //validar campos 

            if (txtid_user.Text.Equals("") || txttipo_doc_user.Text.Equals("") || txtnom_user.Text.Equals("") || txtroluser.Text.Equals("") || txt_num_doc_user.Text.Equals("") || txtdir_user.Text.Equals("")
                || txttel_user.Text.Equals("") || txtemail_user.Text.Equals("") || txtclave_user.Text.Equals(""))
            {
                MessageBox.Show("Debe de llenar los datos solicitados");
            }
            else
            {
                Oope.modificarusuario(new Usuarios(int.Parse(txtid_user.Text), int.Parse(txtroluser.Text), txtnom_user.Text, txttipo_doc_user.Text, txt_num_doc_user.Text, txtdir_user.Text, 
                                                   txttel_user.Text, txtemail_user.Text, txtclave_user.Text, txtestado_user.Text));


                MessageBox.Show("Dato modificado correctamente");
                // reestablecer la fuente de origen
                dgvuser.DataSource = null;
                dgvuser.DataSource = Oope.mostrarusuario();
                dgvuser.Refresh();

                //limpiar los campos de texto 
                txtid_user.Clear();
                txtroluser.Clear();
                txtnom_user.Clear();
                txttipo_doc_user.Text.Equals("");
                txt_num_doc_user.Clear();
                txtdir_user.Clear();
                txttel_user.Clear();
                txtemail_user.Clear();
                txtclave_user.Clear();
                txtestado_user.Clear();

            }

        }

        private void btneliminar_user_Click(object sender, EventArgs e)
        {
            //validar campos 

            if (txtid_user.Text.Equals("") || txttipo_doc_user.Text.Equals("") || txtnom_user.Text.Equals("") || txtroluser.Text.Equals("") || txt_num_doc_user.Text.Equals("") || txtdir_user.Text.Equals("")
                || txttel_user.Text.Equals("") || txtemail_user.Text.Equals("") || txtclave_user.Text.Equals(""))
            {
                MessageBox.Show("Debe de llenar los datos solicitados");
            }
            else
            {
                Oope.eliminarUsuario(new Usuarios(int.Parse(txtid_user.Text), int.Parse(txtroluser.Text), txtnom_user.Text, txttipo_doc_user.Text, txt_num_doc_user.Text, txtdir_user.Text, txttel_user.Text,
                    txtemail_user.Text, txtclave_user.Text, txtestado_user.Text));


                MessageBox.Show("Dato eliminado correctamente");
                // reestablecer la fuente de origen
                dgvuser.DataSource = null;
                dgvuser.DataSource = Oope.mostrarusuario();
                dgvuser.Refresh();

                //limpiar los campos de texto 
                txtid_user.Clear();
                txtroluser.Clear();
                txtnom_user.Clear();
                txttipo_doc_user.Text.Equals("");
                txt_num_doc_user.Clear();
                txtdir_user.Clear();
                txttel_user.Clear();
                txtemail_user.Clear();
                txtclave_user.Clear();
                txtestado_user.Clear();


            }

        }

        private void btnbuscar_user_Click(object sender, EventArgs e)
        {


        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            dgvuser.DataSource = Oope.mostrarusuario();
        }

        private void dgvuser_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtid_user.Text = dgvuser.CurrentRow.Cells[0].Value.ToString();
            txtroluser.Text = dgvuser.CurrentRow.Cells[1].Value.ToString();
            txtnom_user.Text = dgvuser.CurrentRow.Cells[2].Value.ToString();
            txttipo_doc_user.Text = dgvuser.CurrentRow.Cells[3].Value.ToString();
            txt_num_doc_user.Text = dgvuser.CurrentRow.Cells[4].Value.ToString();
            txtdir_user.Text = dgvuser.CurrentRow.Cells[5].Value.ToString();
            txttel_user.Text = dgvuser.CurrentRow.Cells[6].Value.ToString();
            txtemail_user.Text = dgvuser.CurrentRow.Cells[7].Value.ToString();
            txtclave_user.Text = dgvuser.CurrentRow.Cells[8].Value.ToString();
            txtestado_user.Text = dgvuser.CurrentRow.Cells[9].Value.ToString();
        }

        private void txtbuscar_user_TextChanged(object sender, EventArgs e)
        {
            //validar
            if (txtbuscar_user.Text != "")
            {
                //instanciar mendiante un objeto a los atributos y metodos
                Ouser.nombre = txtbuscar_user.Text;

                DataTable dt = new DataTable();
                dt = Oope.BuscarUsuario(Ouser);

                dgvuser.DataSource = dt;
            }
            else
            {
                dgvuser.DataSource = Oope.mostrarusuario();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 - Administrador. \n2 - Vendedor. \n3 - Almacenero");
        }

        private void txttipo_doc_user_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
