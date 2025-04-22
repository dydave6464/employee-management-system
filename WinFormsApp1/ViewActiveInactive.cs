using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class ViewActiveInactive: UserControl
    {
        private Connection conn = new Connection();
        public ViewActiveInactive()
        {
            InitializeComponent();

            displayAE();
            displayIE();

        }

        public void displayAE()
        {
            try
            {
                using MySqlConnection sqlconnection = conn.connectToSql();
                sqlconnection.Open();

                string query = "SELECT COUNT(id) FROM employees WHERE status = @status AND delete_date IS NULL";

                using MySqlCommand cmd = new MySqlCommand(query, sqlconnection);

                cmd.Parameters.AddWithValue("@status", "Active");

                using MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int count = Convert.ToInt32(reader[0]);
                    AE_dashboard.Text = count.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void displayIE()
        {
            try
            {
                using MySqlConnection sqlconnection = conn.connectToSql();
                sqlconnection.Open();

                string query = "SELECT COUNT(id) FROM employees WHERE status = @status AND delete_date IS NULL";

                using MySqlCommand cmd = new MySqlCommand(query, sqlconnection);

                cmd.Parameters.AddWithValue("@status", "Inactive");

                using MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int count = Convert.ToInt32(reader[0]);
                    IE_dashboard.Text = count.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
