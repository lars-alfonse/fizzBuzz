using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class FizzBuzzTester
    {
        public void checkNumber()
        {
            for (int i = 1; i <= 100; i++)
            {
                if(i == 1)
                {
                    Console.WriteLine("1");
                }
                else if (checkForMultiples(i , 3) && checkForMultiples(i, 5))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(checkForMultiples(i, 3))
                {
                    Console.WriteLine("Fizz");
                }
                else if (checkForMultiples(i, 5))
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        private bool checkForMultiples(int number, int divisor )
        {
            double result = number % divisor;
            if(result == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
