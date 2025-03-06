using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace SimpleBankingApp
{


    public partial class BankingForm : Form
    {

        private string currentUsername;

        public BankingForm(string username)
        {
            InitializeComponent();
            currentUsername = username;
            UpdateBalanceLabel();
            lblWelcome.Text = $"Welcome, {currentUsername}!";
        }

        private void UpdateBalanceLabel()
        {
            textBox2.Text = $"Balance: {UserAccount.Accounts[currentUsername].Balance:C}";
        }

        private void BankingForm_Load(object sender, EventArgs e)
        {

        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            WithdrawalTab withdrawal = new WithdrawalTab(currentUsername);
            withdrawal.Show();
            this.Hide();
        }
        private void Deposit_Click(object sender, EventArgs e)
        {
            DepositTab deposit = new DepositTab(currentUsername);
            deposit.Show();
            this.Hide();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            UpdateBalanceLabel();
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }
        private void DepositButton2_Click(object sender, EventArgs e)
        {
            DepositTab deposit = new DepositTab(currentUsername);
            deposit.Show();
            this.Hide();
        }

        private void WithdrawalButton2_Click(object sender, EventArgs e)
        {
            WithdrawalTab withdrawal = new WithdrawalTab(currentUsername);
            withdrawal.Show();
            this.Hide();
        }

        private void ToggleViewBox_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void AccountCenterButton_Click(object sender, EventArgs e)
        {
            BankingFormAccount bankingAccount = new BankingFormAccount();
            bankingAccount.Show();
            this.Close();

        }
    }
}
