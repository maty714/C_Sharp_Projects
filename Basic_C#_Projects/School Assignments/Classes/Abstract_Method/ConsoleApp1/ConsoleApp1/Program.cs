using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person people = new Employee() { FirstName = "Matt", LastName = "Clark" }; // this is an example of polymorphism
            IQuittable iQuit = new Employee();
            Employee name = new Employee() { FirstName = "Example", LastName = "Student" };


            people.SayName(); // outputs "Name: Matt Clark", if FirstName and LastName are not defined, "Name:" would be printed, because "People is created off of Employee, the SayName method is from the Employee class
            name.SayName(); // outputs "Name: Example Student"
            name.Quit("Argument passed"); //references the Quit() method inherited from the interface
            iQuit.Quit(" Another Argument");
            
            Console.Read();
        }
    }
}
