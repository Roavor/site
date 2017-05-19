using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesWithNongenereticCollections
{
    class Program
    {
        private static void SimpleBoxUnboxOperation()
        {
            int myInt=25;
            object boxedInt = myInt;
            int unboxedInt = (int)boxedInt;
        }
        static void Main(string[] args)
        {
        }
    }
}
