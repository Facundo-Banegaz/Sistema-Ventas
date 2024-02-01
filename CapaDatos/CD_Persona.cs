using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Persona
    {
        private CD_Conexion Conexion;
        private Persona persona;
        private List<Persona> listaPersona;

        public List<Persona> ListarPersona()
        {

            Conexion = new CD_Conexion();
            listaPersona = new List<Persona>();


            try
            {
                Conexion.SetConsutarProcedure("SpMostrar_Persona");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                     persona = new Persona();

                    persona.Id_persona = (int)Conexion.Lector["Id_persona"];
                    persona.Nombre = (string)Conexion.Lector["Nombre"];
                    persona.Apellido = (string)Conexion.Lector["Apellido"];
                    persona.Sexo = (string)Conexion.Lector["Sexo"];
                    persona.FechaNacimiento = (DateTime)Conexion.Lector["Fecha_nacimiento"];
                    persona.NumeroDocumento = (string)Conexion.Lector["Numero_documento"];
                    persona.Direccion = (string)Conexion.Lector["Direccion"];
                    persona.Telefono = (string)Conexion.Lector["Telefono"];
                    persona.Email = (string)Conexion.Lector["Email"];

                    if (!(Conexion.Lector["Url_imagen"] is DBNull))
                        persona.UrlImagen = (string)Conexion.Lector["Url_imagen"];




                    listaPersona.Add(persona);


                }

                return listaPersona;
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
