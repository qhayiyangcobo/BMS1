using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS1
{
    public partial class fCreateAccount : Form
    {
        public fCreateAccount()
        {
            InitializeComponent();
        }

        

        private void lbGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            fStartup startupForm = new fStartup();
            startupForm.Show();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string idNum = tbIdNum.Text;
            string name = tbName.Text;
            string surname = tbSurname.Text;
            string email = tbEmailAddress.Text;
            string cellNum = tbCellNum.Text;
            string accType = cbAccType.SelectedItem.ToString();
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string accNum = random.Next(00000001, 99999999).ToString();
            decimal bal = 0.00m;
            

            string connectionString = @"Data Source = .\SQLEXPRESS; Initial Catalog = BMS1; Integrated Security = True; TrustServerCertificate = True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (idNumber, name, surname, emailAddress, cellphoneNumber, username, password)" +
                    "VALUES (@idNumber, @name, @surname, @emailAddress, @cellphoneNumber, @username, @password)";

                string query2 = "INSERT INTO Accounts (accountNumber, accountType, balance, idNumber)" +
                    "VALUES (@accountNumber, @accountType, @balance, @idNumber)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idNumber", idNum);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@emailAddress", email);
                    command.Parameters.AddWithValue("@cellphoneNumber", cellNum);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    SqlCommand commandDetails = new SqlCommand(query2, connection);
                    
                        commandDetails.Parameters.AddWithValue("@accountNumber", accNum);
                        commandDetails.Parameters.AddWithValue("@accountType", accType);
                        commandDetails.Parameters.AddWithValue("@balance", bal);
                        commandDetails.Parameters.AddWithValue("@idNumber", idNum);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    int rowsAffected2 = commandDetails.ExecuteNonQuery();

                    if (rowsAffected > 0 && rowsAffected2 > 0)
                    {
                        MessageBox.Show("Congratulations, Account Created Succesfully!");
                        
                        this.Close();
                        fStartup fStartup = new fStartup();
                        fStartup.Show();
                    }
                    else
                    {
                        MessageBox.Show("Account Creation Unsuccesfull.");
                    }
                    connection.Close();
                }
            }

        }
    }
}
