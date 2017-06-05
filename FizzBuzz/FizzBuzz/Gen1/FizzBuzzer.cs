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
				_consoleWriter.Write("FizzBuzz");
				return "FizzBuzz";
			}

			if (_validateFizz.IsFizz(number))
			{
				_consoleWriter.Write("Fizz");
				return "Fizz";
			}

			if (_validateBuzz.IsBuzz(number))
			{
				_consoleWriter.Write("Buzz");
				return "Buzz";
			}

			_consoleWriter.Write(ConvertIntToString(number));
			return number.ToString();
		}

		private static string ConvertIntToString(int number)
		{
			return number.ToString();
		}
	}
}
