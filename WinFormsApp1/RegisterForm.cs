using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class RegisterForm : Form
    {
        Queries crud = new Queries();
        Connection conn = new Connection();
        public RegisterForm()
        {
            InitializeComponent();
            crud.Read();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_loginlink_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            string username = signup_username.Text;
            string password = signup_password.Text;

            if (username == "" ||
                password == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using MySqlConnection sqlConnection = conn.connectToSql();

            if (sqlConnection == null)
            {
                MessageBox.Show("Databse connection failed. Please check your connection settings.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sqlConnection.Open();

            string selectUsername = $"SELECT COUNT(pkEmpID) FROM users WHERE username = @user";

            using MySqlCommand checkUser = new MySqlCommand(selectUsername, sqlConnection);

            checkUser.Parameters.AddWithValue("@user", username);

            long count = (long)checkUser.ExecuteScalar();

            if (count >= 1)
            {
                MessageBox.Show(username + " is already taken.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            {
                UserReg user = new UserReg(username, password);

                crud.InsertLogin(user, sqlConnection);

                MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }

           
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showPass.Checked ? '\0' : '*';
        }
    }
}
