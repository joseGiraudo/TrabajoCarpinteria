using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCarpinteria.Datos
{
    public class HelperDAO
    {
        // en esta clase usamos el patron de diseño Singleton

        private static HelperDAO instance;
        private SqlConnection connection;
        private string connectionString = @"";
        
        // constructor privado para el singleton
        private HelperDAO()
        {
            connection = new SqlConnection(connectionString);
        }
        
        public static HelperDAO ObtenerInstancia()
        {
            if(instance == null)
            {
                instance = new HelperDAO();
            }
            return instance;
        }

        public int ConsultarEscalar(string nombreSP, string nombreParamOut)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombreParamOut;
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;

            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();

            connection.Close();

            return (int)parametro.Value;
        }
        public DataTable Consultar(string nombreSP)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            connection.Close();
            return tabla;
        }
        public DataTable Consultar(string nombreSP, List<Parametro> listParam)
        {
            connection.Open();

            // configuro el comando con el SP pasado por parametros
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nombreSP;

            command.Parameters.Clear();

            foreach (Parametro param in listParam)
            {
                command.Parameters.AddWithValue(param.Nombre, param.Valor);
            }

            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());

            connection.Close();

            return table;
        }

    }
}
