using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           mathOperation mathOps = new mathOperation();

            Console.WriteLine("Please enter a number");
            int inputUser;

            while (!int.TryParse(Console.ReadLine(), out inputUser)) 
            {
                Console.WriteLine("Invalid input. Please enter a valid input");
            }

            mathOps.DivideByTwo(inputUser);

            int outputResult;
            mathOps.DivideByTwo(inputUser, out outputResult);
            Console.WriteLine($"Output using method with out parameter: {outputResult}");

            // Call the overloaded method with a double
            double inputDouble = inputUser;
            mathOps.DivideBytwo(inputDouble);

            // Call the static method in the static class
            Utility.PrintMessage("This is a message from the static Utility class.");

            Console.ReadLine();
        }
    }
}
