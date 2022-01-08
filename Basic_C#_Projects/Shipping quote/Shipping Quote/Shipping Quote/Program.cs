using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Quote
{
    class Program
    {
        static void Main()
        {
            int dimension;
            int quote;
            
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();

            Console.Write("Please enter the weight of the package: ");
            string input1 = Console.ReadLine();
            int weight = Convert.ToInt32(input1);

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped (greater than 50) via Package Express. Have a good day");
                Console.ReadLine();
                Environment.Exit(0);
            }

           
            //Prompts user to enter the dimensions
            Console.Write("Please enter the length of the package: ");
            string input2 = Console.ReadLine();
            int length = Convert.ToInt32(input2);
            Console.Write("Please enter the height of the package: ");
            string input3 = Console.ReadLine();
            int height = Convert.ToInt32(input3);
            Console.Write("Please enter the width of the package: ");
            string input4 = Console.ReadLine();
            int width = Convert.ToInt32(input4);
            
            dimension = length + width + height;



            if (dimension > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
                Console.ReadLine();
                Environment.Exit(0);
            }

            quote = ((length * width * height) * weight) / 100; 
            Console.Write("Your estimated cost of shipping is: " + "$" + quote);
            Console.Read();
        }
    }
}
