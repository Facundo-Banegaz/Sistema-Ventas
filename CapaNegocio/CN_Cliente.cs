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
        public List<Cliente> CargarCbo()
        {
            _CD_Cliente = new CD_Cliente();

            return _CD_Cliente.CargarCbo();
        }

        //Metodo para validar dni
        ////public string ValidarCliente(string Dni)
        ////{
        ////    _CD_Cliente = new CD_Cliente();

        ////   return _CD_Cliente.ValidarCliente(Dni);
        ////}
        //Metodo para cargar un producto en la Base de Datos
        public bool ValidarCliente(string Dni)
        {
            _CD_Cliente = new CD_Cliente();

            return _CD_Cliente.ValidarCliente(Dni);
        }
        public void InsertarCliente(Cliente Nuevo)
        {
            _CD_Cliente = new CD_Cliente();

            _CD_Cliente.InsertarCliente(Nuevo);

        }

        //Metodo para Editar un producto en la Base de Datos
        public void EditarCliente(Cliente cliente)
        {
            _CD_Cliente = new CD_Cliente();

            _CD_Cliente.EditarCliente(cliente);
        }

        //Metodo para Eliminar un producto en la Base de Datos
        public void EliminarCliente(int Id_Cliente)
        {
            _CD_Cliente = new CD_Cliente();

            _CD_Cliente.EliminarCliente(Id_Cliente);
        }


        //Metodo para Buscar un producto en la Base de Datos
        public List<Cliente> ClienteBuscar(string buscar)
        {
            _CD_Cliente = new CD_Cliente();

            return _CD_Cliente.ClienteBuscar(buscar);
        }
    }
}
