using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SimpleBankingApp
{
    public static class UserAccount
    {
        private static string filePath = "accounts.txt";
        private static string receiptsBaseFolder = "Receipts"; // Base folder for all receipts

        // Dictionary to store accounts
        public static Dictionary<string, Account> Accounts = new Dictionary<string, Account>();

        // Dictionary to store receipts (key: username, value: list of receipts)
        public static Dictionary<string, List<Receipt>> Receipts = new Dictionary<string, List<Receipt>>();

        static UserAccount()
        {
            // Ensure the base receipts folder exists
            if (!Directory.Exists(receiptsBaseFolder))
            {
                Directory.CreateDirectory(receiptsBaseFolder);
            }
        }

        public static void AddAccount(string username, string password)
        {
            if (!Accounts.ContainsKey(username))
            {
                string accountNumber = GenerateAdvancedAccountNumber(12);
                Accounts[username] = new Account { AccountNumber = accountNumber, Password = password, Balance = 0 };
                Receipts[username] = new List<Receipt>(); // Initialize an empty list of receipts for the user
                SaveAccounts();
            }
        }
        private static string GenerateAdvancedAccountNumber(int length)
        {
            if (length <= 0)
            {
                throw new ArgumentException("Length must be greater than 0.");
            }

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            StringBuilder accountNumber = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length);
                accountNumber.Append(chars[index]);
            }

            return accountNumber.ToString();
        }

        public class Account
        {
            public string AccountNumber { get; set; }
            public string Password { get; set; }
            public decimal Balance { get; set; }
        }

        public class Receipt
        {
            public string Purpose { get; set; } // Deposit or Withdrawal
            public DateTime TransactionDate { get; set; }
            public decimal Amount { get; set; }

            public override string ToString()
            {
                return $@"
---------------------------------
          TRANSACTION RECEIPT
---------------------------------
Date: {TransactionDate:yyyy-MM-dd}
Time: {TransactionDate:HH:mm:ss}
Purpose: {Purpose}
Amount: {Amount:C}
---------------------------------
";
            }
        }
        public static void LoadAccounts()
        {
            if (!File.Exists(filePath)) return;

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 4)
                {
                    string username = parts[0];
                    string accountNumber = parts[1];
                    string password = parts[2];
                    decimal balance = decimal.TryParse(parts[3], out var bal) ? bal : 0;

                    Accounts[username] = new Account { AccountNumber = accountNumber, Password = password, Balance = balance };
                    Receipts[username] = new List<Receipt>(); // Initialize an empty list of receipts for the user
                }
            }
        }

        public static void SaveAccounts()
        {
            var lines = Accounts.Select(acc => $"{acc.Key}:{acc.Value.AccountNumber}:{acc.Value.Password}:{acc.Value.Balance}");
            File.WriteAllLines(filePath, lines);
        }
        public static void AddReceipt(string username, string purpose, decimal amount)
        {
            if (!Accounts.ContainsKey(username))
            {
                Console.WriteLine("Username not found.");
                return;
            }

            // Create a new receipt
            var receipt = new Receipt
            {
                Purpose = purpose,
                TransactionDate = DateTime.Now,
                Amount = amount
            };

            // Add the receipt to the user's receipt list
            if (!Receipts.ContainsKey(username))
            {
                Receipts[username] = new List<Receipt>();
            }
            Receipts[username].Add(receipt);

            // Create a folder for the user if it doesn't exist
            string userReceiptsFolder = Path.Combine(receiptsBaseFolder, username);
            if (!Directory.Exists(userReceiptsFolder))
            {
                Directory.CreateDirectory(userReceiptsFolder);
            }

            // Save the receipt to a file in the user's folder
            string receiptFileName = $"{userReceiptsFolder}/{purpose}_{receipt.TransactionDate:yyyyMMdd_HHmmss}.txt";
            File.WriteAllText(receiptFileName, receipt.ToString());

            Console.WriteLine("Receipt added successfully!");
        }      
    }
}