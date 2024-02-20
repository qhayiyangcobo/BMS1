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
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BMS1
{
    public partial class fAccountDetails : Form
    {
        public fAccountDetails()
        {
            InitializeComponent();
        }

        private void fAccountDetails_Load(object sender, EventArgs e)
        {

            string connectionString = @"Data Source = LAPTOP-IH87CTS5\SQLEXPRESS; Initial Catalog = BMS1; Integrated Security = True; TrustServerCertificate = True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Users WHERE username = @Username";
                string query2 = "SELECT Users.idNumber, Users.username, Accounts.accountNumber, Accounts.accountType FROM Users INNER JOIN Accounts ON Users.idNumber = Accounts.idNumber WHERE username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username",fStartup.un);

                    

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string idNum = reader["idNumber"].ToString();
                            string name = reader["name"].ToString();
                            string surname = reader["surname"].ToString();
                            string emailAdd = reader["emailAddress"].ToString();
                            string cellNum = reader["cellphoneNumber"].ToString();

                            lbIdNum.Text = idNum;
                            lbName.Text = name;
                            lbSurname.Text = surname;
                            lbEmailAdd.Text = emailAdd;
                            lbCellNum.Text = cellNum;
                        }
                    }
                }

                SqlCommand command2 = new SqlCommand(query2, connection);
                command2.Parameters.AddWithValue("@Username", fStartup.un);

                using (SqlDataReader reader2 = command2.ExecuteReader())
                {
                    if (reader2.Read())
                    {
                        string accNum = reader2["accountNumber"].ToString();
                        string accType = reader2["accountType"].ToString();

                        lbAccountNum.Text = accNum;
                        lbAccType.Text = accType;
                    }
                }
                connection.Close();
            }
        }

        private void lbGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            fMainMenu mainMenuForm = new fMainMenu();
            mainMenuForm.Show();
        }
    }
}
