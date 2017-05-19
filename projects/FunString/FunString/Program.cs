using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunString
{
    class Program
    {
        static void BasicStringFunctionality ()
        {
            string firstname = "Freddy";
            Console.WriteLine("Value of first name: {0}",firstname);
            //Довжина
            Console.WriteLine("firstname nas {0} characters. ",firstname.Length);
            //У верхньому регістрі
            Console.WriteLine("firstname in uppcase: {0}",firstname.ToUpper());
            //у нижньому регістрі
            Console.WriteLine("firstname in lowercase:{0}",firstname.ToLower());
            //Змінна має букву у?
            Console.WriteLine("firstname contains the letter y?:{0}",firstname.Contains("y"));
            //Заміна
            Console.WriteLine("firesname after replace: {0}",firstname.Replace("dy",""));
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            BasicStringFunctionality();
        }
    }
}
