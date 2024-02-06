using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Persona
    {
        public int Id_persona {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo {  get; set; }

        [DisplayName("Fecha Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [DisplayName("Numero Documento")]
        public string NumeroDocumento { get; set; }
        public string Direccion {  get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string UrlImagen { get; set; }


        public int Id_Rol {  get; set; }

        public string Usuario { get; set; }
        public string Clave { get; set; }
        public byte Estado { get;  set; }
    }
}
