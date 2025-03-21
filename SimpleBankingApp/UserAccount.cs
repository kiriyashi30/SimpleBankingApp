﻿using System;
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
        private static bool receiptsLoaded = false; // Flag to track if receipts are already loaded

        // Dictionary to store accounts
        public static Dictionary<string, Account> Accounts = new Dictionary<string, Account>();

        // Dictionary to store receipts (key: username, value: list of receipts)
        public static Dictionary<string, List<Receipt>> Receipts = new Dictionary<string, List<Receipt>>();

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
            public Dictionary<string, int> ButtonClicks { get; set; } // New property to store button clicks

            public override string ToString()
            {
                StringBuilder receiptContent = new StringBuilder();
                receiptContent.AppendLine($@"
---------------------------------
          TRANSACTION RECEIPT
---------------------------------
Date: {TransactionDate:yyyy-MM-dd}
Time: {TransactionDate:HH:mm:ss}
Purpose: {Purpose}
Amount: {Amount:C}
");

                if (ButtonClicks != null && ButtonClicks.Count > 0)
                {
                    receiptContent.AppendLine("Button Clicks:");
                    foreach (var buttonClick in ButtonClicks)
                    {
                        receiptContent.AppendLine($"{buttonClick.Key}: {buttonClick.Value} clicks");
                    }
                }

                receiptContent.AppendLine("---------------------------------");
                return receiptContent.ToString();
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
        public static void AddReceipt(string username, string purpose, decimal amount, Dictionary<string, int> buttonClicks = null)
        {
            if (!Accounts.ContainsKey(username))
            {
                return;
            }

            // Create a new receipt
            var receipt = new Receipt
            {
                Purpose = purpose,
                TransactionDate = DateTime.Now,
                Amount = amount,
                ButtonClicks = buttonClicks // Add button click information
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
        }

        public static void LoadReceipts()
        {
            if (receiptsLoaded)
            {
                Console.WriteLine("Receipts already loaded. Skipping reload.");
                return;
            }

            Console.WriteLine("LoadReceipts method called.");

            // Clear the Receipts dictionary before loading
            Receipts.Clear();

            // Ensure the receipts folder exists
            if (!Directory.Exists(receiptsBaseFolder))
            {
                Console.WriteLine("Receipts folder does not exist.");
                return;
            }

            // Iterate through each user's folder in the Receipts folder
            foreach (var userFolder in Directory.GetDirectories(receiptsBaseFolder))
            {
                string username = Path.GetFileName(userFolder); // Get the username from the folder name
                Console.WriteLine($"Loading receipts for user: {username}");

                // Initialize the receipt list for the user if it doesn't exist
                if (!Receipts.ContainsKey(username))
                {
                    Receipts[username] = new List<Receipt>();
                }

                // Iterate through each receipt file in the user's folder
                foreach (var receiptFile in Directory.GetFiles(userFolder, "*.txt"))
                {
                    Console.WriteLine($"Reading receipt file: {receiptFile}");

                    // Read the receipt content from the file
                    string receiptContent = File.ReadAllText(receiptFile);

                    // Parse the receipt content into a Receipt object
                    Receipt receipt = ParseReceiptFromContent(receiptContent);

                    // Add the receipt to the user's receipt list
                    if (receipt != null)
                    {
                        Receipts[username].Add(receipt);
                        Console.WriteLine($"Added receipt: {receipt}");
                    }
                    else
                    {
                        Console.WriteLine("Failed to parse receipt.");
                    }
                }
            }

            receiptsLoaded = true; // Mark receipts as loaded
        }
        private static Receipt ParseReceiptFromContent(string content)
        {
            try
            {
                // Extract the receipt details from the content
                string[] lines = content.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                // Ensure the receipt content has enough lines
                if (lines.Length < 8) // Adjusted for the extra space
                {
                    Console.WriteLine("Invalid receipt format: Not enough lines.");
                    return null;
                }

                // Parse the receipt details
                string dateLine = lines[4].Replace("Date: ", "").Trim(); // Line 4 contains the date
                string timeLine = lines[5].Replace("Time: ", "").Trim(); // Line 5 contains the time
                string purposeLine = lines[6].Replace("Purpose: ", "").Trim(); // Line 6 contains the purpose
                string amountLine = lines[7].Replace("Amount: ", "").Trim(); // Line 7 contains the amount

                // Combine date and time into a single DateTime object
                DateTime transactionDate = DateTime.Parse($"{dateLine} {timeLine}");
                decimal amount = decimal.Parse(amountLine, System.Globalization.NumberStyles.Currency);

                // Parse button click information if available
                Dictionary<string, int> buttonClicks = new Dictionary<string, int>();
                bool buttonClicksSection = false;

                for (int i = 8; i < lines.Length; i++) // Start from line 8 (after the basic receipt details)
                {
                    string line = lines[i].Trim();

                    if (line.StartsWith("Button Clicks:"))
                    {
                        buttonClicksSection = true;
                        continue; // Skip the "Button Clicks:" line
                    }

                    if (buttonClicksSection)
                    {
                        if (line.Contains(":"))
                        {
                            string[] parts = line.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                            if (parts.Length == 2)
                            {
                                string buttonName = parts[0].Trim();
                                if (int.TryParse(parts[1].Trim().Replace("clicks", "").Trim(), out int clicks))
                                {
                                    buttonClicks[buttonName] = clicks;
                                }
                            }
                        }
                        else if (line.StartsWith("---------------------------------"))
                        {
                            break; // End of button clicks section
                        }
                    }
                }

                // Create and return a new Receipt object
                return new Receipt
                {
                    Purpose = purposeLine,
                    TransactionDate = transactionDate,
                    Amount = amount,
                    ButtonClicks = buttonClicks.Count > 0 ? buttonClicks : null // Set button clicks if available
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing receipt: {ex.Message}");
                return null;
            }
        }
    }
}