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

            Console.WriteLine("Do you need help with anything? Please answer true or false:");
            string input = Console.ReadLine();
            bool answer = Convert.ToBoolean(input);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics");
            string experience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string time = Console.ReadLine();
            int hours = Convert.ToInt32(time); 
           
        }
    }
}
