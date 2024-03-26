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
