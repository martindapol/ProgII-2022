using CarpinteriaApp.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.fachada
{
    public interface IDataApi
    {
        public List<Producto> GetProductos();
        public bool SavePresupuesto(Presupuesto presupuesto);
    }
}
