using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee: Person, IQuittable
    {
        public override void SayName() // this is needed in this class if you are to inherit from class Person
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }

        public void Quit(string arg1)
        {
            Console.WriteLine("This is inherited from IQuittable and " + arg1);
        }
    }
}
