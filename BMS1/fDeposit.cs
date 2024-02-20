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

namespace BMS1
{
    public partial class fDeposit : Form
    {
        public fDeposit()
        {
            InitializeComponent();
        }

        private void lbGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            fMainMenu mainMenuForm = new fMainMenu();
            mainMenuForm.Show();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            decimal depositAmt = Convert.ToDecimal(tbDeposit.Text);
            string connectionString = @"Data Source = LAPTOP-IH87CTS5\SQLEXPRESS; Initial Catalog = BMS1; Integrated Security = True; TrustServerCertificate = True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Accounts SET Accounts.balance = Accounts.balance + @DepositAmount FROM Accounts INNER JOIN Users ON Users.idNumber = Accounts.idNumber WHERE Users.username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", fStartup.un);
                    command.Parameters.AddWithValue("@DepositAmount", depositAmt);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Amount successfully added to the balance.");

                        this.Close();
                        fMainMenu mainMenuForm = new fMainMenu();
                        mainMenuForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Could not deposit specified amount.");
                    }
                }
                connection.Close();
            }
        }

        private void tbDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
