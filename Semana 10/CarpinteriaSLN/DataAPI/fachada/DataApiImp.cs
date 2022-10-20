using CarpinteriaApp.datos.Implementacion;
using CarpinteriaApp.datos.Interfaz;
using CarpinteriaApp.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.fachada
{
    public class DataApiImp : IDataApi
    {
        private IDaoPresupuesto dao;

        public DataApiImp()
        {
            dao = new PresupuestoDao();
        }

        public List<Producto> GetProductos()
        {
            return dao.ObtenerProductos();
        }

        public bool SavePresupuesto(Presupuesto presupuesto)
        {
            return dao.Crear(presupuesto);
        }
    }
}
