using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetValueOfTypeFromDataBase
{
    class DatabaseReader
    {
        public int? numericValue = null;
        public bool? boolValue = null;
        public int? GetIntFronDatabase ()
        {
            return numericValue;
        }
        public bool? GetBoolFromDatabase()
        {
            return boolValue;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseReader dr = new DatabaseReader();
            int? i = dr.GetIntFronDatabase();
            if (i.HasValue)
                Console.WriteLine("Value of 'i' is: {0}",i.Value);
            else
                Console.WriteLine("Value of 'i' is undefined.");
            bool? b = dr.GetBoolFromDatabase();
            if (b.HasValue)
                Console.WriteLine("Value of 'b' is: {0}",b.Value);
            else
                Console.WriteLine("Value of 'b' is undefined.");
            //Если значение,возвращаемое GetIntFronDatabase(),
            //равно null, присвоить локальнойй переменной значение 100.
            int myData = dr.GetIntFronDatabase() ?? 100;
            Console.WriteLine("Value of myData: {0}",myData);
            
            Console.ReadLine();
        }
    }
}
