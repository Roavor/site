using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMethotStringBuilder
{
    class Program
    {
        static void FunWithStringBuilder()
        {
            StringBuilder sb = new StringBuilder("****Fantastic Games****");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowing");
            sb.AppendLine("Deus ex \t" + 2);
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", "Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.",sb.Length);
        }
        static void Main(string[] args)
        {
            FunWithStringBuilder();
            Console.ReadKey();
        }
    }
}
