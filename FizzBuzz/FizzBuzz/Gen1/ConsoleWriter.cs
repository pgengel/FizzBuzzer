using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Gen1
{
	public class ConsoleWriter : IConsoleWriter
	{
		public void Write(string text)
		{
			Console.WriteLine(text);
		}
	}
}
