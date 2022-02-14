using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Austin",10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");
        }
    }
}
