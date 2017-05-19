using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedMultidimensionalArray
{
    class Program
    {
        static void JaggedArray()
        {
            //
            int[][] myJagArray = new int[5][];
            //
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];
            //
            //
            for (int i=0;i<5;i++)
            {
                for(int j=0;j<myJagArray[i].Length;j++)
                {
                    Console.Write(myJagArray[i][j]+" ");
                   
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            JaggedArray();
            Console.ReadKey();
        }
    }
}
