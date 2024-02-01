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


                    Cliente.Id_cliente = (int)Conexion.Lector["Id_categoria"];
                    Cliente.Nombre = (string)Conexion.Lector["Nombre"];
                    Cliente.Apellido = (string)Conexion.Lector["Descripcion"];
                    Cliente.Sexo = (string)Conexion.Lector["Sexo"];
                    Cliente.FechaNacimiento = (string)Conexion.Lector["Fecha_nacimiento"];
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
