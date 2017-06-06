using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Gen1
{
	public class FizzBuzzer : IFizzBuzzer
	{
		private readonly IValidateFizz _validateFizz;
		private readonly IValidateBuzz _validateBuzz;
		private IConsoleWriter _consoleWriter;

		public FizzBuzzer(IValidateFizz validateFizz, IValidateBuzz validateBuzz)
		{
			this._validateFizz = validateFizz;
			this._validateBuzz = validateBuzz;
			
		}

		public FizzBuzzer() : this (new ValidateFizz(), new ValidateBuzz())
		{

		}
		//it is returning a string just for unit testing purposes.
		public string Print(int number, IConsoleWriter consoleWriter)
		{
			this._consoleWriter = consoleWriter;

			if (consoleWriter == null)
			{
				throw new ArgumentNullException();
			}

			ValidateInput.Validate(ref number);

			if (_validateFizz.IsFizz(number) && _validateBuzz.IsBuzz(number))
			{
				_consoleWriter.WriteLn("{0}", "FizzBuzz");
				return "FizzBuzz";
			}

			if (_validateFizz.IsFizz(number))
			{
				_consoleWriter.WriteLn("{0}", "Fizz");
				return "Fizz";
			}

			if (_validateBuzz.IsBuzz(number))
			{
				_consoleWriter.WriteLn("{0}", "Buzz");
				return "Buzz";
			}

			_consoleWriter.WriteLn(ConvertIntToString(ref number));
			return ConvertIntToString(ref number);
		}

		private static string ConvertIntToString(ref int number)
		{
			return number.ToString();
		}
	}
}
