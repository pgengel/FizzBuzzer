using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Gen1
{
	public class ValidateFizz : IValidateFizz
	{
		public bool IsFizz(int number)
		{
			ValidateInput.Validate(ref number);

			return (number % CONSTANT.DIV_BY_THREE == CONSTANT.ZERO_RES);
		}            						 
	}
}
