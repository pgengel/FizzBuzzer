
using ConsoleWriter;

namespace FizzBuzzer
{
    public class FizzBuzzerSimple : Writer
    {
        public FizzBuzzerSimple(IConsoleWriter consoleWriter, string format, object[] args) : base(consoleWriter, format, args)
        {
        }

        public FizzBuzzerSimple() : base()
        {
        }

        public string FizzBuzz(int number)
        {
            if (InRange(number))
            {
                if (IsFizzBuzz(number))
                {
                    consoleWriter.WriteLine("FizzBuzz", null);
                    return "FizzBuzz";
                }
                if (IsBuzz(number))
                {
                    consoleWriter.WriteLine("Buzz", null);
                    return "Buzz";
                }
                if (IsFizz(number))
                {
                    consoleWriter.WriteLine("Fizz", null);
                    return "Fizz";
                }

                consoleWriter.WriteLine(ConvertIntToStr(number), null);
                return ConvertIntToStr(number);
            }

            return "The number is out of range";

        }

        private bool InRange(int number)
        {
            if (number >= 1 && number <= 100)
            {
                return true;
            }

            return false;
        }

        private bool IsFizz(int number)
        {
            if (number % 3 == 0)
            {
                return true;
            }
            return false;
        }

        private bool IsBuzz(int number)
        {
            if (number % 5 == 0)
            {
                return true;
            }
            return false;
        }

        private bool IsFizzBuzz(int number)
        {
            if (IsBuzz(number) && IsFizz(number))
            {
                return true;
            }
            return false;
        }

        private string ConvertIntToStr(int number)
        {
            return number.ToString();
        }


    }
}
