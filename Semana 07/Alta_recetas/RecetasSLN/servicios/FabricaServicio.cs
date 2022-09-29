using RecetasSLN.servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.servicios
{
    abstract class FabricaServicio
    {
        public abstract IServicio CrearServicio();
    }
}
