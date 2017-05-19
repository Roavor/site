using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DriveInforrr
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] myDrives = DriveInfo.GetDrives();
            foreach ( DriveInfo m in myDrives)
            {
                Console.WriteLine("Name {0}",m.Name);
                Console.WriteLine("Type {0}",m.DriveType);
                if (m.IsReady)
                {
                    Console.WriteLine("Total free space {0}",m.TotalFreeSpace);
                    Console.WriteLine("Format {0}",m.DriveFormat);
                    Console.WriteLine("Label {0}",m.VolumeLabel);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
