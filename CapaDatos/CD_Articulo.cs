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
                Conexion.SetConsutar("select art.Id_articulo, art.Codigo, art.Nombre, art.UrlImagen, art.Descripcion, art.Id_categoria, cat.Nombre as Categoria, art.Id_presentacion, pres.Nombre as Presentacion from Articulo as art inner join Categoria as cat on art.Id_categoria = cat.Id_categoria inner join Presentacion as pres on art.Id_presentacion= pres.Id_presentacion order by art.Nombre desc");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    //articulo = new Articulo();

                    Articulo articulo = new Articulo();


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
