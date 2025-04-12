using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace WinFormsApp1
{
    class Queries
    {
        private Connection conn = new Connection();


        public void Read()
        {
            using MySqlConnection sqlconnection = conn.connectToSql();

            sqlconnection.Open();
            Console.WriteLine("Connection to database...");

            string query = "SELECT * FROM users";

            using MySqlCommand cmd = new MySqlCommand(query, sqlconnection);

            using MySqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("Executing query...");

            if (!reader.HasRows)
            {
                Console.WriteLine("No data found!");
                return;
            }

            //while (reader.Read())
            //{
            //    Console.WriteLine($"ID: {reader["pkEmpID"]}, User: {reader["username"]}");
            //}
        }

        public void InsertLogin(UserReg reg, MySqlConnection sqlConnection)
        {
            try
            {
                DateTime today = DateTime.Today;

                string query = "INSERT INTO users (username,password,date_register) VALUES (@username,@password,@date)";

                MySqlCommand cmd = new MySqlCommand(query, sqlConnection);

                cmd.Parameters.AddWithValue("@username", reg.Username);
                cmd.Parameters.AddWithValue("@password", reg.Password);
                cmd.Parameters.AddWithValue("@date", today);

                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowsAffected > 0 ? " User inserted successfully!" : " No rows inserted.");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void AddEmployee(EmployeeData empData, MySqlConnection sqlConnection)
        {
            DateTime today = DateTime.Today;
            try
            {
                using MySqlConnection sqlconnection = conn.connectToSql();
                string query = $"INSERT INTO employees (pkEmpID, full_name, gender, contact_number, salary, position, insert_date, status, image) VALUES (@id, @empid, @fullname, @gender, @contact, @salary, @position, @insertDate, @status, @image)";

                using MySqlCommand cmd = new MySqlCommand(query, sqlconnection);
                cmd.Parameters.AddWithValue("@empid", empData.EmployeeID);
                cmd.Parameters.AddWithValue("@fullname", empData.FullName);
                cmd.Parameters.AddWithValue("@gender", empData.Gender);
                cmd.Parameters.AddWithValue("@contact", empData.ContactNumber);
                cmd.Parameters.AddWithValue("@salary", empData.Salary);
                cmd.Parameters.AddWithValue("@position", empData.Position);
                cmd.Parameters.AddWithValue("@insertDate", today);
                cmd.Parameters.AddWithValue("@status", empData.Status);

                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowsAffected > 0 ? " User inserted successfully!" : " No rows inserted.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
               
            }
        }

    }
}
