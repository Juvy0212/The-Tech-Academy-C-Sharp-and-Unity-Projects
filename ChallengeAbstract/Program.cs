using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeAbstract
{
    public class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee { FirstName="Sample", lastName="student"};
            employee.SayName();

            Console.ReadLine();
        }
    }
}
