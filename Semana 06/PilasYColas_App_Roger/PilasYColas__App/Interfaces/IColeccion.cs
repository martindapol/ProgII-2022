using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasYColas__App.Interfaces
{
    internal interface IColeccion
    {
        bool agregar(object elemento);
        object extraer();
        bool listaVacia();
        object cantidadElementos();
        object primerElemento();
        object proximoEnSalir();
    }

}

