using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Gen1;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
			FizzBuzz Q1 = new FizzBuzz();
			for (int i = 1; i <= 100; i++)
			{
				Console.WriteLine(Q1.FizzBuzzer(i));
			}
			Console.ReadLine();

			IFizzBuzzer Q4 = new global::FizzBuzz.Gen1.FizzBuzzer(new ValidateFizz(), new ValidateBuzz());
			for (int i = 1; i <= 100; i++)
			{
				Q4.Write(i, new ConsoleWriter());
			}
			Console.ReadLine();
		}
	}
}
