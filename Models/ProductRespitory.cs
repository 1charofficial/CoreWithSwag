using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using System.Data.SqlClient;





namespace CoreWithSwag.Models
{
    public class ProductRespitory
    {
        private static string connectionString = @"User ID = sa;Password = YourStrong@Passw0rd; catalog = MovieDatabase; Data Source = localhost, 5001;";


        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }


        public void Add(ProductModel newProduct)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"INSERT INTO ProductModel(ProdID, ProdName, ProdPrice, ProdTerm)VALUES(@ProdID, @ProdName, @ProdPrice, @ProdTerm)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, newProduct);

            }

        }


        public IEnumerable<ProductModel> ViewAllProds()
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM ProductModel";
                dbConnection.Open();
                return dbConnection.Query<ProductModel>(sQuery);
            }

        }

        public ProductModel ViewByID(int ID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                String sQuery = @"SELECT * FROM ProductModel WHERE ProdID=@ProdID";
                dbConnection.Open();
                return dbConnection.Query<ProductModel>(sQuery, new { ID }).FirstOrDefault();
            }
        }

        public void UpdateProduct(ProductModel newProduct)
        {
            using (IDbConnection dbConnnection = Connection)
            {
                String sQuery = @"EXEC UpdateProduct @ProdID = ProdID, @ProdName = ProdName, @ProdPrice = ProdPrice, @ProdTerm = ProdTerm";
                dbConnnection.Open();
                dbConnnection.Query(sQuery, newProduct);
            }
        }

        public void DeleteByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                String sQuery = @"EXEC DeleteByID @ProdID=@id";
                dbConnection.Open();
                dbConnection.Execute(sQuery, new { Is = id });

            }

        }



    }



       
}


