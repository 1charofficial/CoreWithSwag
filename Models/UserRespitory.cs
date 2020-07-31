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
        private static string connectionString = @"User ID = sa;Password = YourStrong@Passw0rd; catalog = ProductDatabase; Data Source = localhost, 5001;";


        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }

        public void AddUser(UserModel newUser)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"INSERT INTO UserModel(UserID, FirstName, LastName, Email, Age)VALUES(@UserID, @FirstName, @LastName, @Email, @Age)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, newUser);

            }

        }


        public IEnumerable<UserModel> ViewAllUsers()
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM UserModel";
                dbConnection.Open();
                return dbConnection.Query<UserModel>(sQuery);
            }

        }

        public UserModel ViewUserByID(int ID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                String sQuery = @"SELECT * FROM UserModel WHERE UserID=@UserID";
                dbConnection.Open();
                return dbConnection.Query<UserModel>(sQuery, new { ID }).FirstOrDefault();
            }
        }

        public void UpdateUser(UserModel newUser)
        {
            using (IDbConnection dbConnnection = Connection)
            {
                String sQuery = @"EXEC UpdateUser @UserID = UserID, @FirstName = FirstName, @LastName = LastName, @Email = Email";
                dbConnnection.Open();
                dbConnnection.Query(sQuery, newUser);
            }
        }

        public void DeleteByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                String sQuery = @"EXEC DeleteByID @UserID=@id";
                dbConnection.Open();
                dbConnection.Execute(sQuery, new { Is = id });

            }

        }




    }


}

