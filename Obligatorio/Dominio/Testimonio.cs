using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Testimonio : Evidencia
    {
        private string _nombre;
        private Credibilidad _credibilidad;

        public Testimonio(string descripcion, DateTime fecha, string nombre, Credibilidad credibilidad) : base(descripcion, fecha)
        {
            _nombre = nombre;
            _credibilidad = credibilidad;
        }

        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public Credibilidad Credibilidad { get { return _credibilidad; } set { _credibilidad = value; } }
    }
}
