using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace SpringHeroBank.helper
{
    /*
     * Kết nối đến cơ sở dữ liệu, đảm bảo kết nối là duy nhất.    
     */
    public class DbConnectionHelper
    {
        private const string DatabaseName = "T2009A";
        private const string ServerName = "127.0.0.1";
        private const string ServerPort = "3306";
        private const string Uid = "root";
        private const string Password = "";
        private const string SslMode = "none";
        private const string PersistSecurityInfo = "True";
        
        public DbConnectionHelper()
        {
        }

        private static MySqlConnection _connection = null;
        

        public static MySqlConnection GetConnection()
        {
            if (_connection == null)
            {   
                string connectionString =
                    $"Server={ServerName}; database={DatabaseName}; UID={Uid}; password={Password}; persistsecurityinfo={PersistSecurityInfo};port={ServerPort};SslMode={SslMode}";
                _connection = new MySqlConnection(connectionString);
                _connection.Open();
            }else if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            return _connection;
        }
    }
}