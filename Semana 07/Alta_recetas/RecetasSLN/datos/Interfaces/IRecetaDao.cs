using RecetasLib.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos.Interfaces
{
    interface IRecetaDao
    {
        int ObtenerProximoNumero();
        List<Ingrediente> GetIngredientes();

        bool Crear(Receta oReceta);
    }
}
