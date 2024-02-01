using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Usuario
    {
        private int Id_usuario;
        private int Id_rol;
        private string Nombre;
        private string TipoDocumento;
        private string NumeroDocumento;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private string _User;
        private string _Clave;
        private byte   _Estado;

        public Usuario()
        {
        }

        public Usuario(int id_usuario, int id_rol, string nombre, string tipoDocumento, string numeroDocumento, string direccion, string telefono, string email, string user, string clave, byte estado)
        {
            Id_usuario = id_usuario;
            Id_rol = id_rol;
            Nombre = nombre;
            TipoDocumento = tipoDocumento;
            NumeroDocumento = numeroDocumento;
            _Direccion = direccion;
            _Telefono = telefono;
            _Email = email;
            _User = user;
            _Clave = clave;
            _Estado = estado;
        }

        public int Id_usuario1 { get => Id_usuario; set => Id_usuario = value; }
        public int Id_rol1 { get => Id_rol; set => Id_rol = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string TipoDocumento1 { get => TipoDocumento; set => TipoDocumento = value; }
        public string NumeroDocumento1 { get => NumeroDocumento; set => NumeroDocumento = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string User { get => _User; set => _User = value; }
        public string Clave { get => _Clave; set => _Clave = value; }
        public byte Estado { get => _Estado; set => _Estado = value; }
    }
}
