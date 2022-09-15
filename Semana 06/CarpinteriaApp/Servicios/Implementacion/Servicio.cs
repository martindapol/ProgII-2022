using CarpinteriaApp.datos.Implementacion;
using CarpinteriaApp.datos.Interfaz;
using CarpinteriaApp.dominio;
using CarpinteriaApp.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaApp.Servicios.Implementacion
{
    public class Servicio : IServicio
    {
        private IDaoPresupuesto dao;

        public Servicio()
        {
            dao = new PresupuestoDao();
        }

        public List<Producto> ObtenerProductos()
        {
            return dao.ObtenerTodos();
        }

        public int ProximoPresupuesto()
        {
            return dao.ObtenerProximoNro();
        }
    }
}
