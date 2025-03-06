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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsernameSignUp.Text.Trim();
            string password = txtPasswordSignUp.Text.Trim();

            // Validate input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and Password cannot be empty.");
                return;
            }

            if (username == "Username" || username == "username" || password == "password" || password == "Password")
            {
                MessageBox.Show("Invalid input.");
                return;
            }

            // Check if the username already exists
            if (UserAccount.Accounts.ContainsKey(username))
            {
                MessageBox.Show("Username already exists!");
            }
            else
            {
                // Add new account to dictionary and file
                UserAccount.AddAccount(username, password);
                MessageBox.Show("Account created successfully!");

                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
        }

        private void BackSignUp_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
