using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Grabacion : Evidencia, IValidable
    {
        private int _calidad;
        private bool _capturaSospechoso;

        public Grabacion(string descripcion, DateTime fecha, int calidad, bool capturaSospechoso) : base(descripcion, fecha)
        {
            _calidad = calidad;
            _capturaSospechoso = capturaSospechoso;
        }

        public int Calidad { get { return _calidad; } set { _calidad = value; } }
        public bool CapturaSospechoso { get { return _capturaSospechoso; } set { _capturaSospechoso = value; } }

        public void Validar()
        {
            if (_calidad > 5 || _calidad < 1) throw new Exception("La calidad debe tener un valor entre 1 y 5");
        }
    }
}
