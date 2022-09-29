using RecetasLib.entidades;
using RecetasSLN.datos.Implementaciones;
using RecetasSLN.datos.Interfaces;
using RecetasSLN.servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.servicios.Implementaciones
{
    class Servicio : IServicio
    {
        private IRecetaDao oDao;
        public Servicio()
        {
            oDao = new RecetaDao();
        }

        public List<Ingrediente> ObtenerIngredientes()
        {
            return oDao.GetIngredientes();
        }

        public int ProximaReceta()
        {
            return oDao.ObtenerProximoNumero();
        }

        public bool GuardarReceta(Receta oReceta)
        {
            return oDao.Crear(oReceta);
        }
    }
}
