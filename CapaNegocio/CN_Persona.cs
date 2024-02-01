using CapaDatos;
using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Persona
    {

        private CD_Persona CD_Persona;

        //Metodo para Listar los Productos em la DataWirdView
        public List<Persona> ListaPersona()
        {
            CD_Persona = new CD_Persona();

            return CD_Persona.ListarPersona();
        }
    }
}
