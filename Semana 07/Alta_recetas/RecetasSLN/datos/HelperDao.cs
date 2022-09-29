using RecetasLib.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos
{
    class HelperDao
    {
        private static HelperDao instancia;
        private SqlConnection conexion;

        private HelperDao()
        {
            conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=recetas_db;Integrated Security=True");
        }
        public static HelperDao ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new HelperDao();
            return instancia;
        }
        public int ConsultarEscalar(string NombreSP, string NombreParametroSalida)
        {
            int aux;
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = NombreSP;
                SqlParameter paramOut = new SqlParameter();
                paramOut.ParameterName = NombreParametroSalida;
                paramOut.DbType = DbType.Int32;
                paramOut.Direction = ParameterDirection.Output;
                comando.Parameters.Add(paramOut);
                comando.ExecuteNonQuery();

                conexion.Close();
                aux = (int)paramOut.Value;
            }
            catch (Exception ex)
            {
                aux = 1;
            }
            return aux;
        }
        public DataTable Consultar(string NombreSP)
        {
            DataTable tabla = new DataTable();

            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = NombreSP;

            tabla.Load(comando.ExecuteReader());

            conexion.Close();
            return tabla;
        }


        public bool CrearMaestroDetalleReceta(string spMaestro, string spDetalle, Receta receta)
        {
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();

                SqlCommand comando = new SqlCommand(spMaestro, conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@tipo_receta", receta.TipoReceta);
                comando.Parameters.AddWithValue("@cheff", receta.Cheff);
                comando.Parameters.AddWithValue("@nombre", receta.Nombre);

                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@id";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                comando.Parameters.Add(pOut);

                comando.ExecuteNonQuery();
                int idReceta = (int)pOut.Value;

                SqlCommand comandoD = null;
                foreach (DetalleReceta det in receta.Detalles)
                {
                    comandoD = new SqlCommand(spDetalle, conexion, t);
                    comandoD.CommandType = CommandType.StoredProcedure;
                    comandoD.Parameters.AddWithValue("@id_receta", idReceta);
                    comandoD.Parameters.AddWithValue("@id_ingrediente", det.Ingrediente.IdIngrediente);
                    comandoD.Parameters.AddWithValue("@cantidad", det.Cantidad);
                    comandoD.ExecuteNonQuery();

                }

                t.Commit();
                aux = true;
            }
            catch (Exception ex)
            {
                if (t != null)
                    t.Rollback();
                
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return aux;

        }
    }
}
