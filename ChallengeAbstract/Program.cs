using System;
using System.Collections.Generic;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with type string as its generic parameter
            Employee<string> employee1 = new Employee<string> { FirstName = "Sample", lastName = "Employee", Id = 1 };
            employee1.Things = new List<string> { "Thing1", "Thing2", "Thing3" };

            // Instantiate an Employee object with type int as its generic parameter
            Employee<int> employee2 = new Employee<int> { FirstName = "Another", lastName = "Employee", Id = 2 };
            employee2.Things = new List<int> { 1, 2, 3 };

            // Print all Things for employee1
            Console.WriteLine("Things for employee1:");
            foreach (var thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }

            // Print all Things for employee2
            Console.WriteLine("Things for employee2:");
            foreach (var thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
