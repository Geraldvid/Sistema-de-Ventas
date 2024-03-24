using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Detalle_venta
    {
     //constructor
     
        public Detalle_venta(int id_d_v, int id_venta, int id_articulo, decimal cantidad, decimal precio, decimal descuento)
        {
            this.id_d_v = id_d_v;
            this.id_venta = id_venta;
            this.id_articulo = id_articulo;
            this.cantidad = cantidad;
            this.precio = precio;
            this.descuento = descuento;
        }

        //atributos y propiedades publicas
        public int id_d_v { get; set; }
        public int id_venta { get; set; }
        public int id_articulo { get; set; }
        public decimal cantidad { get; set; }
        public decimal precio { get; set; }
        public decimal descuento { get; set; }

    }
}
