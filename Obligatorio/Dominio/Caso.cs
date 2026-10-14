using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Caso
    {
        private static int s_id = 0;
        private int _id;
        private string _nombre;
        private string _descripcion;
        private bool _cerrado;
        private Sospechoso _sospechoso;
        private Investigador _detective;
        private List<Evidencia> _evidencias;

        public Caso(string nombre, string descripcion, bool cerrado, Sospechoso sospechoso, Investigador detective, List<Evidencia> evidencias)
        {
            _nombre = nombre;
            _descripcion = descripcion;
            _cerrado = cerrado;
            _sospechoso = sospechoso;
            _detective = detective;
            _evidencias = evidencias;
            _id = s_id++;
        }

        public int Id { get { return _id; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Descripcion { get { return _descripcion;} set { _descripcion = value; } }
        public bool Cerrado { get { return _cerrado; } set { _cerrado = value; } }
        public Sospechoso Sospechoso { get { return _sospechoso; } set { _sospechoso = value; } }
        public Investigador Detective { get { return _detective; } set { _detective = value; } }
        public List<Evidencia> Evidencias { get { return _evidencias; } set { _evidencias = value; } }
    }
}
