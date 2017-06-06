using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Gen1
{
	public class ConsoleWriter : IConsoleWriter
	{
		public void WriteLn(string format, params object[] arg)
		{
			Console.WriteLine(format, arg);
		}

		public void Write(string format, params object[] arg)
		{
			Console.Write(format, arg);
		}
	}
}
