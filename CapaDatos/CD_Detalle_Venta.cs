using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Detalle_Venta
    {
        private CD_Conexion Conexion;
        private Detalle_Venta _Detalle_Venta;
        private List<Detalle_Venta> listaDetalleVenta;

        //meto listar 
        public List<Detalle_Venta> ListaDetalleVenta(int Id_Venta)
        {

            //instancia

            Conexion = new CD_Conexion();

            listaDetalleVenta = new List<Detalle_Venta>();

            try
            {

                Conexion.SetConsutarProcedure("SpMostrar_detalle_venta");

                Conexion.SetearParametro("@Id_venta", Id_Venta);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    _Detalle_Venta = new Detalle_Venta();


                    _Detalle_Venta.Detalle_Ingreso = new Detalle_Ingreso();

                    _Detalle_Venta.Detalle_Ingreso.Id_detalle_ingreso = (int)Conexion.Lector["Id_detalle_ingreso"];
                    _Detalle_Venta.Articulo = new Articulo();

                    _Detalle_Venta.Articulo.Nombre = (string)Conexion.Lector["Articulo"];

                    _Detalle_Venta.Cantidad = (int)Conexion.Lector["Cantidad"];
                    _Detalle_Venta.Precio_Venta = (decimal)Conexion.Lector["Precio_venta"];
                    _Detalle_Venta.Descuento = (decimal)Conexion.Lector["Descuento"];
                    _Detalle_Venta.SubTotal = (decimal)Conexion.Lector["Subtotal"];




                    listaDetalleVenta.Add(_Detalle_Venta);
                }

                return listaDetalleVenta;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConection();
            }

        }

        //metodo insertar

        public void InsertarDetalleVenta(Detalle_Venta Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpInsertar_detalle_venta");

                Conexion.SetearParametro("@Id_venta", Nuevo.Venta.Id_venta);
                Conexion.SetearParametro("@Id_detalle_venta", Nuevo.Id_detalle_venta);
                Conexion.SetearParametro("@Cantidad", Nuevo.Cantidad);
                Conexion.SetearParametro("@Precio_venta", Nuevo.Precio_Venta);
                Conexion.SetearParametro("@Descuento", Nuevo.Descuento);


                Conexion.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConection();
            }
        }

    }
}
