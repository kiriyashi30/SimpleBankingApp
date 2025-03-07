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
            Console.WriteLine($"BankingFormAccount constructor called. Username: {username}, AccountNum: {accountNum}"); // Debugging output

            // Check if accountNum is null or empty
            if (string.IsNullOrEmpty(accountNum))
            {
                Console.WriteLine("Error: accountNum is null or empty.");
                return;
            }

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
            Console.WriteLine("DisplayAllReceipts method called."); // Debugging output

            // Check if currentUsername is null or empty
            if (string.IsNullOrEmpty(currentUsername))
            {
                Console.WriteLine("Error: currentUsername is null or empty.");
                return;
            }

            // Check if the user has any receipts
            if (UserAccount.Receipts.ContainsKey(currentUsername) && UserAccount.Receipts[currentUsername].Count > 0)
            {
                // Get all receipts for the user
                var receipts = UserAccount.Receipts[currentUsername];

                // Debugging: Print the number of receipts
                Console.WriteLine($"Displaying {receipts.Count} receipts for user: {currentUsername}");

                // Build strings to display all receipts
                StringBuilder receiptDetailsPurpose = new StringBuilder();  
                StringBuilder receiptDetailsName = new StringBuilder();
                StringBuilder receiptDetailsTransactionDate = new StringBuilder();
                StringBuilder receiptDetailsTransactionTime = new StringBuilder();
                StringBuilder receiptDetailsAmount = new StringBuilder();

                foreach (var receipt in receipts)
                {
                    // Debugging: Print the receipt details
                    Console.WriteLine($"Purpose: {receipt.Purpose}, Date: {receipt.TransactionDate}, Amount: {receipt.Amount}");

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

                // Debugging: Print the combined receipt details
                Console.WriteLine("Purpose TextBox Content:");
                Console.WriteLine(receiptDetailsPurpose.ToString());

                Console.WriteLine("Name TextBox Content:");
                Console.WriteLine(receiptDetailsName.ToString());

                Console.WriteLine("Date TextBox Content:");
                Console.WriteLine(receiptDetailsTransactionDate.ToString());

                Console.WriteLine("Time TextBox Content:");
                Console.WriteLine(receiptDetailsTransactionTime.ToString());

                Console.WriteLine("Amount TextBox Content:");
                Console.WriteLine(receiptDetailsAmount.ToString());

                // Display the combined receipt details in the textboxes
                textBoxPurpose.Text = receiptDetailsPurpose.ToString();
                textBoxName.Text = receiptDetailsName.ToString();
                textBoxDate.Text = receiptDetailsTransactionDate.ToString();
                textBoxTime.Text = receiptDetailsTransactionTime.ToString();
                textBoxAmount.Text = receiptDetailsAmount.ToString();
            }
            else
            {
                // If no receipts are found, clear the textboxes or display a message
                textBoxPurpose.Text = "No receipts found."; 
                textBoxName.Text = "No receipts found.";
                textBoxDate.Text = "No receipts found.";
                textBoxTime.Text = "No receipts found.";
                textBoxAmount.Text = "No receipts found.";
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