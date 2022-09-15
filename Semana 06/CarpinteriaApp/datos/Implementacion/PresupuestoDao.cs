using CarpinteriaApp.datos.Interfaz;
using CarpinteriaApp.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaApp.datos.Implementacion
{
    public class PresupuestoDao : IDaoPresupuesto
    {
        public int ObtenerProximoNro()
        {
            string sp = "SP_PROXIMO_ID";
            return HelperDB.ObtenerInstancia().ConsultaEscalarSQL(sp, "@next");
        }

        public List<Producto> ObtenerTodos()
        {
            List<Producto> lst = new List<Producto>();
            
            string sp = "SP_CONSULTAR_PRODUCTOS";
            DataTable t = HelperDB.ObtenerInstancia().ConsultaSQL(sp, null);

            foreach(DataRow dr in t.Rows)
            {
                //Mapear un registro a un objeto del modelo de dominio
                int nro = int.Parse(dr["id_producto"].ToString());
                string nombre = dr["n_producto"].ToString();
                double precio = double.Parse(dr["precio"].ToString());
                bool activo = dr["activo"].ToString().Equals("S");

                Producto aux = new Producto(nro, nombre, precio);
                aux.Activo = activo;
                lst.Add(aux);
                    
            }

            return lst;
        }
    }
}
