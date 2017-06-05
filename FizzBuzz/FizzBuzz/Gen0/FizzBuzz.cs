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

			if (number % CONSTANT.DIV_BY_THREE == CONSTANT.ZERO_RES && number % CONSTANT.DIV_BY_FIVE == CONSTANT.ZERO_RES)
				return "FizzBuzz";
			if (number % CONSTANT.DIV_BY_THREE == CONSTANT.ZERO_RES)
				return "Fizz";
			if (number % CONSTANT.DIV_BY_FIVE == CONSTANT.ZERO_RES)
				return "Buzz";
			return ConvertToString(number);

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
