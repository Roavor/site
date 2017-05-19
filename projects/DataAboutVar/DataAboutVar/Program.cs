using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAboutVar
{
    class Program
    {
        static void DeclareImplicitVars()
        {
            //var не может применятся к полям
            //var не может применятся к возвращаемому значению  или типу параметра
            //Пример:public var MyMethod(var x,var y)
            //Локальным переменным обьявленым с помощью ключевого слова var
            //должно быть присвоено начальное значение в самом обьявлении
            //Нельзя присваивать null в качустве начального значения.ст 136
            var meInt = 0;
            var myBool = true;
            var meString = "Time,marches on...";
            Console.WriteLine(meInt.GetType().Name);
            Console.WriteLine(myBool.GetType().Name);
            Console.WriteLine(meString.GetType().Name);
        }
        static void Main(string[] args)
        {
            DeclareImplicitVars();
            Console.ReadKey();
        }
    }
}
