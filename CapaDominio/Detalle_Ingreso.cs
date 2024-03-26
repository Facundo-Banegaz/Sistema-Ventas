using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDominio
{
    public class Detalle_Ingreso
    {
        //Variables
        public int Id_detalle_ingreso {  get; set; }
        public Ingreso Ingreso { get; set; }
        public Articulo Articulo { get; set; }
        public decimal Precio_Compra {  get; set; }
        public decimal Precio_Venta {  get; set; }
        public int Stock_Inicial { get; set; }
        public int Stock_Actual { get; set; }
        public DateTime Fecha_Produccion { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }

    }
}
