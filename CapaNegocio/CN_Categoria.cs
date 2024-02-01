using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDominio;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria  _CD_Categoria;

        //Metodo para Listar los Productos em la DataWirdView
        public List<Categoria> ListaCategoria()
        {
            _CD_Categoria = new CD_Categoria();

            return _CD_Categoria.ListaCategoria();
        }

        //Metodo para cargar un producto en la Base de Datos
        public void InsertarCategoria(Categoria Nuevo)
        {
            _CD_Categoria = new CD_Categoria();

            _CD_Categoria.InsertarCategoria(Nuevo);

        }

        //Metodo para Editar un producto en la Base de Datos
        public void EditarCategoria(Categoria categoria)
        {
            _CD_Categoria = new CD_Categoria();

            _CD_Categoria.EditarCategoria(categoria);
        }

        //Metodo para Eliminar un producto en la Base de Datos
        public void EliminarCategoria(int Id_categoria)
        {
            _CD_Categoria = new CD_Categoria();

            _CD_Categoria.EliminarCategoria(Id_categoria);
        }
        //Metodo para Buscar un producto en la Base de Datos
        public List<Categoria> CategoriaBuscar(string buscar)
        {
            _CD_Categoria = new CD_Categoria();

            return _CD_Categoria.CategoriaBuscar(buscar);
        }
    }
}
