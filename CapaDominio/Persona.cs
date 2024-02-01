using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Persona
    {
        private int _Id_persona;
        private string _Nombre;
        private string _Apellido;
        private string _Sexo;
        private DateTime _FechaNacimiento;
        private string _NumeroDocumento;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private string _UrlImagen;

        public Persona()
        {
        }

        public Persona(int id_persona, string nombre, string apellido, string sexo, DateTime fechaNacimiento, string numeroDocumento, string direccion, string telefono, string email, string urlImagen)
        {
            _Id_persona = id_persona;
            _Nombre = nombre;
            _Apellido = apellido;
            _Sexo = sexo;
            _FechaNacimiento = fechaNacimiento;
            _NumeroDocumento = numeroDocumento;
            _Direccion = direccion;
            _Telefono = telefono;
            _Email = email;
            _UrlImagen = urlImagen;
        }

        public int Id_persona { get => _Id_persona; set => _Id_persona = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Sexo { get => _Sexo; set => _Sexo = value; }
        public DateTime FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public string NumeroDocumento { get => _NumeroDocumento; set => _NumeroDocumento = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string UrlImagen { get => _UrlImagen; set => _UrlImagen = value; }
    }
}
