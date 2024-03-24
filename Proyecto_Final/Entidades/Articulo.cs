using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    

    public class Articulo
    {
        //atributos
        private int id_articulo;
        private int id_categoria;
        private string codigo;
        private string nombre;
        private decimal precio_venta;
        private int stock;
        private string descripcion;
        private string imagen;
        private string estado;


        //constructor vacio
         public Articulo() 
            { }

        //constructor
        public Articulo(int id_articulo, int id_categoria, string codigo, string nombre, decimal precio_venta, int stock, string descripcion, string imagen, string estado)
        {
            this.id_articulo = id_articulo;
            this.id_categoria = id_categoria;
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio_venta = precio_venta;
            this.stock = stock;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.estado = estado;
        }

        //propiedades publicas
        public int Id_articulo { get => id_articulo; set => id_articulo = value; }
        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio_venta { get => precio_venta; set => precio_venta = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
