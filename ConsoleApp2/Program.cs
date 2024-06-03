using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the day today?");
            string day = Console.ReadLine();
            bool isWeekend = (day == "Saturday") || (day == "Sunday");

            while (!isWeekend)
            {
                switch (day)
                {
                    case "Monday":
                        Console.WriteLine("4 days more before day off");
                        break;
                    case "Tuesday":
                        Console.WriteLine("3 days more before day off");
                        break;
                    case "Wednesday":
                        Console.WriteLine("2 days more before day off");
                        break;
                    case "Thursday":
                        Console.WriteLine("1 day more before day off");
                        break;
                    case "Friday":
                        Console.WriteLine("It's almost the weekend!");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid day of the week.");
                        break;
                }

                // Prompt the user for input again
                Console.WriteLine("\nWhat is the day today?");
                day = Console.ReadLine();
                isWeekend = (day == "Saturday") || (day == "Sunday");
            }

            // Output message for weekend
            Console.WriteLine("It's weekend!");
        }
    }
}
