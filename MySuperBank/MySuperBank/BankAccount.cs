using System;

namespace MySuperBank
{
    public class BankAccount
    {
        public string Number { get;  }
        public string Owner { get; set; }
        public decimal Balance { get; }

        public BankAccount(string name, decimal intitialBalance)
        {
            Owner = name;
            Balance = intitialBalance;  
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
        }
    }
}
