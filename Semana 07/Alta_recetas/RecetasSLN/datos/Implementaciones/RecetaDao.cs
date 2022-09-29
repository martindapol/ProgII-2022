using RecetasLib.entidades;
using RecetasSLN.datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos.Implementaciones
{
    class RecetaDao : IRecetaDao
    {
        public List<Ingrediente> GetIngredientes()
        {
            List<Ingrediente> lst = new List<Ingrediente>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_INGREDIENTES");
            //MAPEO
            foreach (DataRow fila in tabla.Rows)
            {
                Ingrediente i = new Ingrediente();
                i.IdIngrediente = (int)fila["id_ingrediente"];
                i.Nombre = fila["n_ingrediente"].ToString();
                i.Unidad = fila["unidad_medida"].ToString();
                lst.Add(i);
            }
            return lst;
        }

        public int ObtenerProximoNumero()
        {
            return HelperDao.ObtenerInstancia().ConsultarEscalar("SP_PROXIMO_ID", "@next");
        }

        public bool Crear(Receta oReceta)
        {
            return HelperDao.ObtenerInstancia().CrearMaestroDetalleReceta("SP_INSERTAR_RECETA", "SP_INSERTAR_DETALLES", oReceta);
        }

    }
}
