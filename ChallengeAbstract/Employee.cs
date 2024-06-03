using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeAbstract
{
    public class Employee : Persons
    {
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {lastName}");
        }
       
    }
}
