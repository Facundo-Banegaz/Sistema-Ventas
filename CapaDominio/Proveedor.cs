using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Proveedor
    {
        public int Id_proveedor { get; set; }
        public string RazonSocial { get; set; }
        public string SectorComercial { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Direccion {  get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string UrlImagen { get; set; }

      
    }
}
