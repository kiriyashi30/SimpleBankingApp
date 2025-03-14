using System;
using System.Windows.Forms;

namespace SimpleBankingApp
{
    public partial class DepositTab : Form
    {
        private string currentUsername;
        private string currentPurpose = "Deposit";

        public DepositTab(string username)
        {
            InitializeComponent();
            currentUsername = username;

            DepositTextBox.KeyPress += DepositTextBox_KeyPress;
        }

        private void DepositTabButton_Click(object sender, EventArgs e)
        {
            // Validate username
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

            // Check if the username exists in the accounts
            if (!UserAccount.Accounts.TryGetValue(currentUsername, out var account))
            {
                MessageBox.Show("Username not found!");
                return;
            }

            // Validate the deposit amount
            string inputAmount = DepositTextBox.Text;
            if (string.IsNullOrWhiteSpace(inputAmount) ||
                !decimal.TryParse(inputAmount, out decimal depositAmount) ||
                depositAmount <= 0)
            {
                MessageBox.Show("Invalid amount! Please enter a positive number.");
                return;
            }

            // Deposit the valid amount
            account.Balance += depositAmount;
            MessageBox.Show($"Successfully deposited ₱{depositAmount.ToString("N2")}\nYour Current Balance is: ₱" + account.Balance);

            // Save the updated account balance
            UserAccount.SaveAccounts();

            // Generate a receipt for the deposit
            UserAccount.AddReceipt(currentUsername, currentPurpose, depositAmount);

            // Navigate back to the BankingForm
            BankingForm bankingtab = new BankingForm(currentUsername);
            bankingtab.Show();
            this.Close();
        }

        private void DepositBack_Click(object sender, EventArgs e)
        {
            // Navigate back to the BankingForm
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

            // Allow only numeric characters and one decimal point
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
    }
}