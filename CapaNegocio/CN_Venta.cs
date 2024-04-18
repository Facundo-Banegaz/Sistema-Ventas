using CapaDatos;
using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Venta
    {
        private CD_Venta _Venta;

        //Metodo para Listar los Pingresos em la DataWirdView
        public List<Venta> ListaVenta()
        {
            _Venta = new CD_Venta();

            return _Venta.ListaVenta();
        }

        public void InsertarVenta(Venta Nuevo, List<Detalle_Venta> Detalle)
        {
            _Venta = new CD_Venta();

            _Venta.InsertarVenta(Nuevo, Detalle);
        }

        //Metodo para Anular un  ingreso en la Base de Datos
        public void EliminarVenta(int Id_Venta)
        {
            _Venta = new CD_Venta();

            _Venta.EliminarVenta(Id_Venta);
        }

        public void DisminuirStock(int Id_detalle_ingreso, int Stock_Actual)
        {
            _Venta = new CD_Venta();

            _Venta.DisminuirStock( Id_detalle_ingreso,  Stock_Actual);
        }
        public List<Venta> VentaBuscarFecha(DateTime FechaInicio, DateTime FechaFin)
        {
            _Venta = new CD_Venta();

            return _Venta.VentaBuscarFecha(FechaInicio, FechaFin);
        }
    }
}
