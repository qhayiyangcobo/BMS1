using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BMS1
{
    public partial class fMainMenu : Form
    {
        public fMainMenu()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            fStartup fStartup = new fStartup();
            fStartup.Show();
        }

        private void btnAccDetails_Click(object sender, EventArgs e)
        {
            this.Close();
            fAccountDetails accountDetailsForm = new fAccountDetails();
            accountDetailsForm.Show();
        }

        private void btnCheckBal_Click(object sender, EventArgs e)
        {
            this.Close();
            fCheckBalance checkBalance = new fCheckBalance();
            checkBalance.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            this.Close();
            fWithdraw withdrawForm = new fWithdraw();
            withdrawForm.Show();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            this.Close();
            fDeposit depositForm = new fDeposit();
            depositForm.Show();
        }
    }
}
