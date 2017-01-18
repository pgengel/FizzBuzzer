namespace FizzBuzzer
{
    public class FizzBuzzerSimple
    {
        public string FizzBuzz(int number)
        {
            if (InRange(number))
            {
                if (IsFizzBuzz(number))
                {
                    return "FizzBuzz";
                }
                if (IsBuzz(number))
                {
                    return "Buzz";
                }
                if (IsFizz(number))
                {
                    return "Fizz";
                }

                return number.ToString();
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
            if (number % 4 == 0)
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
    }
}
