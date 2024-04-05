using CapaDatos;
using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Detalle_Venta
    {
        private CD_Detalle_Venta Detalle_Venta;


        public List<Detalle_Venta> ListaDetalleVenta(int Id_Venta)
        {
            Detalle_Venta = new CD_Detalle_Venta();   

            return Detalle_Venta.ListaDetalleVenta(Id_Venta);
        }
    }
}
