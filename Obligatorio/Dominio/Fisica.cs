using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Fisica : Evidencia
    {
        private bool _tieneHuellas;

        public Fisica(string descripcion, DateTime fecha, bool tieneHuellas) : base(descripcion, fecha)
        {
            _tieneHuellas = tieneHuellas;
        }

        public bool TieneHuellas { get { return _tieneHuellas; } set { _tieneHuellas = value; } }
    }
}
