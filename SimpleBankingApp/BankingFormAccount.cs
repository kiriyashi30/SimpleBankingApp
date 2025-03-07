using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static SimpleBankingApp.UserAccount;

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
            DisplayAllReceipts(); // Display all receipts for the user
        }

        private void UpdateBalanceLabel()
        {
            // Update the balance label
            label1.Text = $"Balance: {UserAccount.Accounts[currentUsername].Balance:C}";

            // Update the account number label
            label5.Text = $"{UserAccount.Accounts[currentUsername].AccountNumber}";
        }

        private void DisplayAllReceipts()
        {
            // Check if the user has any receipts
            if (UserAccount.Receipts.ContainsKey(currentUsername) && UserAccount.Receipts[currentUsername].Count > 0)
            {
                // Get all receipts for the user
                var receipts = UserAccount.Receipts[currentUsername];

                // Build strings to display all receipts
                StringBuilder receiptDetailsPurpose = new StringBuilder();
                StringBuilder receiptDetailsName = new StringBuilder();
                StringBuilder receiptDetailsTransactionDate = new StringBuilder();
                StringBuilder receiptDetailsTransactionTime = new StringBuilder();
                StringBuilder receiptDetailsAmount = new StringBuilder();

                foreach (var receipt in receipts)
                {
                    // Append receipt details to each StringBuilder
                    receiptDetailsPurpose.AppendLine($"{receipt.Purpose}");
                    receiptDetailsName.AppendLine($"{currentUsername}");
                    receiptDetailsTransactionDate.AppendLine($"{receipt.TransactionDate:yyyy-MM-dd}");
                    receiptDetailsTransactionTime.AppendLine($"{receipt.TransactionDate:HH:mm:ss}");
                    receiptDetailsAmount.AppendLine($"{receipt.Amount:C}");

                    // Add a separator after each receipt
                    receiptDetailsPurpose.AppendLine(new string('-', 30));
                    receiptDetailsName.AppendLine(new string('-', 30));
                    receiptDetailsTransactionDate.AppendLine(new string('-', 30));
                    receiptDetailsTransactionTime.AppendLine(new string('-', 30));
                    receiptDetailsAmount.AppendLine(new string('-', 30));
                }

                // Display the combined receipt details in the textboxes
                textBoxPurpose.Text = receiptDetailsPurpose.ToString();
                textBoxName.Text = receiptDetailsName.ToString();
                textBoxDate.Text = receiptDetailsTransactionDate.ToString();
                textBoxTime.Text = receiptDetailsTransactionTime.ToString();
                textBoxAmount.Text = receiptDetailsAmount.ToString();
            }
        }

        private void AccountBack_Click(object sender, EventArgs e)
        {
            // Navigate back to the BankingForm
            BankingForm bankingtab = new BankingForm(currentUsername);
            bankingtab.Show();
            this.Close();
        }
    }
}