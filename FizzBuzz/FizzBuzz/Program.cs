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
            //FizzBuzz fb = new FizzBuzz();
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(fb.FizzBuzzer(i));
            //}
            //Console.ReadLine();
			IFizzBuzzer fizzBuzzer = new global::FizzBuzz.Gen1.FizzBuzzer(new ValidateFizz(), new ValidateBuzz());
			for (int i = 1; i <= 100; i++)
			{
				fizzBuzzer.Print(i, new ConsoleWriter());
			}
			Console.ReadLine();
		}
	}
}
