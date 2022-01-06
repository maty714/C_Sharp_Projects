using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Application
{
    class Program
    {
        static void Main()
        {
            //prompts the user to answer questions
            Console.WriteLine("Insurance Application");
            Console.WriteLine("---------------------");
            Console.WriteLine();

            Console.WriteLine("Please input your age: ");
            String input1 = Console.ReadLine();
            int age = Convert.ToInt32(input1);

            Console.WriteLine("Have you ever had a DUI?: ");
            string input2 = Console.ReadLine();
            bool DUI = Convert.ToBoolean(input2);

            Console.WriteLine("How many speeding tickets do you have?");
            string input3 = Console.ReadLine();
            int tickets = Convert.ToInt32(input3);

            //output from user input

            bool qualified = (age > 15 && DUI == false && tickets <= 3);

           if (qualified == true)
            {
                Console.WriteLine("Qualified?: Yes");
            }
            else
            {
                Console.WriteLine("Qualified?: No");
            }

            Console.Read();
        }
    }
}
