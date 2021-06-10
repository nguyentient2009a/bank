using System;
using MySql.Data.MySqlClient;
using SpringHeroBank.helper;

namespace SpringHeroBank
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // MySqlConnection cnn = DbConnectionHelper.GetConnection();
            // MySqlCommand mySqlCommand = cnn.CreateCommand();// createStatement
            // string name = "Luyen";
            // mySqlCommand.CommandText = $"insert into users (name) values ('{name}')";
            // Console.WriteLine(mySqlCommand.CommandText);
            // mySqlCommand.ExecuteNonQuery();
            // Connection -> Statement (Command) -> Execute -> Reader
            MySqlConnection cnn = DbConnectionHelper.GetConnection();
            MySqlCommand mySqlCommand = cnn.CreateCommand();
            mySqlCommand.CommandText = $"select * from users";
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                string name = reader.GetString("name");
                Console.WriteLine($"Id: {id}, name: {name}");
            }
        }
    }
}