using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Cliente
    {
        public int Id_cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido {  get; set; }
        public string Sexo { get; set; }
        public string FechaNacimiento { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Direccion {  get; set; }
        public string Telefono {  get; set; }
        public string Email { get; set; }
        public string UrlImagen { get; set; }

        
    }
}
