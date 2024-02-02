using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaDatos
{
    public class CD_Categoria
    {

        //inicializa
        private CD_Conexion Conexion;
        private Categoria categoria;
        private List<Categoria> listaCategoria;


        //Metodo Mostrar

        public List<Categoria> ListaCategoria()
        {

            //instancia

            Conexion = new CD_Conexion();

            listaCategoria = new List<Categoria>();

            try
            {

                Conexion.SetConsutarProcedure("SpMostrar_categoria");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read()) 
                {
                     categoria = new Categoria();


                    categoria.Id_categoria = (int)Conexion.Lector["Id_categoria"];
                    categoria.Nombre = (string)Conexion.Lector["Nombre"];
                    categoria.Descripcion = (string)Conexion.Lector["Descripcion"];

                    if (!(Conexion.Lector["UrlImagen"] is DBNull))
                        categoria.UrlImagen = (string)Conexion.Lector["UrlImagen"];

                    listaCategoria.Add(categoria);
                }

                return listaCategoria;
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

        public void InsertarCategoria(Categoria Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpInsertar_categoria");

                Conexion.SetearParametro("@Nombre", Nuevo.Nombre);
                Conexion.SetearParametro("@Descripcion", Nuevo.Descripcion);
                Conexion.SetearParametro("@UrlImagen", Nuevo.UrlImagen);

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

        public void EditarCategoria(Categoria categoria)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEditar_categoria");

                Conexion.SetearParametro("@Id_categoria", categoria.Id_categoria);
                Conexion.SetearParametro("@Nombre", categoria.Nombre);
                Conexion.SetearParametro("@Descripcion", categoria.Descripcion);
                Conexion.SetearParametro("@UrlImagen", categoria.UrlImagen);

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
        public void EliminarCategoria(int Id_categoria) 
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEliminar_categoria");

                Conexion.SetearParametro("@Id_categoria", Id_categoria);


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

        public List<Categoria> CategoriaBuscar(string buscar) 
        {
            Conexion = new CD_Conexion();
            listaCategoria = new List<Categoria>();

            try
            {
                Conexion.SetConsutarProcedure("SpBuscar_categoria");


                Conexion.SetearParametro("@txt_buscar", buscar);


                Conexion.EjecutarLectura();

                while(Conexion.Lector.Read())
                {

                    categoria = new Categoria();

                    categoria.Id_categoria = (int)Conexion.Lector["Id_categoria"];
                    categoria.Nombre = (string)Conexion.Lector["Nombre"];
                    categoria.Descripcion = (string)Conexion.Lector["Descripcion"];
                    categoria.UrlImagen = (string)Conexion.Lector["UrlImagen"];

                    listaCategoria.Add(categoria);
                }


                return listaCategoria;
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
