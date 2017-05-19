using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
     class Program
    {
        static void Main(string[] args)
        {
            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-22-2333", 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();
            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "944-33-2222", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();
            Console.ReadLine();
        }
    }
}
