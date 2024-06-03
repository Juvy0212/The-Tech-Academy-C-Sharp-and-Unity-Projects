using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptional_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Pick a number");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick a number 2: ");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Dividing the two . . . . ");
            //    double numberThree = numberOne / numberTwo;
            //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);



            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Please type a whole number.");
            //    return;

            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please don't divide on zero.");

            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);

            //}
            //finally
            //{
            //    Console.ReadLine();
            //}

            List<int> numbers = new List<int>() {1,3,5,7,9,11 };

            Console.WriteLine("Please enter a number to divide each number in the list by");


            try
            {
                string userInput = Console.ReadLine();
                int divisor = int.Parse(userInput);

                foreach(int number in numbers)
                {
                    int result = number / divisor;
                    Console.WriteLine($"Result of dividing {number} by {divisor} is {result}");


                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Program has emerged from the try/catch block and continued execution.");
            }

            // Ensure the console window stays open
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
        
    }
}
