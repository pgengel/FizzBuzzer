

using ConsoleWriters;

namespace FizzBuzzer
{
    public class FizzBuzzerSimple : ConsoleWriter
    {


        public string FizzBuzz(int number)
        {

            if (InRange(number))
            {
                if (IsFizzBuzz(number))
                {
                    Write("FizzBuzz", null);

                    //consoleWriter.WriteLine("FizzBuzz", null);
                    return "FizzBuzz";
                }
                if (IsBuzz(number))
                {
                    Write("Buzz", null);
                    //consoleWriter.WriteLine("Buzz", null);
                    return "Buzz";
                }
                if (IsFizz(number))
                {
                    Write("Fizz", null);
                    //consoleWriter.WriteLine("Fizz", null);
                    return "Fizz";
                }

                Write(ConvertIntToStr(number), null);
                // consoleWriter.WriteLine(ConvertIntToStr(number), null);
                return ConvertIntToStr(number);
            }

            Write("The number is out of range", null);

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
