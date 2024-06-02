using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Math_Operation mathOPs = new Math_Operation();

            Console.WriteLine("Enter a number to perform math operations on: ");
            int userInput;

            while (!int.TryParse(Console.ReadLine(), out userInput)) 
            {
                Console.WriteLine("Invalid input. Please enter a valid integer:");
            
            }
            int resultAdd = mathOPs.AddTen(userInput);
            Console.WriteLine($"Result of adding 10: {resultAdd}");

            int resultSubtract =   mathOPs.SubtractFive(userInput);
            Console.WriteLine($"Result of subtracting 5: {resultSubtract}");

            int resultTimes = mathOPs.MultiplyTwo(userInput);
            Console.WriteLine($"Times by is equal to: {resultAdd}");

            // Keep the console window open
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
