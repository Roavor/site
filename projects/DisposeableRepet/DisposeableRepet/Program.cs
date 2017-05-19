using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DisposeableRepet
{
    class FinalizeObject : IDisposable
    {
        public int id { get; set; }

        public FinalizeObject(int id)
        {
            this.id = id;
        }

        // Реализуем метод Dispose()
        public void Dispose()
        {
            Console.WriteLine("Высвобождение объекта!");
        }
        public override string ToString()
        {
            return string.Format("Your id : {0}", id);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FinalizeObject obj = new FinalizeObject(4);
            obj.Dispose();
            Console.WriteLine(obj.ToString());
            Console.WriteLine();
            using (StringWriter str=new StringWriter())
            {
                str.WriteLine("WriteLine");
                using (StringReader strReader=new StringReader(str.ToString()))
                {
                    string input = null;
                    while ((input=strReader.ReadLine())!=null)
                    {
                        Console.WriteLine(input);
                    }
                }
            }
            Console.Read();
        }
    }
}
