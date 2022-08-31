using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carreras_SP
{
    internal class Carrera
    {
        private int id_Carrera;
        private string nombreTitulo;
        private List<DetalleCarrera> detallesCarrera = new List<DetalleCarrera>();

        public int Id_carrera
        {
            get { return id_Carrera; }
        }

        public string Nombre_Titulo
        {
            get { return nombreTitulo; }
            set { nombreTitulo = value; }
        }

        public List<DetalleCarrera> DetallesCarrera
        {
            get { return detallesCarrera; }
            set { detallesCarrera = value; }
        }

        public override string ToString()
        {
            return "Nombre de Carrera: " + nombreTitulo;
        }

        public void AgregarDetalle(DetalleCarrera detalle)
        {
            detallesCarrera.Add(detalle);
        }

        public void EliminarDetalle(int id)
        {
            detallesCarrera.RemoveAt(id);
        }
    }
}
