using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Proyecto_Final
{
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();
        }


        private void btnacceder_Click(object sender, EventArgs e)
        {
            //validar los compos
            if (txtuser.Text.Equals("") || txtpassword.Text.Equals(""))
            {
                //muestra un mensaje de error 
                MessageBox.Show("Debe digitar el usuario y contraseña para ingresar", "ERROR");
            }
            else
            {
                //instanciar a la cadena de concexion

                Conexion.Conectar();
                //connsultar a la tabla BD
                SqlCommand consulta = new SqlCommand("Select email, clave from usuario where email = @vusuario and clave = @vclave", Conexion.Conectar());

                // validar los datos 
                consulta.Parameters.AddWithValue("@vusuario", txtuser.Text);
                consulta.Parameters.AddWithValue("@vclave", txtpassword.Text);

                //capturar los datos de la consulta
                SqlDataReader lectura = consulta.ExecuteReader();

                //estructura condicional en caso de que los datos coincidan 

                if (lectura.Read())
                {
                    //cerrar cadena de conexion
                    Conexion.Conectar().Close();

                    // abrir el formulario principal 
                    this.Hide();
                    //ABRIR FORM PRINCIPAL 
                    Principal pantalla = new Principal();
                    pantalla.Show();

                }
                else
                {
                    MessageBox.Show("Debe digitar correctamente el usuario y contraseña");
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
