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
        //Metodo para el login
        public Trabajador Login(string Usuario, string Clave)
        {
            CD_Trabajador = new CD_Trabajador();
            return CD_Trabajador.Login(Usuario, Clave);
        }
        //Metodo para cargar un producto en la Base de Datos
        public void InsertarTrabajador(Trabajador Nuevo)
        {
            CD_Trabajador = new CD_Trabajador();

            CD_Trabajador.InsertarTrabajador(Nuevo);

        }

        //Metodo para Editar un producto en la Base de Datos
        public void EditarTrabajador(Trabajador trabajador)
        {
            CD_Trabajador = new CD_Trabajador();

            CD_Trabajador.EditarTrabajador(trabajador);
        }

        //Metodo para Eliminar un producto en la Base de Datos
        public void EliminarTrabajador(int Id_Trabajador)
        {
            CD_Trabajador = new CD_Trabajador();

            CD_Trabajador.EliminarTrabajdor(Id_Trabajador);
        }


        //Metodo para Buscar un producto en la Base de Datos
        public List<Trabajador> TrabajadorBuscar(string buscar)
        {
            CD_Trabajador = new CD_Trabajador();

            return CD_Trabajador.TrabajadorBuscar(buscar);
        }

    }
}
