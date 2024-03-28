using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Detalle_ingreso
    {
        private CD_Conexion Conexion;
        private Detalle_Ingreso  _Detalle_Ingreso;
        private List<Detalle_Ingreso> listaDetalleIngreso;

        //meto listar 
        public List<Detalle_Ingreso> ListaDetalleIngreso(string txt_buscar)
        {

            //instancia

            Conexion = new CD_Conexion();

            listaDetalleIngreso = new List<Detalle_Ingreso>();

            try
            {

                Conexion.SetConsutarProcedure("SpMostrar_detalle_ingreso");

                Conexion.SetearParametro("@txt_buscar", txt_buscar);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    _Detalle_Ingreso = new Detalle_Ingreso();



                    _Detalle_Ingreso.Articulo = new Articulo();

                    _Detalle_Ingreso.Articulo.Id_articulo = (int)Conexion.Lector["Id_articulo"];
                    _Detalle_Ingreso.Articulo.Nombre = (string)Conexion.Lector["Articulo"];
                    _Detalle_Ingreso.Precio_Compra = (decimal)Conexion.Lector["Precio_compra"]; 
                    _Detalle_Ingreso.Precio_Venta = (decimal)Conexion.Lector["Precio_venta"];
                    _Detalle_Ingreso.Stock_Inicial = (int)Conexion.Lector["Stock_inicial"];
                    _Detalle_Ingreso.Fecha_Produccion = (DateTime)Conexion.Lector["Fecha_produccion"];
                    _Detalle_Ingreso.Fecha_Vencimiento = (DateTime)Conexion.Lector["Fecha_vencimiento"];
                    _Detalle_Ingreso.SubTotal = (decimal)Conexion.Lector["Subtotal"];

        


                    listaDetalleIngreso.Add(_Detalle_Ingreso);
                }

                return listaDetalleIngreso;
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

        public void InsertarDetalleIngreso(Detalle_Ingreso Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpInsertar_detalle_ingreso");

                Conexion.SetearParametro("@Id_ingreso", Nuevo.Ingreso.Id_ingreso);
                Conexion.SetearParametro("@Id_articulo", Nuevo.Articulo.Id_articulo);
                Conexion.SetearParametro("@Precio_compra", Nuevo.Precio_Compra);
                Conexion.SetearParametro("@Precio_venta", Nuevo.Precio_Venta);
                Conexion.SetearParametro("@Stock_inicial", Nuevo.Stock_Inicial);
                Conexion.SetearParametro("@Stock_actual", Nuevo.Stock_Actual); 
                Conexion.SetearParametro("@Fecha_produccion", Nuevo.Stock_Inicial.ToString("yyyy-MM-dd hh:mm:ss"));
                Conexion.SetearParametro("@Fecha_vencimiento", Nuevo.Stock_Actual.ToString("yyyy-MM-dd hh:mm:ss"));

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
