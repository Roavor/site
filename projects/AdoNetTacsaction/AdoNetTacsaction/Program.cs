using System;
using AutoLotConnetedLayer;
using System.Data;


namespace AdoNetTacsaction
{
    class Program
    {
        static void Main(string[] args)
        {
            bool throwEx = true;
            string userAnswer = string.Empty;
            Console.Write("Do you want to throw exception (Y or N): ");
            userAnswer = Console.ReadLine();
            if (userAnswer.ToLower()=="n")
            {
                throwEx = false;
            }
            InventoryDAL dal = new InventoryDAL();
            dal.OpenConnection(@"Data Source=(local)\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog = AutoLot ");
            Console.WriteLine("Methot credit risks");
            dal.ProcessCreditRisks(throwEx, 333);
            Console.WriteLine("Check CreditRisks table for results");
            Console.ReadLine();
        }
    }
}
