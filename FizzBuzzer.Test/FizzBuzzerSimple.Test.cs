using NUnit.Framework;

namespace FizzBuzzer.Test
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private FizzBuzzerSimple _fb;

        [SetUp]
        protected void SetUp()
        {
            _fb = new FizzBuzzerSimple();

        }

        [TestCase(3, "Fizz")]
        public void FizzBuzzer_GivenFizzNumber_ShouldReturnFizz(int number, string expected)
        {
            //arrange
            //var fb = new FizzBuzzerSimple();

            //act
            var actual = _fb.FizzBuzz(number);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, "Buzz")]
        public void FizzBuzzer_GivenBuzzNumber_ShouldReturnBuzz(int number, string expected)
        {
            //arrange
            //var fb = new FizzBuzzerSimple();

            //act
            var actual = _fb.FizzBuzz(number);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, "4")]
        public void FizzBuzzer_GivenBuzzNumber_ShouldReturnNumber(int number, string expected)
        {
            //arrange
            //var fb = new FizzBuzzerSimple();

            //act
            var actual = _fb.FizzBuzz(number);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, "Buzz")]
        public void FizzBuzzer_GivenFizzBuzzNumber_ShouldReturnFizzBuzz(int number, string expected)
        {
            //arrange
            //var fb = new FizzBuzzerSimple();

            //act
            var actual = _fb.FizzBuzz(number);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(101, "The number is out of range")]
        public void FizzBuzzer_GivenNumberOutOfRange_ShouldReturnOutOfRange(int number, string expected)
        {
            //arrange
            //var fb = new FizzBuzzerSimple();

            //act
            var actual = _fb.FizzBuzz(number);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, "Buzz")]
        public void FizzBuzzer_GivenNumberMax_ShouldReturBuzz(int number, string expected)
        {
            //arrange
            //var fb = new FizzBuzzerSimple();

            //act
            var actual = _fb.FizzBuzz(number);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, "1")]
        public void FizzBuzzer_GivenNumberMin_ShouldReturnNumber(int number, string expected)
        {
            //arrange
            //var fb = new FizzBuzzerSimple();

            //act
            var actual = _fb.FizzBuzz(number);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, "The number is out of range")]
        public void FizzBuzzer_GivenNumberMinOut_ShouldReturnOutOfRange(int number, string expected)
        {
            //arrange
            //var fb = new FizzBuzzerSimple();

            //act
            var actual = _fb.FizzBuzz(number);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(101, "The number is out of range")]
        public void FizzBuzzer_GivenNumberMaxOut_ShouldReturnOutOfRange(int number, string expected)
        {
            //arrange
            //var fb = new FizzBuzzerSimple();

            //act
            var actual = _fb.FizzBuzz(number);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
