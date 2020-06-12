using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HIERARCHYIDApp
{
    public static class Repository
    {
        private static string ConnectionString = "Data Source=MyComputer\\SQLEXPRESS;Database=Demo;Trusted_Connection=True;MultipleActiveResultSets=true;";

        public static IEnumerable<T> Query<T>(string sqlCommand) where T : class
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                return conn.Query<T>(sqlCommand);
            }
        }
    }
}
