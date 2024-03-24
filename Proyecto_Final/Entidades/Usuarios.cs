using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios 
    {

        //constructor vacpio
        public Usuarios() { }

        //Constructor
        public Usuarios(int id, int id_rol, string nombre, string t_doc,string doc,  string dir, string tel, string email, string clave, string estado) 
        {
            this.id = id;
            this.id_rol = id_rol;
            this.nombre = nombre;
            this.t_doc = t_doc;
            this.doc = doc;
            this.dir = dir;
            this.tel = tel;
            this.email = email;
            this.clave = clave;
            this.estado = estado;
         }

        //declarar atributos con propiedades publicas
        public int id { get; set; }
        public int id_rol { get; set; }
        public string nombre { get; set; }
        public string t_doc { get; set; }
        public string doc { get; set; }
        public string dir { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public string clave { get; set; }
        public string estado { get; set; }

    }
}
