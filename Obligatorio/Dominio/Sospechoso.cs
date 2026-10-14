using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Sospechoso : IValidable
    {
        private string _nombre;
        private int _ci;
        private bool _antecedentes;

        private DateTime _fechaNac;

        public Sospechoso(string nombre, int ci, bool antecedentes, DateTime fechaNac)
        {
            _nombre = nombre;
            _ci = ci;
            _antecedentes = antecedentes;
            _fechaNac = fechaNac;
        }

        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public int CI { get { return _ci; } set { _ci = value; } }
        public bool Antecedentes { get { return _antecedentes; } set { _antecedentes = value; } }
        public DateTime FechaNac { get { return _fechaNac; } set { _fechaNac = value; } }

        public void Validar()
        {
            
        }

        public override bool Equals(object obj)
        {
            return obj is Sospechoso s && _ci == s._ci;
        }
        
    }
}
