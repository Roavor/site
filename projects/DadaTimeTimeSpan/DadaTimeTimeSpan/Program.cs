using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadaTimeTimeSpan
{
    class Program
    {
        static void UsesDateandTime()
        {
            //Конструктор приймає рік,місяць,день
            DateTime dt = new DateTime(2011, 10, 17);
            //Який день місяця?
            Console.WriteLine("The day of {0} is {1}",dt.Date,dt.DayOfWeek);
            //Зараз місяць Лютий
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings: {0}",dt.IsDaylightSavingTime());
            //Цей конструктор приймає години ,хвилини і секунди
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);
            //Відняти 15 хвилин із заданого TimeSpan і вивести результат
            Console.WriteLine(ts.Subtract(new TimeSpan(0,15,0)));

        }
        static void Main(string[] args)
        {
            UsesDateandTime();
            Console.ReadKey(); 
        }
    }
}
