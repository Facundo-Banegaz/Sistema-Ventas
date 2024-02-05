using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaDatos
{
    public class CD_Presentacion
    {
        private CD_Conexion Conexion;
        private Presentacion Presentacion;
        private List<Presentacion> listaPresentacion;

        public List<Presentacion> ListarPresentacion()
        {

            Conexion = new CD_Conexion();
            listaPresentacion = new List<Presentacion>();


            try
            {
                Conexion.SetConsutarProcedure("SpMostrar_presentacion");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    Presentacion presentacion = new Presentacion();

                    presentacion.Id_presentacion = (int)Conexion.Lector["Id_presentacion"];
                    presentacion.Nombre = (string)Conexion.Lector["Nombre"];
                    presentacion.Descripcion = (string)Conexion.Lector["Descripcion"];



                    listaPresentacion.Add(presentacion);

                }

                return listaPresentacion;
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

        public List<Presentacion> CargarCbo()
        {

            Conexion = new CD_Conexion();
            listaPresentacion = new List<Presentacion>();


            try
            {
                Conexion.SetConsutar("Select Id_presentacion, Nombre from Presentacion");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    Presentacion presentacion = new Presentacion();

                    presentacion.Id_presentacion = (int)Conexion.Lector["Id_presentacion"];
                    presentacion.Nombre = (string)Conexion.Lector["Nombre"];



                    listaPresentacion.Add(presentacion);

                }

                return listaPresentacion;
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

        public void InsertarPresentacion(Presentacion Nuevo)
        {

            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpInsertar_presentacion");

                Conexion.SetearParametro("@Nombre", Nuevo.Nombre);
                Conexion.SetearParametro("@Descripcion", Nuevo.Descripcion);

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


        public void EditarPresentacion(Presentacion presentacion)
        {

            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEditar_presentacion");

                Conexion.SetearParametro("@Id_presentacion", presentacion.Id_presentacion);
                Conexion.SetearParametro("@Nombre", presentacion.Nombre);
                Conexion.SetearParametro("@Descripcion", presentacion.Descripcion);


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


        public void EliminarPresentacion(int Id_presentacion)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEliminar_presentacion");

                Conexion.SetearParametro("@Id_presentacion", Id_presentacion);


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

        public List<Presentacion> PresentacionBuscar(string buscar)
        {
            Conexion = new CD_Conexion();
            listaPresentacion = new List<Presentacion>();

            try
            {
                Conexion.SetConsutarProcedure("SpBuscar_presentacion");


                Conexion.SetearParametro("@txt_buscar", buscar);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    Presentacion = new Presentacion();

                    Presentacion.Id_presentacion = (int)Conexion.Lector["Id_presentacion"];
                    Presentacion.Nombre = (string)Conexion.Lector["Nombre"];
                    Presentacion.Descripcion = (string)Conexion.Lector["Descripcion"];


                    listaPresentacion.Add(Presentacion);
                }


                return listaPresentacion;
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
