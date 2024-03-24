using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        public static SqlConnection Conectar()
        {

            SqlConnection con = new SqlConnection("Data Source = KIMBERLI; Initial Catalog = System; Integrated Security = true");
            con.Open();

            return con;


        }
    }
}
