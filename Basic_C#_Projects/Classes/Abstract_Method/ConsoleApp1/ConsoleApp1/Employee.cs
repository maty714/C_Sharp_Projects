using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee: Person
    {
        public override void SayName() // this is needed in this class if you are to inherit from class Person
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
