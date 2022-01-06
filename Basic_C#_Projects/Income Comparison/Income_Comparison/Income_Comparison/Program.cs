using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_Comparison
{
    class Program
    {
        static void Main()
        {
            
            //Prompts user to enter the hours worked and rate for person 1 and person 2
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
            Console.WriteLine("Please enter the hourly rate of person 1: ");
            string input1_rate = Console.ReadLine();
            int rate_1 = Convert.ToInt32(input1_rate);

            Console.WriteLine("Please enter the amount of hours worked: ");
            string input1_hours = Console.ReadLine();
            int hours_1 = Convert.ToInt32(input1_hours);

            Console.WriteLine("Please enter the hourly rate of person 2: ");
            string input2_rate = Console.ReadLine();
            int rate_2 = Convert.ToInt32(input2_rate);

            Console.WriteLine("Please enter the amount of hours worked: ");
            string input2_hours = Console.ReadLine();
            int hours_2 = Convert.ToInt32(input2_hours);

            int total_1 = (rate_1 * hours_1) * 52;
            int total_2 = (rate_2 * hours_2) * 52;

            bool highest_income = total_1 > total_2;

            //Output for user input
            Console.WriteLine("Annual salary of person 1: " + total_1);
            Console.WriteLine("Annual salary of person 2: " + total_2);
            Console.WriteLine("Does Person 1 make more than person 2? " + highest_income);
            
            Console.Read();
        }
    }
}
