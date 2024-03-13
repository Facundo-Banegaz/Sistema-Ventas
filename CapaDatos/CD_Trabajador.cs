using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Trabajador
    {
        private CD_Conexion Conexion;
        private Trabajador trabajador;
        private List<Trabajador> listaTrabajador;

        public List<Trabajador> ListarTrabajador()
        {

            Conexion = new CD_Conexion();
            listaTrabajador = new List<Trabajador>();


            try
            {
                Conexion.SetConsutarProcedure("SpMostrar_trabajador");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    trabajador = new Trabajador();

                    trabajador.Id_trabajador = (int)Conexion.Lector["Id_trabajador"];
                    trabajador.Nombre = (string)Conexion.Lector["Nombre"];
                    trabajador.Apellido = (string)Conexion.Lector["Apellido"];
                    trabajador.Sexo = (string)Conexion.Lector["Sexo"];
                    trabajador.FechaNacimiento = (DateTime)Conexion.Lector["Fecha_nacimiento"];
                    trabajador.NumeroDocumento = (string)Conexion.Lector["Numero_documento"];
                    trabajador.Direccion = (string)Conexion.Lector["Direccion"];
                    trabajador.Telefono = (string)Conexion.Lector["Telefono"];
                    trabajador.Email = (string)Conexion.Lector["Email"];
                    trabajador.Acceso = (string)Conexion.Lector["Acceso"];
                    trabajador.Usuario = (string)Conexion.Lector["Usuario"];
                    trabajador.Clave = (string)Conexion.Lector["Clave"];
                    

                    if (!(Conexion.Lector["Url_imagen"] is DBNull))
                        trabajador.UrlImagen = (string)Conexion.Lector["Url_imagen"];




                    listaTrabajador.Add(trabajador);


                }

                return listaTrabajador;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConection();
            }

        }
        //metodo insertar

        public void InsertarTrabajador(Trabajador Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpInsertar_trabajador");

                Conexion.SetearParametro("@Nombre", Nuevo.Nombre);
                Conexion.SetearParametro("@Apellido", Nuevo.Apellido);
                Conexion.SetearParametro("@Sexo", Nuevo.Sexo);
                Conexion.SetearParametro("@Fecha_nacimiento", Nuevo.FechaNacimiento);
                Conexion.SetearParametro("@Numero_documento", Nuevo.NumeroDocumento);
                Conexion.SetearParametro("@Direccion", Nuevo.Direccion);
                Conexion.SetearParametro("@Telefono", Nuevo.Telefono);
                Conexion.SetearParametro("@Email", Nuevo.Email);
                Conexion.SetearParametro("@UrlImagen", Nuevo.UrlImagen);
                Conexion.SetearParametro("@Acceso", Nuevo.Acceso);
                Conexion.SetearParametro("@Usuario",Nuevo.Usuario);
                Conexion.SetearParametro("@Clave", Nuevo.Clave);





                Conexion.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConection();
            }
        }


        //metodo editar

        public void EditarTrabajador(Trabajador trabajador)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEditar_trabajador");

                Conexion.SetearParametro("@Id_trabajador", trabajador.Id_trabajador);
                Conexion.SetearParametro("@Nombre", trabajador.Nombre);
                Conexion.SetearParametro("@Apellido", trabajador.Apellido);
                Conexion.SetearParametro("@Sexo", trabajador.Sexo);
                Conexion.SetearParametro("@Fecha_nacimiento", trabajador.FechaNacimiento);
                Conexion.SetearParametro("@Numero_documento", trabajador.NumeroDocumento);
                Conexion.SetearParametro("@Direccion", trabajador.Direccion);
                Conexion.SetearParametro("@Telefono", trabajador.Telefono);
                Conexion.SetearParametro("@Email", trabajador.Email);
                Conexion.SetearParametro("@UrlImagen", trabajador.UrlImagen);
                Conexion.SetearParametro("@Acceso", trabajador.Acceso);
                Conexion.SetearParametro("@Usuario", trabajador.Usuario);
                Conexion.SetearParametro("@Clave", trabajador.Clave);

                Conexion.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConection();
            }

        }

        //Metodo eliminar
        public void EliminarTrabajdor(int Id_trabajador)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEliminar_trabajador");

                Conexion.SetearParametro("@Id_trabajador", Id_trabajador);


                Conexion.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConection();
            }
        }

        //Metodo Buscar

        public List<Trabajador> TrabajadorBuscar(string buscar)
        {
            Conexion = new CD_Conexion();
            listaTrabajador = new List<Trabajador>();

            try
            {
                Conexion.SetConsutarProcedure("SpBuscar_trabajador_apellido");


                Conexion.SetearParametro("@txt_buscar", buscar);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    trabajador = new Trabajador();

                    trabajador.Id_trabajador = (int)Conexion.Lector["Id_trabajador"];
                    trabajador.Nombre = (string)Conexion.Lector["Nombre"];
                    trabajador.Apellido = (string)Conexion.Lector["Apellido"];
                    trabajador.Sexo = (string)Conexion.Lector["Sexo"];
                    trabajador.FechaNacimiento = (DateTime)Conexion.Lector["Fecha_nacimiento"];
                    trabajador.NumeroDocumento = (string)Conexion.Lector["Numero_documento"];
                    trabajador.Direccion = (string)Conexion.Lector["Direccion"];
                    trabajador.Telefono = (string)Conexion.Lector["Telefono"];
                    trabajador.Email = (string)Conexion.Lector["Email"];
                    trabajador.Acceso = (string)Conexion.Lector["Acceso"];
                    trabajador.Usuario = (string)Conexion.Lector["Usuario"];
                    trabajador.Clave = (string)Conexion.Lector["Clave"];


                    if (!(Conexion.Lector["Url_imagen"] is DBNull))
                        trabajador.UrlImagen = (string)Conexion.Lector["Url_imagen"];

                    listaTrabajador.Add(trabajador);
                }


                return listaTrabajador;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConection();
            }
        }


       
        public Trabajador Login(string Usuario, string Clave)
        {
            Conexion = new CD_Conexion();
            

            try
            {
                Conexion.SetConsutarProcedure("Sp_login");

                Conexion.SetearParametro("@Usuario", Usuario);
                Conexion.SetearParametro("@Clave", Clave);

                Conexion.EjecutarLectura();

                // Si hay al menos un trabajador en la lista, devolvemos el primero (asumiendo que no debería haber más de uno)
                if (Conexion.Lector.Read())
                {
                    trabajador = new Trabajador();
                    trabajador.Id_trabajador = Convert.ToInt32(Conexion.Lector["Id_trabajador"]);
                    trabajador.Nombre = Conexion.Lector["Nombre"].ToString();
                    trabajador.Apellido = Conexion.Lector["Apellido"].ToString();
                    trabajador.Acceso = Conexion.Lector["Acceso"].ToString();
                    trabajador.Usuario = Conexion.Lector["Usuario"].ToString();
                    trabajador.Clave = Conexion.Lector["Clave"].ToString();
                    if (!(Conexion.Lector["Url_imagen"] is DBNull))
                    trabajador.UrlImagen = (string)Conexion.Lector["Url_imagen"];
                }

                return trabajador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexion.CerrarConection();
            }
        }

    }
}
