using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Investigador
    {
        private string _email;
        private string _pass;
        private string _nombre;
        private Rol _rol;

        public Investigador(string email, string pass, string nombre, Rol rol)
        {
            _email = email;
            _pass = pass;
            _nombre = nombre;
            _rol = rol;
        }


        public string Email { get { return _email; } set { _email = value; } }
        public string Pass { get { return _pass; } set { _pass = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public Rol Rol { get { return _rol; } set { _rol = value; } }
    }
}
