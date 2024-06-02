using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_True_of_False
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask for age
                Console.WriteLine("What is your age?: ");
                int age = int.Parse(Console.ReadLine());

                // Ask if the user has had a DUI
                Console.WriteLine("Have you ever had a DUI (true/false)?: ");
                bool hasDui = bool.Parse(Console.ReadLine());

                // Ask for the number of speeding tickets
                Console.WriteLine("How many speeding tickets do you have? ");
                int tickets = int.Parse(Console.ReadLine());

                // Determine qualification
                bool qualified = (age > 15) && !hasDui && (tickets <= 3);

                // Output the result
                Console.WriteLine("Qualified?: " + qualified);

                Console.ReadLine();
            }
        }
    }
