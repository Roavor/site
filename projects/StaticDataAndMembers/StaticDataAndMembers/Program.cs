using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount s1 = new SavingAccount(50);
            Console.WriteLine("s1:"+SavingAccount.GetInterestRate());
            SavingAccount.SetInterestRate(0.08);
            SavingAccount s2 = new SavingAccount(100);
            Console.WriteLine("s2:"+SavingAccount.GetInterestRate());
            SavingAccount s3 = new SavingAccount(10000);
            Console.ReadLine();
        }
    }
}
