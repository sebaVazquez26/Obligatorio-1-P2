using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public abstract class Evidencia : IValidable
    {
        private static int s_id = 0;
        private int _id;
        private string _descripcion;

        private DateTime _fecha;

        public Evidencia(string descripcion, DateTime fecha)
        {
            _id = s_id++;
            _descripcion = descripcion;
            _fecha = fecha;
        }

        public string Descripcion { get {  return _descripcion; } set { _descripcion = value;} }
        public DateTime Fecha { get { return _fecha; } set { _fecha = value; } }

        public void Validar()
        {
            if (string.IsNullOrEmpty(_descripcion)) throw new Exception("La descripción no puede ser nula");
            if (_fecha>DateTime.Today)throw new Exception("La fecha no puede ser superior a la actual") ;
        }
    }
}
