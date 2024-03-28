using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Articulo
    {
        //inicializa
        private CD_Conexion Conexion;
        private Articulo articulo;
        private List<Articulo> listaArticulo;


        public List<Articulo> ListaArticulos()
        {

            Conexion = new CD_Conexion();
            listaArticulo = new List<Articulo>();

            try
            {
                Conexion.SetConsutarProcedure("SpMostrar_articulo");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    //articulo = new Articulo();

                    articulo = new Articulo();


                    articulo.Id_articulo = (int)Conexion.Lector["Id_articulo"];
                    articulo.Codigo = (string)Conexion.Lector["Codigo"];
                    articulo.Nombre = (string)Conexion.Lector["Nombre"];
                    articulo.Descripcion = (string)Conexion.Lector["Descripcion"];

                    articulo.Categoria = new Categoria(); 

                    articulo.Categoria.Id_categoria = (int)Conexion.Lector["Id_categoria"];
                    articulo.Categoria.Nombre = (string)Conexion.Lector["Categoria"];


                    articulo.Presentacion = new Presentacion();
                    articulo.Presentacion.Id_presentacion = (int)Conexion.Lector["Id_presentacion"];
                    articulo.Presentacion.Nombre = (string)Conexion.Lector["Presentacion"];

                    if (!(Conexion.Lector["UrlImagen"] is DBNull))
                        articulo.UrlImagen = (string)Conexion.Lector["UrlImagen"];

                    listaArticulo.Add(articulo);
                }

                return listaArticulo;
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



        public List<Articulo> CargarCbo(int Id_categoria)
        {

            //instancia

            Conexion = new CD_Conexion();

            listaArticulo = new List<Articulo>();

            try
            {

                Conexion.SetConsutarProcedure("SpObtener_articulos_por_categoria");

                Conexion.SetearParametro("@Id_categoria", Id_categoria);

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    articulo = new Articulo();


                    articulo.Id_articulo = (int)Conexion.Lector["Id_articulo"];
                    articulo.Nombre = (string)Conexion.Lector["Nombre"];

                    listaArticulo.Add(articulo);
                }

                return listaArticulo;
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

        public void InsertarArticulo(Articulo Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpInsertar_articulo");

                Conexion.SetearParametro("@Codigo", Nuevo.Codigo);
                Conexion.SetearParametro("@Nombre", Nuevo.Nombre);
                Conexion.SetearParametro("@Descripcion", Nuevo.Descripcion);
                Conexion.SetearParametro("@UrlImagen", Nuevo.UrlImagen);
                Conexion.SetearParametro("@Id_categoria", Nuevo.Categoria.Id_categoria);
                Conexion.SetearParametro("@Id_presentacion", Nuevo.Presentacion.Id_presentacion);

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


        //metodo editar

        public void EditarArticulo(Articulo articulo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEditar_articulo");

                Conexion.SetearParametro("@Id_articulo", articulo.Id_articulo);
                Conexion.SetearParametro("@Codigo", articulo.Codigo);
                Conexion.SetearParametro("@Nombre", articulo.Nombre);
                Conexion.SetearParametro("@Descripcion", articulo.Descripcion);
                Conexion.SetearParametro("@UrlImagen", articulo.UrlImagen);
                Conexion.SetearParametro("@Id_categoria", articulo.Categoria.Id_categoria);
                Conexion.SetearParametro("@Id_presentacion", articulo.Presentacion.Id_presentacion);

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

        //Metodo eliminar
        public void EliminarArticulo(int Id_articulo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEliminar_articulo");

                Conexion.SetearParametro("@Id_articulo", Id_articulo);


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

        public List<Articulo> ArticuloBuscar(string buscar)
        {
            Conexion = new CD_Conexion();
            listaArticulo = new List<Articulo>();

            try
            {
                Conexion.SetConsutarProcedure("SpBuscar_articulo");


                Conexion.SetearParametro("@txt_buscar", buscar);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    articulo = new Articulo();

                    articulo.Id_articulo = (int)Conexion.Lector["Id_articulo"];
                    articulo.Codigo = (string)Conexion.Lector["Codigo"];
                    articulo.Nombre = (string)Conexion.Lector["Nombre"];
                    articulo.Descripcion = (string)Conexion.Lector["Descripcion"];

                    articulo.Categoria = new Categoria();

                    articulo.Categoria.Id_categoria = (int)Conexion.Lector["Id_categoria"];
                    articulo.Categoria.Nombre = (string)Conexion.Lector["Categoria"];


                    articulo.Presentacion = new Presentacion();
                    articulo.Presentacion.Id_presentacion = (int)Conexion.Lector["Id_presentacion"];
                    articulo.Presentacion.Nombre = (string)Conexion.Lector["Presentacion"];

                    if (!(Conexion.Lector["UrlImagen"] is DBNull))

                        articulo.UrlImagen = (string)Conexion.Lector["UrlImagen"];

                    listaArticulo.Add(articulo);
                }


                return listaArticulo;
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
