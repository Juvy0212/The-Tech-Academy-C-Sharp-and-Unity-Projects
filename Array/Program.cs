using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String Array
            string[] stringArray = { "apple", "banana", "cherry", "date", "elderberry" };
            Console.WriteLine("Select an index for the string array (0-4):");
            int stringIndex;
            if (int.TryParse(Console.ReadLine(), out stringIndex) && stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                Console.WriteLine("String at index " + stringIndex + ": " + stringArray[stringIndex]);
            }
            else
            {
                Console.WriteLine("Invalid index for string array.");
            }

            // Integer Array
            int[] intArray = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Select an index for the integer array (0-4):");
            int intIndex;
            if (int.TryParse(Console.ReadLine(), out intIndex) && intIndex >= 0 && intIndex < intArray.Length)
            {
                Console.WriteLine("Integer at index " + intIndex + ": " + intArray[intIndex]);
            }
            else
            {
                Console.WriteLine("Invalid index for integer array.");
            }

            // List of Strings
            List<string> stringList = new List<string> { "red", "green", "blue", "yellow", "purple" };
            Console.WriteLine("Select an index for the string list (0-4):");
            int listIndex;
            if (int.TryParse(Console.ReadLine(), out listIndex) && listIndex >= 0 && listIndex < stringList.Count)
            {
                Console.WriteLine("String at index " + listIndex + ": " + stringList[listIndex]);
            }
            else
            {
                Console.WriteLine("Invalid index for string list.");
            }

            // Prevent the console window from closing immediately
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
        }
    }

