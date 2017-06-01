using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Gen1
{
	public static class ValidateInput
	{
		public static void Validate(ref int number)
		{
			if (number == null)
				throw new ArgumentNullException("Null Exeption");
			if (number < CONSTANT.MIN || number > CONSTANT.MAX)
				throw new ArgumentException("Out of Range");
		}
	}
}
