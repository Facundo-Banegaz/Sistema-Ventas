using CapaDominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Venta
    {

        private CD_Conexion Conexion;
        private Venta _Venta;
        private List<Venta> listaVenta;


        public List<Venta> ListaVenta()
        {

            //instancia

            Conexion = new CD_Conexion();

            listaVenta = new List<Venta>();

            try
            {

                Conexion.SetConsutarProcedure("SpMostrar_venta");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    _Venta = new Venta();


                    _Venta.Id_venta = (int)Conexion.Lector["Id_venta"];

                    _Venta.Trabajador = new Trabajador();
                    _Venta.Trabajador.Nombre = (string)Conexion.Lector["Trabajador"];

                    _Venta.Cliente = new Cliente();
                    _Venta.Cliente.Nombre= (string)Conexion.Lector["Cliente"];

                    _Venta.Fecha = (DateTime)Conexion.Lector["Fecha"];
                    _Venta.Tipo_Comprobante = (string)Conexion.Lector["Tipo_comprobante"];
                    _Venta.Serie = (string)Conexion.Lector["Serie"];
                    _Venta.Correlativo = (string)Conexion.Lector["Correlativo"];
                    _Venta.Iva = (decimal)Conexion.Lector["Iva"];
                    _Venta.Estado = (string)Conexion.Lector["Estado"];
                    _Venta.Total = (decimal)Conexion.Lector["Total"];


                    listaVenta.Add(_Venta);
                }

                return listaVenta;
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


        public void InsertarVenta(Venta Nuevo, List<Detalle_Venta> DetalleVenta)
        {
            Conexion = new CD_Conexion();

            try
            {
                //Conexion.IniciarTransaccion();

                Conexion.SetConsutarProcedure("SpInsertar_Venta");

                Conexion.SetearParametro("@Id_trabajador", Nuevo.Trabajador.Id_trabajador);
                Conexion.SetearParametro("@Id_cliente", Nuevo.Cliente.Id_cliente);
                Conexion.SetearParametro("@Fecha", Nuevo.Fecha.ToString("yyyy-MM-dd hh:mm:ss"));
                Conexion.SetearParametro("@Tipo_comprobante", Nuevo.Tipo_Comprobante);
                Conexion.SetearParametro("@Serie", Nuevo.Serie);
                Conexion.SetearParametro("@Correlativo", Nuevo.Correlativo);
                Conexion.SetearParametro("@Iva", Nuevo.Iva);
                Conexion.SetearParametro("@Estado", Nuevo.Estado);



                // Configurar el parámetro de salida para el ID de ingreso

                Conexion.SetearParametroSalida("@Id_venta", SqlDbType.Int);

                Conexion.EjecutarAccion();


                // Capturar el ID del ingreso insertado
                int Id_venta = Conexion.ObtenerValorParametroSalida("@Id_venta");




                CD_Detalle_Venta _Detalle_Venta = new CD_Detalle_Venta();

                // Insertar detalles de ingreso
                foreach (Detalle_Venta detalle in DetalleVenta)
                {
                    detalle.Venta.Id_venta = Id_venta; // Suponiendo que tienes un método para obtener el último ID de ingreso insertado



                    _Detalle_Venta.InsertarDetalleVenta(detalle);
                }



                //Conexion.ConfirmarTransaccion();


            }
            catch (Exception ex)
            {
                Conexion.AnularTransaccion();
                throw ex;
            }
            finally
            {
                Conexion.CerrarConection();
            }
        }



        //Metodo eliminar
        public void EliminarVenta(int Id_venta)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEliminar_venta");

                Conexion.SetearParametro("@Id_venta", Id_venta);


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

        //Metodo Buscar

        public List<Venta> VentaBuscarFecha(DateTime FechaInicio, DateTime FechaFin)
        {
            Conexion = new CD_Conexion();
            listaVenta = new List<Venta>();

            try
            {
                Conexion.SetConsutarProcedure("SpBuscar_venta_fecha");


                Conexion.SetearParametro("@txt_fecha_inicio", FechaInicio);
                Conexion.SetearParametro("@txt_fecha_fin", FechaFin);

                Conexion.EjecutarLectura();
                while (Conexion.Lector.Read())
                {
                    _Venta = new Venta();


                    _Venta.Id_venta = (int)Conexion.Lector["Id_venta"];

                    _Venta.Trabajador = new Trabajador();
                    _Venta.Trabajador.Nombre = (string)Conexion.Lector["Trabajador"];

                    _Venta.Cliente = new Cliente();
                    _Venta.Cliente.Nombre = (string)Conexion.Lector["Cliente"];

                    _Venta.Fecha = (DateTime)Conexion.Lector["Fecha"];
                    _Venta.Tipo_Comprobante = (string)Conexion.Lector["Tipo_comprobante"];
                    _Venta.Serie = (string)Conexion.Lector["Serie"];
                    _Venta.Correlativo = (string)Conexion.Lector["Correlativo"];
                    _Venta.Iva = (decimal)Conexion.Lector["Iva"];
                    _Venta.Estado = (string)Conexion.Lector["Estado"];
                    _Venta.Total = (decimal)Conexion.Lector["Total"];


                    listaVenta.Add(_Venta);
                }

                return listaVenta;
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
