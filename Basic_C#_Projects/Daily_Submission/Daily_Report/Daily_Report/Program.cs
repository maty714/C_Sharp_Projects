using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report
{
    class Program
    {
        static void Main()
        {
            //Title
            Console.WriteLine("------------------");
            Console.WriteLine("-The Tech Academy-");
            Console.WriteLine("------------------");
            Console.WriteLine("");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("____________________");


            //Questions to be answered by students
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            string page = Console.ReadLine();

            Console.Read();

        }
    }
}
