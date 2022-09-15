using CarpinteriaApp.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaApp.datos.Interfaz
{
    public interface IDaoPresupuesto
    {
        int ObtenerProximoNro();

        List<Producto> ObtenerTodos();
    }
}
