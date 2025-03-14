using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static SimpleBankingApp.UserAccount;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            label1.Text = $"Balance: ₱{UserAccount.Accounts[currentUsername].Balance.ToString("N2")}";

            // Update the account number label
            label5.Text = $"{UserAccount.Accounts[currentUsername].AccountNumber}";
        }

        private void DisplayAllReceipts()
        {
            Console.WriteLine("DisplayAllReceipts method called.");

            if (string.IsNullOrEmpty(currentUsername))
            {
                Console.WriteLine("Error: currentUsername is null or empty.");
                return;
            }

            if (UserAccount.Receipts.ContainsKey(currentUsername) && UserAccount.Receipts[currentUsername].Count > 0)
            {
                var receipts = UserAccount.Receipts[currentUsername];
                Console.WriteLine($"Displaying {receipts.Count} receipts for user: {currentUsername}");

                StringBuilder receiptDetailsPurpose = new StringBuilder();
                StringBuilder receiptDetailsName = new StringBuilder();
                StringBuilder receiptDetailsTransactionDate = new StringBuilder();
                StringBuilder receiptDetailsTransactionTime = new StringBuilder();
                StringBuilder receiptDetailsAmount = new StringBuilder();

                foreach (var receipt in receipts)
                {
                    Console.WriteLine($"Purpose: {receipt.Purpose}, Date: {receipt.TransactionDate}, Amount: {receipt.Amount}");

                    receiptDetailsPurpose.AppendLine($"{receipt.Purpose}");
                    receiptDetailsName.AppendLine($"{currentUsername}");
                    receiptDetailsTransactionDate.AppendLine($"{receipt.TransactionDate:yyyy-MM-dd}");
                    receiptDetailsTransactionTime.AppendLine($"{receipt.TransactionDate:HH:mm:ss}");
                    receiptDetailsAmount.AppendLine($"₱{receipt.Amount.ToString("N2")}");

                    // Append button click information if available
                    if (receipt.ButtonClicks != null && receipt.ButtonClicks.Count > 0)
                    {
                        double total = double.Parse(receipt.Amount.ToString("N2"));
                        List<int> subtractNumbers = new List<int> { 1000, 500, 200, 100};
                        var numberUsageCount = new Dictionary<int, int>();
                        subtractNumbers.Sort((a, b) => b.CompareTo(a));

                        foreach(var number in subtractNumbers)
        {
                            if (!numberUsageCount.ContainsKey(number))
                            {
                                numberUsageCount[number] = 0;
                            }
                        }
                        while (total > 0)
                        {
                            foreach (var number in subtractNumbers)
                            {
                                if (total >= number) // Only subtract if it's possible
                                {
                                    total -= number;
                                    numberUsageCount[number]++;

                                    // Exit the loop once a subtraction is made
                                    break;
                                }
                            }
                        }

                        receiptDetailsAmount.AppendLine("Bills received:");

                        foreach (var entry in numberUsageCount)
                        {
                            if (entry.Value > 0)
                            {
                                receiptDetailsAmount.AppendLine($"₱{entry.Key}:  {entry.Value}x");

                            }    
                        }
                        //foreach (var buttonClick in receipt.ButtonClicks)
                        //{
                        //    receiptDetailsAmount.AppendLine($"{buttonClick.Key}: {buttonClick.Value} clicks");
                        //}
                    }

                    // Add a separator after each receipt
                    receiptDetailsPurpose.AppendLine(new string('-', 30));
                    receiptDetailsName.AppendLine(new string('-', 30));
                    receiptDetailsTransactionDate.AppendLine(new string('-', 30));
                    receiptDetailsTransactionTime.AppendLine(new string('-', 30));
                    receiptDetailsAmount.AppendLine(new string('-', 30));
                }

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
                textBoxAmount.Text = receiptDetailsAmount.ToString(); // Includes button click information
            }
            else
            {
                Console.WriteLine("No receipts found for the user.");
                textBoxPurpose.Text = "No receipts found.";
                textBoxName.Text = "No receipts found.";
                textBoxDate.Text = "No receipts found.";
                textBoxTime.Text = "No receipts found.";
                textBoxAmount.Text = "No receipts found."; // Clear amount textbox
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