using CapaDominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Ingreso
    {

        private CD_Conexion Conexion;
        private Ingreso Ingreso;
        private List<Ingreso> listaIngreso;


        public List<Ingreso> ListaIngreso()
        {

            //instancia

            Conexion = new CD_Conexion();

            listaIngreso = new List<Ingreso>();

            try
            {

                Conexion.SetConsutarProcedure("SpMostrar_ingreso");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    Ingreso = new Ingreso();


                    Ingreso.Id_ingreso = (int)Conexion.Lector["Id_ingreso"];

                    Ingreso.Trabajador = new Trabajador();
                    Ingreso.Trabajador.Id_trabajador = (int)Conexion.Lector["Id_trabajador"];
                    Ingreso.Trabajador.Nombre = (string)Conexion.Lector["Trabajador"];


                    Ingreso.Proveedor = new Proveedor();

                    Ingreso.Proveedor.Id_proveedor = (int)Conexion.Lector["Id_proveedor"];
                    Ingreso.Proveedor.RazonSocial = (string)Conexion.Lector["Proveedor"];
                    Ingreso.Fecha = (DateTime)Conexion.Lector["Fecha"];
                    Ingreso.Tipo_Comprobante = (string)Conexion.Lector["Tipo_comprobante"];
                    Ingreso.Serie = (string)Conexion.Lector["Serie"];

                    Ingreso.Correlativo = (string)Conexion.Lector["Correlativo"];
                    Ingreso.Iva = (decimal)Conexion.Lector["Iva"];
                    Ingreso.Estado = (string)Conexion.Lector["Estado"];
                    Ingreso.Total = (decimal)Conexion.Lector["Total"];


                    listaIngreso.Add(Ingreso);
                }

                return listaIngreso;
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

        
        public void InsertarIngreso(Ingreso Nuevo, List<Detalle_Ingreso> DetalleIngreso)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.IniciarTransaccion();

                Conexion.SetConsutarProcedure("SpInsertar_ingreso");

                Conexion.SetearParametro("@Id_trabajador", Nuevo.Trabajador.Id_trabajador);
                Conexion.SetearParametro("@Id_proveedor", Nuevo.Proveedor.Id_proveedor);
                Conexion.SetearParametro("@Fecha", Nuevo.Fecha);
                Conexion.SetearParametro("@Tipo_comprobante", Nuevo.Tipo_Comprobante);
                Conexion.SetearParametro("@Serie", Nuevo.Serie);
                Conexion.SetearParametro("@Correlativo", Nuevo.Correlativo);
                Conexion.SetearParametro("@Iva", Nuevo.Iva);
                Conexion.SetearParametro("@Estado", Nuevo.Estado);

                Conexion.EjecutarAccion();

                ////capturar el id_ingreso

                //Conexion.SetearParametroSalida("@id_ingreso", SqlDbType.Int);



                // Capturar el ID del ingreso insertado
                int idIngreso = Conexion.ObtenerValorParametroSalida("@id_ingreso");




                CD_Detalle_ingreso _Detalle_Ingreso = new CD_Detalle_ingreso();

                // Insertar detalles de ingreso
                foreach (Detalle_Ingreso detalle in DetalleIngreso)
                {
                    detalle.Ingreso.Id_ingreso = idIngreso; // Suponiendo que tienes un método para obtener el último ID de ingreso insertado

  

                    _Detalle_Ingreso.InsertarDetalleIngreso(detalle);
                }



                Conexion.ConfirmarTransaccion();
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
        public void AnularIngreso(int Id_ingreso)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpAnular_ingreso");

                Conexion.SetearParametro("@Id_ingreso", Id_ingreso);


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

        public List<Ingreso> IngresoBuscarFecha(DateTime FechaInicio,DateTime FechaFin)
        {
            Conexion = new CD_Conexion();
            listaIngreso = new List<Ingreso>();

            try
            {
                Conexion.SetConsutarProcedure("SpBuscar_ingreso_fecha");


                Conexion.SetearParametro("@txt_fecha_inicio", FechaInicio);
                Conexion.SetearParametro("@txt_fecha_fin", FechaFin);

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    Ingreso = new Ingreso();


                    Ingreso.Id_ingreso = (int)Conexion.Lector["Id_ingreso"];

                    Ingreso.Trabajador = new Trabajador();
                    Ingreso.Trabajador.Id_trabajador = (int)Conexion.Lector["Id_trabajador"];
                    Ingreso.Trabajador.Nombre = (string)Conexion.Lector["Trabajador"];


                    Ingreso.Proveedor = new Proveedor();

                    Ingreso.Proveedor.Id_proveedor = (int)Conexion.Lector["Id_proveedor"];
                    Ingreso.Proveedor.RazonSocial = (string)Conexion.Lector["Proveedor"];
                    Ingreso.Fecha = (DateTime)Conexion.Lector["Fecha"];
                    Ingreso.Tipo_Comprobante = (string)Conexion.Lector["Tipo_comprobante"];
                    Ingreso.Serie = (string)Conexion.Lector["Serie"];

                    Ingreso.Correlativo = (string)Conexion.Lector["Correlativo"];
                    Ingreso.Iva = (decimal)Conexion.Lector["Iva"];
                    Ingreso.Estado = (string)Conexion.Lector["Estado"];
                    Ingreso.Total = (decimal)Conexion.Lector["Total"];


                    listaIngreso.Add(Ingreso);
                }

                return listaIngreso;
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
