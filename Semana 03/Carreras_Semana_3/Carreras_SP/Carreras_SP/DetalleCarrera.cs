using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carreras_SP
{
    internal class DetalleCarrera
    {
        private int anioCursado, cuatrimestre;
        private Asignatura materia;

        public int AnioCursado
        {
            get { return anioCursado; }
            set { anioCursado = value; }
        }

        public int Cuatrimestre
        {
            get { return cuatrimestre; }
            set { cuatrimestre = value; }
        }

        public Asignatura Materia
        {
            get { return materia; }
            set { materia = value; }
        }

        public DetalleCarrera(int anioCursado, int cuatrimestre, Asignatura asignatura)
        {
            this.anioCursado = anioCursado;
            this.cuatrimestre = cuatrimestre;
            this.materia = asignatura;
        }

        public override string ToString()
        {
            return "Año cursado: " + anioCursado + " - Cuatrimestre: " + cuatrimestre +
                " - Asignatura" + materia.ToString();
        }

    }
}
