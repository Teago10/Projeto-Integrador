using System.Configuration;
using Microsoft.Data.SqlClient;

namespace GestaoCuidadores.DataBase
{
    public static class ConexaoDB
    {
        public static SqlConnection GetConexao()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GestaoCuidadorDB"].ConnectionString;

            return new SqlConnection(connectionString);

        }
    }
}
