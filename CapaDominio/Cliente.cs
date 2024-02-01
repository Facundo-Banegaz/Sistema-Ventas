using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Cliente
    {
        private int _Id_cliente;
        private string _Nombre;
        private string _Apellido;
        private string _Sexo;
        private string _FechaNacimiento;
        private string _TipoDocumento;
        private string _NumeroDocumento;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private string _UrlImagen;

        public Cliente() 
        {
        
        }

        public Cliente(int id_cliente, string nombre, string apellido, string sexo, string fechaNacimiento, string tipoDocumento, string numeroDocumento, string direccion, string telefono, string email, string urlImagen)
        {
            _Id_cliente = id_cliente;
            _Nombre = nombre;
            _Apellido = apellido;
            _Sexo = sexo;
            _FechaNacimiento = fechaNacimiento;
            _TipoDocumento = tipoDocumento;
            _NumeroDocumento = numeroDocumento;
            _Direccion = direccion;
            _Telefono = telefono;
            _Email = email;
            _UrlImagen = urlImagen;
        }

        public int Id_cliente { get => _Id_cliente; set => _Id_cliente = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Sexo { get => _Sexo; set => _Sexo = value; }
        public string FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public string TipoDocumento { get => _TipoDocumento; set => _TipoDocumento = value; }
        public string NumeroDocumento { get => _NumeroDocumento; set => _NumeroDocumento = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string UrlImagen { get => _UrlImagen; set => _UrlImagen = value; }
    }
}
