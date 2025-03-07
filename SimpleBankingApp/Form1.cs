using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SimpleBankingApp
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UserAccount.LoadAccounts();
            UserAccount.LoadReceipts();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (txtUsername == null || txtPassword == null)
            {
                MessageBox.Show("Username and Password fields are missing.");
                return;
            }

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and Password cannot be empty.");
                return;
            }

            if (UserAccount.Accounts.TryGetValue(username, out var account) && account.Password == password)
            {
                BankingForm bankingForm = new BankingForm(username);
                bankingForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }


        }

        private void createAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
            this.Hide();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
