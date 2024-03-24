using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ingreso
    {
        //Construtor vacio
        public Ingreso() { }

        //constructor
        public Ingreso(int id, int id_proveedor, int id_usuario, string tipo_comprobante, string serie_comprobante, string num_comprobante, string fecha, decimal impuesto, decimal total, string estado)
        {
            this.id = id;
            this.id_proveedor = id_proveedor;
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
        public int id { get; set; }
        public int id_proveedor { get; set; }
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
