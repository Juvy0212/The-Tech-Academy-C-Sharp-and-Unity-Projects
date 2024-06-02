using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_Express
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("Please enter the package weight: ");
            int weight  = int.Parse(Console.ReadLine());

            if (weight > 50)
            {

                Console.WriteLine("Package too big to be shipped via Package Express");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Please enter the package width: ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the package height: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the package length: ");
            int length = int.Parse(Console.ReadLine());


            int totalDimensions = width + height + length;
            if (totalDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return; // End the program
               
            }
            //calculate the payment
            int dimensionproduct = width * height * length;

            decimal payments = (dimensionproduct * weight) / 100m;

            Console.WriteLine("Your estimated shipping cost is $" + payments);

            Console.ReadLine();

        }
    }
}
