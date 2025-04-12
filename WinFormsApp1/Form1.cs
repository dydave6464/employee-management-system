using MySql.Data.MySqlClient;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Queries crud = new Queries();
        Connection conn = new Connection();
        public Form1()
        {
            InitializeComponent();
            crud.Read();
        }

        private void exit_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_link_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = login_username.Text;
            string password = login_password.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                try
                {
                    using MySqlConnection sqlconnection = conn.connectToSql();

                    sqlconnection.Open();

                    string checkCredential = $"SELECT * FROM users WHERE username = @username AND password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(checkCredential, sqlconnection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if(table.Rows.Count >= 1)
                        {
                            MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DashBoardForm dbForm = new DashBoardForm();
                            dbForm.Show();
                            this.Hide();
                        }
                        else 
                        {
                            MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        }

                    } 


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
                

        }
    }
}
