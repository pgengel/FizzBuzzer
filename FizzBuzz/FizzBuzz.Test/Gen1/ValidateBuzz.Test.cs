using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Gen1;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace FizzBuzz.Test.Gen1
{
	[TestFixture]
	public class ValidateBuzzerTest
	{
		private ValidateBuzz _validateBuzz;
		
		[SetUp]
	    public void SetUp()
	    {
			_validateBuzz = new ValidateBuzz();    
	    }

		[TearDown]
		protected void TearDown()
		{
			_validateBuzz = null;
		}

		[Test]
		public void ValidateBuzz_GivenThree_ShoudReturnTrue()
		{
			Assert.IsTrue(_validateBuzz.IsBuzz(5));
		} 		
		
		[Test]
		public void ValidateBuzz_GivenFive_ShoudReturnFalse()
		{
			Assert.IsFalse(_validateBuzz.IsBuzz(3));
		} 
		
		[Test]
		public void ValidateBuzz_GivenOutOfRange0_ShoudReturnOutOfRangeExeption()
		{
			Assert.Throws<ArgumentException>( () => _validateBuzz.IsBuzz(0));
		} 	
		
		[Test]
		public void ValidateBuzz_GivenOutOfRange101_ShoudReturnOutOfRangeExeption()
		{
			Assert.Throws<ArgumentException>( () => _validateBuzz.IsBuzz(101));
		} 
    }
}
