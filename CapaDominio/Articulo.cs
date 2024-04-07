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

        //atributos necesarios
        public int Stock { get; set; }
        public decimal Precio_Compra { get; set; }
        public decimal Precio_Venta { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }
        public int Id_detalle_ingreso { get; set; }
        public override string ToString()
        {
            return Nombre;
        }


    }
}
