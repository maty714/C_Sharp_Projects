using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Matt";
            var age = 2;

            Constructor_Chain constructor = new Constructor_Chain();


            Console.WriteLine(name + " " + age);
            Console.Read();
        }
    }
}
