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
    public partial class BankingFormAccount : Form
    {

        private string currentUsername;
        private string currentAccountNum;
        public BankingFormAccount(string username, string accountNum)
        {
            InitializeComponent();
            currentUsername = username;
            currentAccountNum = accountNum;     
            UpdateBalanceLabel();
        }

        private void UpdateBalanceLabel()
        {
            label1.Text = $"Balance: {UserAccount.Accounts[currentUsername].Balance:C}";
            label5.Text = $"{UserAccount.Accounts[currentUsername].AccountNumber:C}";
        }

        private void AccountBack_Click(object sender, EventArgs e)
        {
            BankingForm bankingtab = new BankingForm(currentUsername);
            bankingtab.Show();
            this.Close();
        }
    }
}
