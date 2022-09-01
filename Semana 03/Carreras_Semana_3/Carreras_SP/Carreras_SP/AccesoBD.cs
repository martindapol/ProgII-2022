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

        public bool AltaCarrera(Carrera carrera)
        {
            bool respuesta = true;
            SqlTransaction transaccion = null;

            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();

                SqlCommand cmdMaestro = new SqlCommand("SP_insertar_carrera", conexion, transaccion);
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@new_id_carrera", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmdMaestro.Parameters.Add(param);
                cmdMaestro.ExecuteNonQuery();

                int id_carrera = Convert.ToInt32(param.Value);
                SqlCommand comandoDetalle = new SqlCommand("SP_insertar_detalleCarreras", conexion, transaccion);
                comandoDetalle.CommandType = CommandType.StoredProcedure;
            
                for (int i = 0; i < carrera.DetallesCarrera.Count; i++)
                {
                    comandoDetalle.Parameters.Clear();
                    comandoDetalle.Parameters.AddWithValue("@anioCursado", carrera.DetallesCarrera[i].AnioCursado);
                    comandoDetalle.Parameters.AddWithValue("@cuatrimestre", carrera.DetallesCarrera[i].Cuatrimestre);
                    comandoDetalle.Parameters.AddWithValue("@id_asignatura", carrera.DetallesCarrera[i].Materia.Codigo);
                    comandoDetalle.Parameters.AddWithValue("@id_carrera", id_carrera);
                    comandoDetalle.ExecuteNonQuery();
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
            
        }

        public bool EliminarCarrera(int id_carrera)
        {
            conexion.Open();
            comando = new SqlCommand("sp_registrar_baja_carrera", conexion);
            comando.Parameters.AddWithValue("@id_carrera", id_carrera);
            int filas = comando.ExecuteNonQuery();
            conexion.Close();

            return filas == 1;

        }
    }
}
