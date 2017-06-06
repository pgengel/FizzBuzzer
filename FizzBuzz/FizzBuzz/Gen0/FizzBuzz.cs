using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;

namespace FizzBuzzApp
{
    public class FizzBuzz
    {
        public string FizzBuzzer(int number)
		{
			Validate(ref number);

			if (IsFizz(ref number) && IsBuzz(ref number))
				return "FizzBuzz";
			if (IsFizz(ref number))
				return "Fizz";
			if (IsBuzz(ref number))
				return "Buzz";
			return ConvertToString(number);
		}

		private static bool IsBuzz(ref int number)
		{
			return number % CONSTANT.DIV_BY_FIVE == CONSTANT.ZERO_RES;
		}

		private static bool IsFizz(ref int number)
		{
			return number % CONSTANT.DIV_BY_THREE == CONSTANT.ZERO_RES;
		}

		private static string ConvertToString(int number)
		{
			return number.ToString();
		}

		private static void Validate(ref int number)
        {
            if (number == null)
                throw new ArgumentNullException("Null Exeption");
            if (number < CONSTANT.MIN || number > CONSTANT.MAX)
                throw new ArgumentException("Out of Range");
        }
    }
}
