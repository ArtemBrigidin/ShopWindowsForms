using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp4.Models;

namespace WinFormsApp4.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly string _connectionString;
        public ProductRepository(string conn)
        {
            _connectionString = conn;
        }

        public void AddProduct(Product product)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "INSERT INTO Product (Name, ShopId) VALUES(@Name, @ShopId); SELECT CAST(SCOPE_IDENTITY() as int)";
                int? productId = db.Query<int>(sqlQuery, product).FirstOrDefault();
                product.ProductId = productId.Value;
                sqlQuery = $@"INSERT INTO ShopProduct (ShopId, ProductId) VALUES(@ShopId, {productId});";
                db.Query<int>(sqlQuery, product);
            }
        }

        public void DeleteProduct(Product product)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sqlQuery = $@"
                DECLARE @Pid INT;
                SET @productId = (SELECT ProductId FROM [dbo].[Product] P WHERE P.Name = @Name);
                DELETE FROM [dbo].[Product] WHERE Name = @Name
                DELETE FROM [dbo].ShopProduct WHERE ShopId = @ShopId AND ProductId = @productId";
                db.Execute(sqlQuery, product);
            }
        }
    }
}
