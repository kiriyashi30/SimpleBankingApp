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
    public partial class WithdrawalTab : Form
    {
        private string currentUsername;
        private string currentPurpose = "Withdrawal";
        private decimal currentAmount;
        public WithdrawalTab(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }
        private void WithdrawalTabButton_Click(object sender, EventArgs e)
        {
            string input = WithdrawalTextBox.Text;

            // Validate the input amount
            if (decimal.TryParse(input, out decimal amount) && amount > 0)
            {
                if (UserAccount.Accounts.ContainsKey(currentUsername))
                {
                    var account = UserAccount.Accounts[currentUsername];

                    // Check if the account has sufficient balance
                    if (account.Balance >= amount)
                    {
                        // Update the account balance
                        account.Balance -= amount;
                        UserAccount.SaveAccounts();

                        currentAmount = amount;

                        UserAccount.AddReceipt(currentUsername, currentPurpose, currentAmount);

                        MessageBox.Show("Withdrawal successful!");

                        BankingForm bankingtab = new BankingForm(currentUsername);
                        bankingtab.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Insufficient balance!");
                    }
                }
                else
                {
                    MessageBox.Show("User not found!");
                }
            }
            else
            {
                MessageBox.Show("Invalid amount! Please enter a positive number.");
            }
        }

        private void WIthdrawalBack_Click(object sender, EventArgs e)
        {
            // Navigate back to the banking form
            BankingForm bankingtab = new BankingForm(currentUsername);
            bankingtab.Show();
            this.Hide();
        }

        private void button1000_Click(object sender, EventArgs e)
        {
            UpdateWithdrawalAmount(1000);
        }

        private void button500_Click(object sender, EventArgs e)
        {
            UpdateWithdrawalAmount(500);
        }

        private void button200_Click(object sender, EventArgs e)
        {
            UpdateWithdrawalAmount(200);
        }

        private void button100_Click(object sender, EventArgs e)
        {
            UpdateWithdrawalAmount(100);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            UpdateWithdrawalAmount(50);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            UpdateWithdrawalAmount(20);
        }
        private void UpdateWithdrawalAmount(int amount)
        {
            if (int.TryParse(WithdrawalTextBox.Text, out int currentValue))
            {
                currentValue += amount;
            }
            else
            {
                currentValue = amount;
            }
            WithdrawalTextBox.Text = currentValue.ToString();
        }
    }
}