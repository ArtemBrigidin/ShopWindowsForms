using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using WinFormsApp4.Models;

namespace WinFormsApp4.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;
        public UserRepository(string conn)
        {
            _connectionString = conn;
        }

        public bool Login(User user)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                // count использовал с учётом того, что логин будет уникальным и что будет одно совпадение пары логина и пароля
                var sqlQuery = "SELECT COUNT(Id) FROM [Shop].[dbo].[Users] WHERE Login = @Login AND Password = @Password";
                var result = connection.Query<int>(sqlQuery, new { Login = user.Login, Password = user.Password }).Single();

                if (result == 1)
                    return true;
                return false;
            }
        }

        public void Create(User user)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "INSERT INTO [dbo].[Users] (Login, Password) VALUES(@Login, @Password)";
                db.Execute(sqlQuery, user);
            }
        }
    }
}
