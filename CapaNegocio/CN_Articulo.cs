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
        public List<Articulo> ListaArticulo()
        {
            _CD_Articulo= new CD_Articulo();

            return _CD_Articulo.ListaArticulos();
        }
    }
}
