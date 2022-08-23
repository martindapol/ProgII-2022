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
        private SqlConnection conexion = new SqlConnection(
            @"Data Source=DESKTOP-E0U8FA9\SQLSERVER19;Initial Catalog=CarrerasBD_Local;Integrated Security=True");
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

        public void AltaDetallesCarrera_SP(string SPNombre, int id_carrera, Carrera carrera)
        {
            conexion.Open();
            ConfigurarComando_SP(SPNombre);

            for (int i = 0; i < carrera.DetallesCarrera.Count; i++)
            {
                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@anioCursado", carrera.DetallesCarrera[i].AnioCursado);
                comando.Parameters.AddWithValue("@cuatrimestre", carrera.DetallesCarrera[i].Cuatrimestre);
                comando.Parameters.AddWithValue("@id_asignatura", carrera.DetallesCarrera[i].Materia.Codigo);
                comando.Parameters.AddWithValue("@id_carrera", id_carrera);

                comando.ExecuteNonQuery();
            }

            conexion.Close();
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
