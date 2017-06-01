using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzzApp.Test
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private FizzBuzz _fb;

        [SetUp]
        protected void SetUp()
        {
            _fb = new FizzBuzz();
			
        }

        [TearDown]
        protected void TearDown()
        {
            _fb = null;
        }

        [Test]
        public void FizzBuzz_GivenOne_ShouldReturnOne()
        {
            var actual = _fb.FizzBuzzer(1);
            Assert.AreEqual(actual, "1");
        }

        [Test]
        public void FizzBuzz_DivByThreeAndFive_ShouldReturnFizzBuzz()
        {
            var actual = _fb.FizzBuzzer(15);
            Assert.AreEqual(actual, "FizzBuzz");
        }

        [Test]
        public void FizzBuzz_DivByThree_ShouldReturnFizz()
        {
            var actual = _fb.FizzBuzzer(3);
            Assert.AreEqual(actual, "Fizz");
        }

        [Test]
        public void FizzBuzz_DivByBuzz_ShouldReturnBuzz()
        {
            var actual = _fb.FizzBuzzer(5);
            Assert.AreEqual(actual, "Buzz");
        }

        [Test]
        public void FizzBuzz_GivenOutOfRange_ShouldReturnExeption()
        {
            Assert.Throws<ArgumentException>( ()=> _fb.FizzBuzzer(-1));
        }

        [Test]
        public void FizzBuzz_GivenMinRange_ShouldReturnOutOfRangeExeption()
        {
            Assert.Throws<ArgumentException>( ()=> _fb.FizzBuzzer(0));
        }

        [Test]
        public void FizzBuzz_GivenMaxRange_ShouldReturnOutOfRangeExeption()
        {
            Assert.Throws<ArgumentException>( ()=> _fb.FizzBuzzer(101));
        }

    }
}
