// filepath: Population.DataAccess/DatabaseHelper.cs
using MySql.Data.MySqlClient;

namespace Population.DataAccess
{
    public static class DatabaseHelper
    {
        private const string ConnectionString = "Server=localhost;Database=world;User=root;Password=awais;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}