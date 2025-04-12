using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public class Connection
    {
        private string connString;
        private MySqlConnection conn;

        public MySqlConnection connectToSql()
        {
            try
            {
                Env.Load();
                Console.WriteLine("Loading .env files");

                string server = Env.GetString("DB_SERVER");
                string port = Env.GetString("DB_PORT");
                string db = Env.GetString("MYSQL_DATABASE");
                string user = Env.GetString("MYSQL_USER");
                string pass = Env.GetString("MYSQL_PASSWORD");

                connString = $"server={server};database={db};uid={user};pwd={pass};";

                conn = new MySqlConnection(connString);

                if (conn == null)
                {
                    Console.WriteLine("Database connection failed!");
                }
                else 
                {
                    Console.WriteLine("Database connection successful.");
                }

                return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection error: " + ex.Message);
                return null;
              
            }
        }

    }
}
