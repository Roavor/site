using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingAccount
{
    class SavingAccounts
    {
        public static double currInterrestRate;
        public double currBalance;
        public SavingAccounts(double balace)
        {
            currBalance = balace;
            currInterrestRate = 0.04;
        }
        public static double GetInterestRate()
        {
            return currInterrestRate;
        }
        public static void SetInterestRate(double newRate)
        {
             currInterrestRate=newRate;
        }
        public static double InterestRate
        {
            get { return currInterrestRate; }
            set { currInterrestRate = value; }
        }
    }
}
