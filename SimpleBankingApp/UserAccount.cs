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

        public static Dictionary<string, Account> Accounts = new Dictionary<string, Account>();
        public static void AddAccount(string username, string password)
        {
            if (!Accounts.ContainsKey(username))
            {
                string accountNumber = GenerateAdvancedAccountNumber(12);
                Accounts[username] = new Account { AccountNumber = accountNumber, Password = password, Balance = 0 };
                SaveAccounts();
                Console.WriteLine($"Account created successfully!");
            }
            else
            {
                Console.WriteLine("Username already exists.");
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
                }
            }
        }

        public static void SaveAccounts()
        {
            var lines = Accounts.Select(acc => $"{acc.Key}:{acc.Value.AccountNumber}:{acc.Value.Password}:{acc.Value.Balance}");
            File.WriteAllLines(filePath, lines);
        }
    }
}