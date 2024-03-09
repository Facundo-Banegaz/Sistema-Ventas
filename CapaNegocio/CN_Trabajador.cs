using CapaDatos;
using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Trabajador
    {

        private CD_Trabajador CD_Trabajador;

        //Metodo para Listar los Productos em la DataWirdView
        public List<Trabajador> ListaTrabajador()
        {
            CD_Trabajador = new CD_Trabajador();

            return CD_Trabajador.ListarTrabajador();
        }
    }
}
