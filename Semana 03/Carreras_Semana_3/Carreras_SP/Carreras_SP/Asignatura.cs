using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carreras_SP
{
    internal class Asignatura
    {
        private int id_asignatura;
        private string nombre;

        public int Codigo
        {
            get { return id_asignatura; }
            set { id_asignatura = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public override string ToString()
        {
            return "Nombre de Asignatura: " + nombre;
        }
    }
}
