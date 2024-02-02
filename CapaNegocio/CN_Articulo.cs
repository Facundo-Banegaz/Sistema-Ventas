using CapaDatos;
using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Articulo
    {

        private CD_Articulo _CD_Articulo;

        //Metodo para Listar los Productos em la DataWirdView
        public List<Articulo> ListaArticulos()
        {
            _CD_Articulo= new CD_Articulo();

            return _CD_Articulo.ListaArticulos();
        }


        //Metodo para cargar un producto en la Base de Datos
        public void InsertarArticulo(Articulo Nuevo)
        {
            _CD_Articulo = new CD_Articulo();

            _CD_Articulo.InsertarArticulo(Nuevo);

        }

        //Metodo para Editar un producto en la Base de Datos
        public void EditarArticulo(Articulo categoria)
        {
            _CD_Articulo = new CD_Articulo();

            _CD_Articulo.EditarArticulo(categoria);
        }

        //Metodo para Eliminar un producto en la Base de Datos
        public void EliminarArticulo(int Id_articulo)
        {
            _CD_Articulo = new CD_Articulo();

            _CD_Articulo.EliminarArticulo(Id_articulo);
        }
        //Metodo para Buscar un producto en la Base de Datos
        public List<Articulo> ArticuloBuscar(string buscar)
        {
            _CD_Articulo = new CD_Articulo();

            return _CD_Articulo.ArticuloBuscar(buscar);
        }
    }
}
