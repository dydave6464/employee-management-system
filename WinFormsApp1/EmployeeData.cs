using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    class EmployeeData    
    {
        private Connection conn = new Connection();

        public int ID { get; set; }
        public string EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public int Salary { get; set; }
        public string Position { get; set; }
        public string Status { get; set; }
        public string Image { get; set; }

        //public EmployeeData(int id, string employeeID, string fullName, string gender, string contactNumber, int salary, string position, string status, string image)
        //{
        //    ID = id;
        //    EmployeeID = employeeID;
        //    FullName = fullName;
        //    Gender = gender;
        //    ContactNumber = contactNumber;
        //    Salary = salary;
        //    Position = position;
        //    Status = status;
        //    Image = image;
        //}

        public List<EmployeeData> empListData()
        {
            List<EmployeeData> listData = new List<EmployeeData>();

            try
            {
                using MySqlConnection sqlconnection = conn.connectToSql();

                sqlconnection.Open();

                string query = "SELECT * FROM employees WHERE delete_date IS NULL";

                using MySqlCommand cmd = new MySqlCommand(query, sqlconnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EmployeeData ed = new EmployeeData();
                    ed.ID = (int)reader["id"];
                    ed.EmployeeID = reader["pkEmpID"].ToString();
                    ed.FullName = reader["full_name"].ToString();
                    ed.Gender = reader["gender"].ToString();
                    ed.ContactNumber = reader["contact_number"].ToString();
                    ed.Salary = (int)reader["salary"];
                    ed.Position = reader["position"].ToString();
                    ed.Status = reader["status"].ToString();
                    ed.Image = reader["image"].ToString();

                    listData.Add(ed);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                
            }
            return listData;
        }
    }
}
