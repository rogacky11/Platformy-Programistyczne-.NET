using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0
{
    internal class FizzBuzz
    {
        private int _uB;
        public FizzBuzz(int uB) { _uB = uB; }
        

        public void Display()
        {
            for (int i = 0; i < _uB; i++)
            {
                if ((i % 5 == 0) && (i % 3 == 0)) Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0) { Console.WriteLine("Fizz"); }
                else if (i % 5 == 0) { Console.WriteLine("Buzz"); }
                else { Console.WriteLine(i); }

            }
        }

    }
}
