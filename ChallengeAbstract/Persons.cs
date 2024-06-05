using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeAbstract
{
    public abstract class Persons
    {
        public string FirstName { get; set; }
        public string lastName { get; set; }

        public abstract void SayName();

        
    }
}
