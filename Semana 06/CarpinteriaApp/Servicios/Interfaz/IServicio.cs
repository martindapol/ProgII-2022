using CarpinteriaApp.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaApp.Servicios.Interfaz
{
    public interface IServicio
    {   
        int ProximoPresupuesto();
        List<Producto> ObtenerProductos();
        bool CrearPresupuesto(Presupuesto presupuesto);
        bool ActualizarPresupuesto(Presupuesto presupuesto);
        bool BorrarPresupuesto(int nro);

        List<Presupuesto> ObtenerPresupuestos(DateTime desde, DateTime hasta, string cliente);
        DataTable ObtenerReporteProductos(DateTime desde, DateTime hasta);
        Presupuesto ObtenerPresupuestoPorNro(int nro);
    
    }
}
