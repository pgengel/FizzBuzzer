using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzer
{
    class FizzBuzzerSimple
    {
        public void FizzBuzz(int number)
        {
            if (InRange(number))
            {
                if (IsFizzBuzz(number))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (IsBuzz(number))
                {
                    Console.WriteLine("Buzz");
                }
                else if (IsFizz(number))
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(number);
                }     
            }
            else
            {
                Console.WriteLine("Error");
            }
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
            if (number % 4 == 0)
            {
                return true;
            }
            return false;
        }

        private bool IsBuzz(int number)
        {
            if (number % 7 == 0)
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
