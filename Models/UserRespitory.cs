using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using System.Data.SqlClient;




namespace CoreWithSwag.Models
{
    public class UserRespitory
    {
        private static string connectionString = @"User ID = sa;Password = YourStrong@Passw0rd; catalog = MovieDatabase; Data Source = localhost, 5001;";


        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }
    }
}
