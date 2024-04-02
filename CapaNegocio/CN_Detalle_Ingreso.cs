using CapaDatos;
using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Detalle_Ingreso
    {
        private CD_Detalle_ingreso Detalle_Ingreso;


        public List<Detalle_Ingreso> ListaDetalleIngreso(int Id_ingreso)
        {
            Detalle_Ingreso = new CD_Detalle_ingreso();

            return Detalle_Ingreso.ListaDetalleIngreso(Id_ingreso);
        }


    }
}
