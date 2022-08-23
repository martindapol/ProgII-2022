using CarpinteriaApp.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CarpinteriaApp.datos
{
    class HelperDB
    {
        private SqlConnection cnn; 

        public HelperDB()
        {
            cnn = new SqlConnection(Properties.Resources.cnnString); 
        }

        public DataTable ConsultaSQL(string strSql)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = strSql;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }



        public int EjecutarSQL(string strSql, CommandType type)
        {
            int afectadas = 0;
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = strSql;
            afectadas = cmd.ExecuteNonQuery();
            cnn.Close();

            return afectadas;
        }

        public int ProximoPresupuesto()
        {
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "SP_PROXIMO_ID";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = "@next";
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();    

            cnn.Close();
            return (int)pOut.Value;

        }

        public bool ConfirmarPresupuesto(Presupuesto oPresupuesto)
        {
            bool ok = true;

            SqlCommand cmd = new SqlCommand();

            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "SP_INSERTAR_MAESTRO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cliente", oPresupuesto.Cliente);
            cmd.Parameters.AddWithValue("@dto", oPresupuesto.Descuento);
            cmd.Parameters.AddWithValue("@total", oPresupuesto.CalcularTotal());

            //parámetro de salida:
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = "@presupuesto_nro";
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();

            int presupuestoNro = (int)pOut.Value;

            SqlCommand cmdDetalle;
            int detalleNro = 1;
            foreach(DetallePresupuesto item in oPresupuesto.Detalles)
            {
                cmdDetalle = new SqlCommand();

                cmdDetalle.Connection = cnn;
                cmdDetalle.CommandText = "SP_INSERTAR_MAESTRO";
                cmdDetalle.CommandType = CommandType.StoredProcedure;
                cmdDetalle.Parameters.AddWithValue("@presupuesto_nro", presupuestoNro);
                cmdDetalle.Parameters.AddWithValue("@detalle", detalleNro);
                cmdDetalle.Parameters.AddWithValue("@id_producto", item.Producto.ProductoNro);
                cmdDetalle.Parameters.AddWithValue("@cantidad", item.Cantidad);
                cmd.ExecuteNonQuery();


                detalleNro++;
            }

            cnn.Close();

            return ok;
        }
    }
}

