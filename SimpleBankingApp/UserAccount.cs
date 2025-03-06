using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Accounts[username] = new Account { Password = password, Balance = 0 };
                SaveAccounts();
            }
        }

        public class Account
        {
            public string Password { get; set; }
            public decimal Balance { get; set; }
        }

        public static void LoadAccounts()
        {
            if (!File.Exists(filePath)) return;

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                string[] parts = line.Split(':'); // Format: username:password:balance
                if (parts.Length == 3)
                {
                    string username = parts[0];
                    string password = parts[1];
                    decimal balance = decimal.TryParse(parts[2], out var bal) ? bal : 0;

                    Accounts[username] = new Account { Password = password, Balance = balance };
                }
            }
        }

        public static void SaveAccounts()
        {
            var lines = Accounts.Select(acc => $"{acc.Key}:{acc.Value.Password}:{acc.Value.Balance}");
            File.WriteAllLines(filePath, lines);
        }

        public static decimal GetBalance(string username)
        {
            return Accounts.ContainsKey(username) ? Accounts[username].Balance : 0;
        }
    }
}
