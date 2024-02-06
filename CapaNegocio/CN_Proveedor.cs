using CapaDatos;
using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor _Proveedor;

        //Metodo para Listar los Productos em la DataWirdView
        public List<Proveedor> ListarProveedores()
        {
            _Proveedor = new CD_Proveedor();

            return _Proveedor.ListarProveedores();
        }


        //Metodo para cargar un producto en la Base de Datos
        public void InsertarProveedor(Proveedor Nuevo)
        {
            _Proveedor = new CD_Proveedor();

            _Proveedor.InsertarProveedor(Nuevo);

        }

        //Metodo para Editar un producto en la Base de Datos
        public void EditarProveedor(Proveedor proveedor)
        {
            _Proveedor = new CD_Proveedor();

            _Proveedor.EditarProveedor(proveedor);
        }

        //Metodo para Eliminar un producto en la Base de Datos
        public void EliminarProveedor(int Id_proveedor)
        {
            _Proveedor = new CD_Proveedor();

            _Proveedor.EliminarProveedor(Id_proveedor);
        }


        //Metodo para Buscar un producto en la Base de Datos
        public List<Proveedor> ProveedorBuscar(string buscar)
        {
            _Proveedor = new CD_Proveedor();

            return _Proveedor.ProveedorBuscar(buscar);
        }
    }
}
