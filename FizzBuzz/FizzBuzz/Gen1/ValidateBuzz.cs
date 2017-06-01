using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Gen1
{
	public class ValidateBuzz : IValidateBuzz
	{
		public bool IsBuzz(int number)
		{
			ValidateInput.Validate(ref number);

			if (number % CONSTANT.DIV_BY_FIVE == CONSTANT.ZERO_RES)
			{
				return true;
			}

			return false;
		}
	}
}
