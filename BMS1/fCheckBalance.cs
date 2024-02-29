using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BMS1
{
    public partial class fCheckBalance : Form
    {
        public fCheckBalance()
        {
            InitializeComponent();
        }

        private void lbGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            fMainMenu mainMenu = new fMainMenu();
            mainMenu.Show();
        }

        private void fCheckBalance_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = .\SQLEXPRESS; Initial Catalog = BMS1; Integrated Security = True; TrustServerCertificate = True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Users.idNumber, Users.username, Accounts.balance FROM Users INNER JOIN Accounts ON Users.idNumber = Accounts.idNumber WHERE username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", fStartup.un);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string accBal = reader["balance"].ToString();
                            

                            lbBalance.Text = accBal;
                            
                        }
                    }
                }
            }


        }
    }
}
