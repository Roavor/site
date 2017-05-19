using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayMessage
{
    class Program
    {
        static void DisplayMessage ()
        {
            string userMessage = string.Format("10000 in hex  is {0:x}", 10000);
            System.Windows.MessageBox.Show(userMessage);
        }
        static void Main(string[] args)
        {
           DisplayMessage();
        }
    }
}
