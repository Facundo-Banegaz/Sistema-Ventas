using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Usuario
    {
        public int Id_usuario {  get; set; }
        public int Id_rol { get; set; }
        public string Nombre {  get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Direccion {  get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string User { get; set; }
        public string Clave { get; set; }
        public byte   Estado {  get; set; }


    }
}
