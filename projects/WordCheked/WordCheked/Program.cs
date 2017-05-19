using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCheked
{
    class Program
    {
        static int Add(int b1,int b2)
        {
            return b1 + b2;
        }
        static void ProcessBytes()
        {
            byte b1 = 100;
            byte b2 = 250;
            try
            {
                //Предполагая что флаг /checked включен то он не будет проверять ту часть кода в которую
                // включена  в ключевое слово unchecked 
                // uncheked {
                //             byte sum = checked((byte)Add(b1, b2));
                //             Console.WriteLine("sum={0}",sum);
                //          }ст.134
                byte sum = checked((byte)Add(b1, b2));
                Console.WriteLine("sum={0}",sum);
            }
            catch (OverflowException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            ProcessBytes();
            Console.ReadKey();

        }
    }
}
