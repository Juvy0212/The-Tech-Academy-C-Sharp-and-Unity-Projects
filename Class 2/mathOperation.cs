using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2
{
    public class mathOperation
    {
      public void DivideByTwo (int number)
        {
            int result = number / 2;
            Console.WriteLine($"The result of dividing two {number}by 2 is: {result}");

        }
        public void DivideByTwo (int number, out int result)
        {

            result = number / 2;
        }
      public void DivideBytwo (double number) 
      {
            double result = number / 2;
            Console.WriteLine($"The result of dividing two {number}by 2 is: {result}");
        }

    }
    public static class Utility
    {
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
