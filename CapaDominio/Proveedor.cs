using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Proveedor
    {
        public int Id_proveedor { get; set; }
        [DisplayName("Razon Social")]
        public string RazonSocial { get; set; }
        [DisplayName("Sector Comercial")]
        public string SectorComercial { get; set; }
        [DisplayName("Pagina Web")]
        public string PaginaWeb { get; set; }
        public string Direccion {  get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string UrlImagen { get; set; }

        public override string ToString()
        {
            return RazonSocial;
        }

    }
}
