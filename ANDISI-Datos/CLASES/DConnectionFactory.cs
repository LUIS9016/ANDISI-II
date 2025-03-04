using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace ANDISI_Datos
{
    public class DConnectionFactory
    {

        private readonly string ConnectionString = ConfigurationManager.ConnectionStrings["ConexionANDISIDB"].ToString();

        public IDbConnection GetConnectionMenuDinamico
        {
            get { return GetConnection(ConnectionString); }
        }

        

        public IDbConnection GetConnection(string pDataBase)
        {
            var connection = new SqlConnection();

            if (connection == null) return null;

            connection.ConnectionString = pDataBase;
            connection.Open();

            return connection;
        }



    }
}
