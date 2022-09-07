using Carreras__SP.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Carreras__SP.Datos
{
    internal class Helper
    {

        private SqlConnection conexion = new SqlConnection(Properties.Resources.cadenaConexion);
        private SqlCommand comando = new SqlCommand();

        // Configurar Comando: asociarlo con un objeto conexión y asignarle propiedades Text y Type

        private void ConfigurarComando_SP(string SPNombre)
        {
            comando.Connection = conexion;
            comando.CommandText = SPNombre;
            comando.CommandType = CommandType.StoredProcedure;
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


        // Método Booleano que inserta tanto Maestro como Detalle utilizando una transacción


        public bool AltaCarrera(Carrera carrera)
        {
            bool respuesta = true;
            SqlTransaction transaccion = null;

            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();

                SqlCommand cmdMaestro = new SqlCommand("sp_insertar_carrera", conexion, transaccion);
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.Parameters.AddWithValue("@nombre", carrera.Nombre_Titulo);
                SqlParameter param = new SqlParameter("@new_id_carrera", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmdMaestro.Parameters.Add(param);
                cmdMaestro.ExecuteNonQuery();

                int idCarrera = Convert.ToInt32(param.Value);

                SqlCommand cmdDetalle = new SqlCommand("sp_insertar_detalleCarreras", conexion, transaccion);
                cmdDetalle.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < carrera.DetallesCarrera.Count; i++)
                {
                    cmdDetalle.Parameters.Clear();

                    cmdDetalle.Parameters.AddWithValue("@anioCursado", carrera.DetallesCarrera[i].AnioCursado);
                    cmdDetalle.Parameters.AddWithValue("@cuatrimestre", carrera.DetallesCarrera[i].Cuatrimestre);
                    cmdDetalle.Parameters.AddWithValue("@id_carrera", idCarrera);
                    cmdDetalle.Parameters.AddWithValue("@id_asignatura", carrera.DetallesCarrera[i].Asignatura.Codigo);

                    cmdDetalle.ExecuteNonQuery();
                }
                transaccion.Commit();
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                MessageBox.Show("Se produjo un error: " + ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                respuesta = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return respuesta;
        }




        public bool RegistrarBajaCarrera(int idCarrera)
        {
            bool respuesta = true;
            SqlTransaction transaccion = null;

            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                SqlCommand cmd = new SqlCommand("sp_eliminar_carrera", conexion, transaccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_carrera", idCarrera);
                respuesta = cmd.ExecuteNonQuery() == 1;

                transaccion.Commit();
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                respuesta = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return respuesta;
        }

        public DataTable ConsultarPlanCarrera(string nombre)
        {
            DataTable tabla = new DataTable();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("sp_consultar_detalleCarreras", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", nombre);

            tabla.Load(cmd.ExecuteReader());
            conexion.Close();
            return tabla;
        }
    }
}
