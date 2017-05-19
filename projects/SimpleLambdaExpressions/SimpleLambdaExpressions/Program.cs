using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLambdaExpressions
{
    class Program
    {

        /*static void TraditionalDelegateSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int [] { 20, 1, 4, 8, 9, 44 });
            Predicate < int > callback= new Predicate<int>(IsEvenNumber);
            List<int> evenNumbers = list.FindAll(callback);
            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.WriteLine("{0}/t",evenNumber);
            }
            Console.WriteLine();
        }
        static bool IsEvenNumber(int i)
        {
            return (i % 2) == 0;
        }*/
        static void AnonymysMethodSyntax()
        {
            int sum = 0;
            int count = 1;
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
            List<int> evenNumbers = list.FindAll(i => { return (i % 2) == 0; });
            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.WriteLine($"Sum: {sum}, Count: {count}");
                Console.WriteLine("{0}/t", evenNumber);
            }
            Console.WriteLine();
        }
    
        static void Main(string[] args)
        {
        AnonymysMethodSyntax();
            Console.ReadLine();
        }
    }
}
