using CapaDatos;
using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {

        private CD_Cliente _CD_Cliente;

        //Metodo para Listar los Productos em la DataWirdView
        public List<Cliente> ListaCliente()
        {
            _CD_Cliente = new CD_Cliente();

            return _CD_Cliente.ListaCliente();
        }
    }
}
