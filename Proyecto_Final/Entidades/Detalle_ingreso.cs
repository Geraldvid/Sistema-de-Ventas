using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Detalle_ingreso
    {
        //constructor
        public Detalle_ingreso(int id_d_i, int id_ingreso, int id_articulo, decimal cantidad, decimal precio)
        {
            this.id_d_i = id_d_i;
            this.id_ingreso = id_ingreso;
            this.id_articulo = id_articulo;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        //atributos y propiedades publicas
        public int id_d_i { get; set; }
        public int id_ingreso { get; set; }
        public int id_articulo { get; set; }    
        public decimal cantidad { get; set; }
        public decimal precio { get; set; }
    }
}
