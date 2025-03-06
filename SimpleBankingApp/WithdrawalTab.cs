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

namespace SimpleBankingApp
{
    public partial class WithdrawalTab : Form
    {
        private string currentUsername;

        public WithdrawalTab(string username)
        {
            InitializeComponent();
            currentUsername = username;

            WithdrawalTextBox.KeyPress += WithdrawalTextBox_KeyPress;
            WithdrawalTextBox.TextChanged += WithdrawalTextBox_TextChanged;
        }

        private void WithdrawalTabButton_Click(object sender, EventArgs e)
        {
            string input = WithdrawalTextBox.Text;
            if (decimal.TryParse(input, out decimal amount) && amount > 0)
            {
                if (UserAccount.Accounts.ContainsKey(currentUsername))
                {
                    var account = UserAccount.Accounts[currentUsername];

                    if (account.Balance >= amount)
                    {
                        account.Balance -= amount;
                        UserAccount.SaveAccounts();
                        MessageBox.Show("Withdrawal successful!");

                        UserAccount.SaveAccounts();

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
                MessageBox.Show("Invalid amount!");
            }
        }

        private void WIthdrawalBack_Click(object sender, EventArgs e)
        {
            BankingForm bankingtab = new BankingForm(currentUsername);
            bankingtab.Show();
            this.Hide();
        }

        private void WithdrawalTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void WithdrawalTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
