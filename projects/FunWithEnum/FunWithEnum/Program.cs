using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithEnum
{
    class Program
    {
        enum EmpType :byte
        {
            Manager=10,
            Grunt=1,
            Contractor=100,
            VicePresident=200
        }
        static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stokc options instead");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    break;
                
            }
        }
        //Этот метод выводит детали любого перечисления.
        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("Information about {0}",e.GetType().Name);
            Console.WriteLine("Underlying storage type: {0}",Enum.GetUnderlyingType(e.GetType()));
            //Получить все пары "имя/значение" для входного прараметра
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("Thisenum has {0} members.",enumData.Length);
            //Вывести строковое имя и ассоциированное значение,
            //используя флаг формата D
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}",enumData.GetValue(i));
            }
        }
        static void Main(string[] args)
        {
            EmpType emp = EmpType.Contractor;
            AskForBonus(emp);
            Console.WriteLine("Emptype uses a {0} for storage",Enum.GetUnderlyingType(emp.GetType()));
            //Или еще один способ Console.WriteLine("Emptype uses a {0} for storage",Enum.GetUnderlyingType(typeof(EmpType)));
            Console.WriteLine("emp is a {0}",emp.ToString());
            EmpType e2 = EmpType.Contractor;
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;
            EvaluateEnum(e2);
            EvaluateEnum(day);
            EvaluateEnum(cc);
            Console.ReadLine();
        }

    }
}
