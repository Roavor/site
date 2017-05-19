using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace ConsoleApplication10
{
    class Program
	{
		static void Main( string[] args )
		{
			foreach ( dynamic item in MyMethod() )
			{
				Console.WriteLine("{0}\t{1}", item.key, item.value);
			}

			Console.ReadKey();
		}

		static IEnumerable MyMethod()
		{
			yield return new {  key = "hello", value = "world" };
			yield return new { key = "hi", value = "all" };
			yield return new { key = 15.6, value = 184 };
		}
	}










}

















