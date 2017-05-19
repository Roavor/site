using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccounts s1 = new SavingAccounts(50);
            Console.WriteLine("Interest Rate is: {0}", SavingAccounts.GetInterestRate());
            SavingAccounts.SetInterestRate(0.08);
            SavingAccounts s2 = new SavingAccounts(100);
            Console.WriteLine("Interest Rate is: {0}",SavingAccounts.GetInterestRate());
            Console.WriteLine("Interest rate is: {0}",SavingAccounts.InterestRate);
            Console.ReadLine();
        }
    }
}
