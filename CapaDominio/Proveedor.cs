using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Proveedor
    {
        private int _Id_proveedor;
        private string _RazonSocial;
        private string _RazonSoxial;
        private string _TipoDocumento;
        private string _NumeroDocumento;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private string _UrlImagen;

        public Proveedor() 
        {
        }

        public Proveedor(int id_proveedor, string razonSocial, string razonSoxial, string tipoDocumento, string numeroDocumento, string direccion, string telefono, string email, string urlImagen)
        {
            _Id_proveedor = id_proveedor;
            _RazonSocial = razonSocial;
            _RazonSoxial = razonSoxial;
            _TipoDocumento = tipoDocumento;
            _NumeroDocumento = numeroDocumento;
            _Direccion = direccion;
            _Telefono = telefono;
            _Email = email;
            _UrlImagen = urlImagen;
        }

        public int Id_proveedor { get => _Id_proveedor; set => _Id_proveedor = value; }
        public string RazonSocial { get => _RazonSocial; set => _RazonSocial = value; }
        public string RazonSoxial { get => _RazonSoxial; set => _RazonSoxial = value; }
        public string TipoDocumento { get => _TipoDocumento; set => _TipoDocumento = value; }
        public string NumeroDocumento { get => _NumeroDocumento; set => _NumeroDocumento = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string UrlImagen { get => _UrlImagen; set => _UrlImagen = value; }
    }
}
