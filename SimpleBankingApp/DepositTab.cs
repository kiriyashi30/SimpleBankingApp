using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBankingApp
{
    public partial class DepositTab : Form
    {

        private string currentUsername;

        public DepositTab(string username)
        {
            InitializeComponent();
            currentUsername = username;

            DepositTextBox.KeyPress += DepositTextBox_KeyPress;
            DepositTextBox.TextChanged += DepositTextBox_TextChanged;
        }

        private void DepositTabButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(currentUsername))
            {
                MessageBox.Show("Username is not provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Accounts dictionary
            if (UserAccount.Accounts == null)
            {
                MessageBox.Show("Accounts database is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!UserAccount.Accounts.TryGetValue(currentUsername, out var account))
            {
                MessageBox.Show("Username not found!");
                return;
            }

            string inputAmount = DepositTextBox.Text;

            if (string.IsNullOrWhiteSpace(inputAmount) ||
                !decimal.TryParse(inputAmount, out decimal depositAmount) ||
                depositAmount <= 0)
            {
                MessageBox.Show("Invalid amount! Please enter a positive number.");
                return;
            }
            else
            {
                // Deposit the valid amount
                account.Balance += depositAmount;
                MessageBox.Show($"Successfully deposited {depositAmount:C}!");

                UserAccount.SaveAccounts();

                BankingForm bankingtab = new BankingForm(currentUsername);
                bankingtab.Show();
                this.Close();
            }
        }

        private void DepositBack_Click(object sender, EventArgs e)
        {
            BankingForm bankingtab = new BankingForm(currentUsername);
            bankingtab.Show();
            this.Close();
        }

        private void DepositTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (like backspace)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow only numeric characters
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void DepositTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
