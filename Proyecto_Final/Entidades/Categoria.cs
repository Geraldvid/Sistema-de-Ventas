using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        //constructor vacio
        public Categoria() { }

        //constructor
        public Categoria(int id, string nombre, string descripcion, int estado)
        {
            Id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.estado = estado;
        }
        //atributos con propiedades publicos 
        public int Id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int estado { get; set; }
    }
}
