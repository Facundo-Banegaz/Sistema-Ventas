using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Presentacion
    {

        public int Id_presentacion {  get; set; }
        public string Nombre {  get; set; }
        public string Descripcion { get; set; }


        public override string ToString()
        {
            return Nombre;
        }
    }
}
