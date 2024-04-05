using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Cliente
    {
        //inicializa
        private CD_Conexion Conexion;
        private Cliente Cliente;
        private List<Cliente> listaCliente;


        public List<Cliente> ListaCliente()
        {

            //instancia

            Conexion = new CD_Conexion();

            listaCliente = new List<Cliente>();

            try
            {

                Conexion.SetConsutarProcedure("SpMostrar_cliente");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    Cliente = new Cliente();


                    Cliente.Id_cliente = (int)Conexion.Lector["Id_cliente"];
                    Cliente.Nombre = (string)Conexion.Lector["Nombre"];
                    Cliente.Apellido = (string)Conexion.Lector["Apellido"];
                    Cliente.Sexo = (string)Conexion.Lector["Sexo"];
                    Cliente.FechaNacimiento = (DateTime)Conexion.Lector["Fecha_nacimiento"];
                    Cliente.NumeroDocumento = (string)Conexion.Lector["Numero_documento"];
                    Cliente.Direccion = (string)Conexion.Lector["Direccion"];
                    Cliente.Telefono = (string)Conexion.Lector["Telefono"];
                    Cliente.Email = (string)Conexion.Lector["Email"];

                    if (!(Conexion.Lector["UrlImagen"] is DBNull))
                        Cliente.UrlImagen = (string)Conexion.Lector["UrlImagen"];

                    listaCliente.Add(Cliente);
                }

                return listaCliente;
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
        //Metodo del ComboBox
        public List<Cliente> CargarCbo()
        {

            //instancia

            Conexion = new CD_Conexion();

            listaCliente = new List<Cliente>();

            try
            {

                Conexion.SetConsutar("select Id_cliente, Nombre from Cliente");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    Cliente = new Cliente();


                    Cliente.Id_cliente = (int)Conexion.Lector["Id_cliente"];
                    Cliente.Nombre = (string)Conexion.Lector["Nombre"];

                    listaCliente.Add(Cliente);
                }

                return listaCliente;
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

        public void InsertarCliente(Cliente Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpInsertar_cliente");

                Conexion.SetearParametro("@Nombre", Nuevo.Nombre);
                Conexion.SetearParametro("@Apellido", Nuevo.Apellido);
                Conexion.SetearParametro("@Sexo", Nuevo.Sexo);
                Conexion.SetearParametro("@Fecha_nacimiento", Nuevo.FechaNacimiento.ToString("yyyy-MM-dd hh:mm:ss"));
                Conexion.SetearParametro("@Numero_documento", Nuevo.NumeroDocumento);
                Conexion.SetearParametro("@Direccion", Nuevo.Direccion);
                Conexion.SetearParametro("@Telefono", Nuevo.Telefono);
                Conexion.SetearParametro("@Email", Nuevo.Email);
                Conexion.SetearParametro("@UrlImagen", Nuevo.UrlImagen);




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

        public void EditarCliente(Cliente cliente)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEditar_cliente");

                Conexion.SetearParametro("@Id_cliente", cliente.Id_cliente);
                Conexion.SetearParametro("@Nombre", cliente.Nombre);
                Conexion.SetearParametro("@Apellido", cliente.Apellido);
                Conexion.SetearParametro("@Sexo", cliente.Sexo);
                Conexion.SetearParametro("@Fecha_nacimiento", cliente.FechaNacimiento.ToString("yyyy-MM-dd hh:mm:ss"));
                Conexion.SetearParametro("@Numero_documento", cliente.NumeroDocumento);
                Conexion.SetearParametro("@Direccion", cliente.Direccion);
                Conexion.SetearParametro("@Telefono", cliente.Telefono);
                Conexion.SetearParametro("@Email", cliente.Email);
                Conexion.SetearParametro("@UrlImagen", cliente.UrlImagen);

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
        public void EliminarCliente(int Id_cliente)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEliminar_cliente");

                Conexion.SetearParametro("@Id_cliente", Id_cliente);


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

        public List<Cliente> ClienteBuscar(string buscar)
        {
            Conexion = new CD_Conexion();
            listaCliente = new List<Cliente>();

            try
            {
                Conexion.SetConsutarProcedure("SpBuscar_cliente_apellido");


                Conexion.SetearParametro("@txt_buscar", buscar);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    Cliente = new Cliente();

                    Cliente.Id_cliente = (int)Conexion.Lector["Id_cliente"];
                    Cliente.Nombre = (string)Conexion.Lector["Nombre"];
                    Cliente.Apellido = (string)Conexion.Lector["Apellido"];
                    Cliente.Sexo = (string)Conexion.Lector["Sexo"];
                    Cliente.FechaNacimiento = (DateTime)Conexion.Lector["Fecha_nacimiento"];
                    Cliente.NumeroDocumento = (string)Conexion.Lector["Numero_documento"];
                    Cliente.Direccion = (string)Conexion.Lector["Direccion"];
                    Cliente.Telefono = (string)Conexion.Lector["Telefono"];
                    Cliente.Email = (string)Conexion.Lector["Email"];

                    if (!(Conexion.Lector["UrlImagen"] is DBNull))
                        Cliente.UrlImagen = (string)Conexion.Lector["UrlImagen"];

                    listaCliente.Add(Cliente);
                }


                return listaCliente;
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
