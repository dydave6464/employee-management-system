using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.IO;

namespace WinFormsApp1
{
    public partial class DashBoardForm : Form
    {
        private Connection conn = new Connection();
        public DashBoardForm()
        {
            InitializeComponent();
            viewActiveInactive1.Visible = false;
            displayEmployeeData(); // to display data from database to data grid view
        }

        private void signout_btn__Click(object sender, EventArgs e)
        {

        }

        private void signout_btn_Click(object sender, EventArgs e)
        {

        }

        private void logout_pic_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to sign out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void displayEmployeeData()
        {
            EmployeeData ed = new EmployeeData();
            List<EmployeeData> listData = ed.empListData();

            dataGridView1.DataSource = listData;
        }

        private void active_inactive_btn_Click(object sender, EventArgs e)
        {
            viewActiveInactive1.Visible = !viewActiveInactive1.Visible;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string employeeID = emp_tb.Text.Trim();
            string fullName = fullname_tb.Text.Trim();
            string gender = gender_cb.Text.Trim();
            string contactNum = contact_tb.Text.Trim();
            string salaryText = salary_tb.Text.Trim();
            string position = position_cb.Text.Trim();
            string status = status_cb.Text.Trim();

            if (string.IsNullOrEmpty(employeeID) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(gender) ||
                string.IsNullOrEmpty(contactNum) || string.IsNullOrEmpty(position) || string.IsNullOrEmpty(status) ||
                string.IsNullOrEmpty(salaryText) || !int.TryParse(salaryText, out int salary) || employee_picture.Image == null)
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using MySqlConnection sqlconnection = conn.connectToSql();

                    sqlconnection.Open();

                    string query = "SELECT COUNT(*) FROM employees WHERE pkEmpID = @empID";

                    using MySqlCommand checkEmp = new MySqlCommand(query, sqlconnection);

                    checkEmp.Parameters.AddWithValue("@empID", employeeID);

                    long count = (long)checkEmp.ExecuteScalar();

                    if (count >= 1)
                    {
                        MessageBox.Show(employeeID + " is already taken.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string path = Path.Combine(@"C:\Users\Debdeb\source\repos\WinFormsApp1\WinFormsApp1\Directory\"
                        + employeeID + ".jpg");

                        string directoryPath = Path.GetDirectoryName(path);

                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }
                        File.Copy(employee_picture.ImageLocation, path, true);

                        DateTime today = DateTime.Today;
                        string insertQuery = $"INSERT INTO employees (pkEmpID, full_name, gender, contact_number, salary, position, insert_date, status, image) VALUES (@empid, @fullname, @gender, @contact, @salary, @position, @insertDate, @status, @image)";
                        using MySqlCommand cmd = new MySqlCommand(insertQuery, sqlconnection);

                        cmd.Parameters.AddWithValue("@empid", employeeID);
                        cmd.Parameters.AddWithValue("@fullname", fullName);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@contact", contactNum);
                        cmd.Parameters.AddWithValue("@salary", salary);
                        cmd.Parameters.AddWithValue("@position", position);
                        cmd.Parameters.AddWithValue("@insertDate", today);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@image", path);

                        cmd.ExecuteNonQuery();
                        displayEmployeeData();

                        MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void import_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    employee_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
