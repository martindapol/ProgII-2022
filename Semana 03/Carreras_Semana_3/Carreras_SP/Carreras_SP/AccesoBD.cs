using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carreras_SP
{
    internal class AccesoBD
    {
        private SqlConnection conexion = new SqlConnection(Properties.Resources.cadenaConexion);
        private SqlCommand comando = new SqlCommand();

        private void ConfigurarComando_SP(string SPNombre)
        {
            comando.Connection = conexion;
            comando.CommandText = SPNombre;
            comando.CommandType = System.Data.CommandType.StoredProcedure;
        }

        public DataTable Consultar_SP(string SPNombre)
        {
            DataTable tabla = new DataTable();

            conexion.Open();
            ConfigurarComando_SP(SPNombre);
            tabla.Load(comando.ExecuteReader());

            conexion.Close();

            return tabla;
        }

        public int proximoId()
        {
            conexion.Open();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@next";
            parametro.DbType = DbType.Int32;
            parametro.Direction = ParameterDirection.Output;
            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();

            conexion.Close();
            return Convert.ToInt32(parametro.Value);

        }

        public bool AltaDetallesCarrera_SP(string SPNombre, int id_carrera, Carrera carrera)
        {
            bool respuesta = true;
            SqlTransaction transaccion = null;

            try
            {
                conexion.Open();
                ConfigurarComando_SP(SPNombre);
                transaccion = conexion.BeginTransaction();
                comando.Transaction = transaccion;

                for (int i = 0; i < carrera.DetallesCarrera.Count; i++)
                {
                    comando.Parameters.Clear();

                    comando.Parameters.AddWithValue("@anioCursado", carrera.DetallesCarrera[i].AnioCursado);
                    comando.Parameters.AddWithValue("@cuatrimestre", carrera.DetallesCarrera[i].Cuatrimestre);
                    comando.Parameters.AddWithValue("@id_asignatura", carrera.DetallesCarrera[i].Materia.Codigo);
                    comando.Parameters.AddWithValue("@id_carrera", id_carrera);

                    comando.ExecuteNonQuery();
                }
                transaccion.Commit();
            }
            catch (Exception)
            {
                transaccion.Rollback();
                respuesta = false;
            }
            finally
            {
                if(conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return respuesta;
        }

        public int AltaCarrera_SP(string SPName, Carrera carrera)
        {
            int id_carrera;

            conexion.Open();
            ConfigurarComando_SP(SPName);
            comando.Parameters.AddWithValue("@nombre", carrera.Nombre_Titulo);

            SqlParameter param = new SqlParameter("@new_id_carrera", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            comando.Parameters.Add(param);

            comando.ExecuteNonQuery();

            id_carrera = Convert.ToInt32(param.Value);

            conexion.Close();
            return id_carrera;
            ;
        }

    }
}
