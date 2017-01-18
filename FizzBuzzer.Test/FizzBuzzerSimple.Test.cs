using NUnit.Framework;

namespace FizzBuzzer.Test
{
    public class UnitTest1
    {
        [TestCase(4)]
        public void TestMethod1(int number)
        {
            //arrange
            var fb = new FizzBuzzerSimple();

            //act
            var actual = fb.FizzBuzz(number);

            //assert
            Assert.AreEqual("Fizz", actual);
        }
    }
}
