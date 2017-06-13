using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Gen1;
using NSubstitute;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using NUnit.Framework.Internal;

namespace FizzBuzz.Test.Gen1
{
	[TestFixture]
	public class FizzBuzzerTest
	{
		private FizzBuzzer _fizzBuzzer;

		[Test]
		public void FizzBuzz_GivenThree_ShouldReturnFizz()
		{
			var validateFizz = Substitute.For<IValidateFizz>();
			validateFizz.IsFizz(3).Returns(true);

			var validateBuzz = Substitute.For<IValidateBuzz>();
			validateBuzz.IsBuzz(3).Returns(false);

			_fizzBuzzer = new FizzBuzzer(validateFizz, validateBuzz);

			var actual = _fizzBuzzer.Write(3, new ConsoleWriter());

			Assert.AreEqual(actual, "Fizz");
		}

		[Test]
		public void FizzBuzz_GivenFive_ShouldReturnBuzz()
		{
			var validateFizz = Substitute.For<IValidateFizz>();
			validateFizz.IsFizz(5).Returns(false);

			var validateBuzz = Substitute.For<IValidateBuzz>();
			validateBuzz.IsBuzz(5).Returns(true);

			_fizzBuzzer = new FizzBuzzer(validateFizz, validateBuzz);

			var actual = _fizzBuzzer.Write(5, new ConsoleWriter());

			Assert.AreEqual(actual, "Buzz");
		}

		[Test]
		public void FizzBuzz_GivenFiveteen_ShouldReturnFizzBuzz()
		{
			var validateFizz = Substitute.For<IValidateFizz>();
			validateFizz.IsFizz(15).Returns(true);

			var validateBuzz = Substitute.For<IValidateBuzz>();
			validateBuzz.IsBuzz(15).Returns(true);

			_fizzBuzzer = new FizzBuzzer(validateFizz, validateBuzz);

			var actual = _fizzBuzzer.Write(15, new ConsoleWriter());

			Assert.AreEqual(actual, "FizzBuzz");
		}

		[Test]
		public void FizzBuzz_GivenOne_ShouldReturnOne()
		{
			var validateFizz = Substitute.For<IValidateFizz>();
			validateFizz.IsFizz(1).Returns(false);

			var validateBuzz = Substitute.For<IValidateBuzz>();
			validateBuzz.IsBuzz(1).Returns(false);

			_fizzBuzzer = new FizzBuzzer(validateFizz, validateBuzz);

			var actual = _fizzBuzzer.Write(1, new ConsoleWriter());

			Assert.AreEqual(actual, "1");
		}

		[Test]
		public void FizzBuzz_GivenNumberOutOfRangeMin_ShouldReturnExpetionOutOfRange()
		{
			var validateFizz = Substitute.For<IValidateFizz>();

			var validateBuzz = Substitute.For<IValidateBuzz>();

			_fizzBuzzer = new FizzBuzzer(validateFizz, validateBuzz);

			Assert.Throws<ArgumentException>(() => _fizzBuzzer.Write(0, new ConsoleWriter()));
		}

		[Test]
		public void FizzBuzz_GivenNumberOutOfRangeMax_ShouldReturnExpetionOutOfRange()
		{
			var validateFizz = Substitute.For<IValidateFizz>();

			var validateBuzz = Substitute.For<IValidateBuzz>();

			_fizzBuzzer = new FizzBuzzer(validateFizz, validateBuzz);

			Assert.Throws<ArgumentException>(() => _fizzBuzzer.Write(101, new ConsoleWriter()));
		}
	}
}
