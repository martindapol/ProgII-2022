using RecetasLib.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.servicios.Interfaces
{
    interface IServicio
    {
        int ProximaReceta();
        List<Ingrediente> ObtenerIngredientes();
        bool GuardarReceta(Receta oReceta);
    }
}
