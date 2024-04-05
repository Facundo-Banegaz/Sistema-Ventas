using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Articulo
    {

        public int Id_articulo { get; set;}
        public string Codigo {  get; set;}
        public string Nombre { get; set;}
        public string UrlImagen { get; set;}
        public string Descripcion { get; set;}
        public Categoria Categoria { get; set;}
        public Presentacion Presentacion { get; set;}

        public int Stock { get; set; }

        public override string ToString()
        {
            return Nombre;
        }


    }
}
