using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class BankAccount
    {
        private static int initialcountnumber = 1231;
        List<Transaction> alltransactions = new List<Transaction>();
        public string Number { get; set; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in alltransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }
        public BankAccount(string name, decimal initialBalance)
        {
            this.Number = initialcountnumber.ToString();
            initialcountnumber++;
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");

        }
        public BankAccount() { }
        public void MakeDeposit(decimal amount, DateTime date, string notes)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Amount Should Be Positive");
            }
        }

        public void MakeWithdraw(decimal amount, DateTime date, string notes)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount Should Be Positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not Sufficient Fund");
            }
            var withdrawl = new Transaction(-amount, date, notes);
            alltransactions.Add(withdrawl);
        }
        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\t\tBalance\t\tNotes");
            foreach (var item in alltransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToString()}\t{item.Amount}\t{item.Notes}");
            }
            return report.ToString();
        }
    }
}
