using System;
using System.Collections.Generic;
using ChallengeAbstract;

namespace Objects
{
    public class Employee<T> : Persons, IQuitable
    {
        public int Id { get; set; }
        public List<T> Things { get; set; } = new List<T>();

        // Implementing the abstract method from Person
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {lastName}");
        }

        // Implementing the Quit method from IQuittable
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {lastName} has quit.");
        }

        // Overloading the == operator
        public static bool operator ==(Employee<T> emp1, Employee<T> emp2)
        {
            if (ReferenceEquals(emp1, emp2))
            {
                return true;
            }

            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            {
                return false;
            }

            return emp1.Id == emp2.Id;
        }

        // Overloading the != operator
        public static bool operator !=(Employee<T> emp1, Employee<T> emp2)
        {
            return !(emp1 == emp2);
        }

        // Overriding Equals method
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null) || obj.GetType() != this.GetType())
            {
                return false;
            }

            Employee<T> emp = (Employee<T>)obj;
            return this.Id == emp.Id;
        }

        // Overriding GetHashCode method
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
