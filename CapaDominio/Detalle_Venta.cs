using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Detalle_Venta
    {
        public int Id_detalle_venta {  get; set; }
        public Venta Venta { get; set; }

        public Articulo Articulo { get; set; }
        public Detalle_Ingreso Detalle_Ingreso { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_Venta { get; set; }
        public decimal Descuento { get; set; }

        public decimal SubTotal { get; set; }

    }
}
