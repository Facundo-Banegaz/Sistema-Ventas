using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Venta
    {
        public int Id_venta {  get; set; }
        public Cliente Cliente { get; set; }
        public Trabajador Trabajador { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo_Comprobante { get; set; }
        public string Serie { get; set; }
        public string Correlativo { get; set; }
        public decimal Iva {  get; set; }
        public string Estado { get; set; }
        public decimal Total { get; set; }
    }
}
