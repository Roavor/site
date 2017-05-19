using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverArray
{
    class Program
    {
        static void QuveryOverString()
        {
            string[] currentVideoGames = { "Morrowing", "Unchahted 2", "Fallout 3", "Daxter", "System shok 2" };
            IEnumerable<string> subset = from g in currentVideoGames where g.Contains(" ") orderby g select g;
            foreach (string s in subset)
            {
                Console.WriteLine("Item {0}",s);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
