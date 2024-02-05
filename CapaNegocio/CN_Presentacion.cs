using CapaDatos;
using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Presentacion
    {

        CD_Presentacion CD_Presentacion;

        //Metodo para Listar los Productos em la DataWirdView
        public List<Presentacion> ListarPresentacion()
        {
            CD_Presentacion = new CD_Presentacion();

            return CD_Presentacion.ListarPresentacion();
        }

        //Metodo para Listar los Productos em la DataWirdView
        public List<Presentacion> CargarCbo()
        {
            CD_Presentacion = new CD_Presentacion();

            return CD_Presentacion.CargarCbo();
        }
        //Metodo para cargar un producto en la Base de Datos
        public void InsertarCategoria(Presentacion Nuevo)
        {
            CD_Presentacion = new CD_Presentacion();

            CD_Presentacion.InsertarPresentacion(Nuevo);

        }

        //Metodo para Editar un producto en la Base de Datos
        public void EditarCategoria(Presentacion presentacion)
        {
            CD_Presentacion = new CD_Presentacion();

            CD_Presentacion.EditarPresentacion(presentacion);
        }

        //Metodo para Eliminar un producto en la Base de Datos
        public void EliminarCategoria(int Id_presentacion)
        {
            CD_Presentacion = new CD_Presentacion();

            CD_Presentacion.EliminarPresentacion(Id_presentacion);
        }
        //Metodo para Buscar un producto en la Base de Datos
        public List<Presentacion> PresentacionBuscar(string buscar)
        {
            CD_Presentacion = new CD_Presentacion();

            return CD_Presentacion.PresentacionBuscar(buscar);
        }


    }
}
