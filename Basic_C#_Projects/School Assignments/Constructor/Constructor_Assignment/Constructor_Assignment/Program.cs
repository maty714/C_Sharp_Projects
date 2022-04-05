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
            //const string name = "Matt";
            //var age = 2;

            //Constructor_Chain constructor = new Constructor_Chain();


            //Console.WriteLine(name + " " + age);
            //Console.Read();


            Console.WriteLine("Please enter a number:");
            string num = Console.ReadLine();
            int theNum = 0;

            if(int.TryParse(num, out theNum))
            {
                Console.WriteLine("This number can be converted: " + theNum);
            }
            Console.Read();
        
        
        }



    }
}
