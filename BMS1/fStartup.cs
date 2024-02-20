using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS1
{
    public partial class fStartup : Form
    {
        public fStartup()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCreateAccount createAccountForm = new fCreateAccount();
            createAccountForm.Show();
        }

        public static string un;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            un = tbUsername.Text;

            string connectionString = @"Data Source = LAPTOP-IH87CTS5\SQLEXPRESS; Initial Catalog = BMS1; Integrated Security = True; TrustServerCertificate = True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE username = @Username AND password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int result = (int)command.ExecuteScalar();

                    if (result > 0)
                    {
                        this.Hide();
                        fMainMenu mainMenuForm = new fMainMenu();
                        mainMenuForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }
                }
                connection.Close();
            }

        }
    }
}
