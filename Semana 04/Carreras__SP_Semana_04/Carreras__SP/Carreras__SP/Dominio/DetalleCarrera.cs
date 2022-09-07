using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carreras__SP.Dominio
{
    internal class DetalleCarrera
    {
        private int anioCursado, cuatrimestre;
        private Asignatura asignatura;

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

        public Asignatura Asignatura
        {
            get { return asignatura; }
            set { asignatura = value; }
        }

        public DetalleCarrera(int anioCursado, int cuatrimestre, Asignatura asignatura)
        {
            this.anioCursado = anioCursado;
            this.cuatrimestre = cuatrimestre;
            this.asignatura = asignatura;
        }

        public override string ToString()
        {
            return "Año cursado: " + anioCursado + " - Cuatrimestre: " + cuatrimestre +
                " - Asignatura" + asignatura.ToString();
        }

    }
}
