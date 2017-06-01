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
	public class ValidateFizzerTest
	{
		private ValidateFizz _validateFizz;
		
		[SetUp]
	    public void SetUp()
	    {
			_validateFizz = new ValidateFizz();    
	    }

		[TearDown]
		protected void TearDown()
		{
			_validateFizz = null;
		}

		[Test]
		public void ValidateFizz_GivenThree_ShoudReturnTrue()
		{
			Assert.IsTrue(_validateFizz.IsFizz(3));
		} 		
		
		[Test]
		public void ValidateFizz_GivenFive_ShoudReturnFalse()
		{
			Assert.IsFalse(_validateFizz.IsFizz(5));
		} 
		
		[Test]
		public void ValidateFizz_GivenOutOfRange0_ShoudReturnOutOfRangeExeption()
		{
			Assert.Throws<ArgumentException>( () => _validateFizz.IsFizz(0));
		} 	
		
		[Test]
		public void ValidateFizz_GivenOutOfRange101_ShoudReturnOutOfRangeExeption()
		{
			Assert.Throws<ArgumentException>( () => _validateFizz.IsFizz(101));
		} 
    }
}
