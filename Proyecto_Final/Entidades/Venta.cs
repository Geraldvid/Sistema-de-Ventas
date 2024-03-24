using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        public Venta()
        {
        }

        //constructor
        public Venta(int id_venta, int id_cliente, int id_usuario, string tipo_comprobante, string serie_comprobante, string num_comprobante, string fecha, decimal impuesto, decimal total, string estado)
        {
            this.id_venta = id_venta;
            this.id_cliente = id_cliente;
            this.id_usuario = id_usuario;
            this.tipo_comprobante = tipo_comprobante;
            this.serie_comprobante = serie_comprobante;
            this.num_comprobante = num_comprobante;
            this.fecha = fecha;
            this.impuesto = impuesto;
            this.total = total;
            this.estado = estado;
        }

        //atributos y propiedades publicas
        public int id_venta { get; set; }
        public int id_cliente { get; set; }
        public int id_usuario { get; set; }
        public string tipo_comprobante { get; set; }
        public string serie_comprobante { get; set; }
        public string num_comprobante { get; set; }
        public string fecha { get; set; }
        public decimal impuesto { get; set; }
        public decimal total { get; set; }
        public string estado { get; set; }

    }
}
