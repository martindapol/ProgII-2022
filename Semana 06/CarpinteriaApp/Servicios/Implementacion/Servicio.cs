using CarpinteriaApp.datos.Implementacion;
using CarpinteriaApp.datos.Interfaz;
using CarpinteriaApp.dominio;
using CarpinteriaApp.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
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

        public bool ActualizarPresupuesto(Presupuesto presupuesto)
        {
            return dao.Actualizar(presupuesto);
        }

        public bool BorrarPresupuesto(int nro)
        {
            return dao.Borrar(nro);
        }

        public bool CrearPresupuesto(Presupuesto presupuesto)
        {
            return dao.Crear(presupuesto);
        }

        public Presupuesto ObtenerPresupuestoPorNro(int nro)
        {
            return dao.ObtenerPresupuestoPorNro(nro);
        }

        public List<Presupuesto> ObtenerPresupuestos(DateTime desde, DateTime hasta, string cliente)
        {
            return dao.ObtenerPresupuestosPorFiltros(desde, hasta, cliente);
        }

        public List<Producto> ObtenerProductos()
        {
            return dao.ObtenerProductos();
        }

        public DataTable ObtenerReporteProductos(DateTime desde, DateTime hasta)
        {
            return dao.ObtenerReporte(desde, hasta);
        }

        public int ProximoPresupuesto()
        {
            return dao.ObtenerProximoNro();
        }
    }
}
