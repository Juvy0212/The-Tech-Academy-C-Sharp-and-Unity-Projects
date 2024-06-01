using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Initialize the list with at least two identical strings
            List<string> list = new List<string>() { "Apple", "Banana", "Strawberry", "Mango" };

            Console.WriteLine("Give one fruit:");
            string fruit = Console.ReadLine();

            // Add the entered fruit to the end of the list
            list.Add(fruit);

            // Ask the user to input the text to search for
            Console.WriteLine("Enter the text to search for:");
            string searchText = Console.ReadLine();

            // Variable to keep track of whether the text was found
            bool textFound = false;

            // Iterate through the list and display the indices of matching text
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Text found at index: {i}");
                    textFound = true;
                }
            }

            // Notify the user if the text isn't found in the list
            if (!textFound)
            {
                Console.WriteLine("The text you entered is not in the list.");
            }

            // Create a HashSet to track already seen strings
            HashSet<string> seenStrings = new HashSet<string>();

            // Foreach loop to evaluate each item in the list
            foreach (string item in list)
            {
                if (seenStrings.Contains(item))
                {
                    Console.WriteLine($"'{item}' has already appeared in the list.");
                }
                else
                {
                    Console.WriteLine($"'{item}' is appearing for the first time in the list.");
                    seenStrings.Add(item);
                }
            }

            Console.ReadLine();
        }
    }
}
