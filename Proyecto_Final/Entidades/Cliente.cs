using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {

        //constructor vacío
        public Cliente() { }

        //Constructor
        public Cliente(int id, string tipo_persona, string nombre, string tipo_doc, string doc, string dir, string tel, string email)
        {
            this.id = id;
            this.tipo_persona = tipo_persona;
            this.nombre = nombre;
            this.tipo_doc = tipo_doc;
            this.doc = doc;
            this.dir = dir;
            this.tel = tel;
            this.email = email;
        }
        //atributos con propiedades publicas
        public int id { get; set; }
        public string tipo_persona { get; set; }
        public string nombre { get; set; }
        public string tipo_doc { get; set; }
        public string doc { get; set; }
        public string dir { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
    }
}
