using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Class2 divide = new Class2();
            Console.WriteLine("Please enter a number: ");
            string input1 = Console.ReadLine();



            Class1.static_class("4", out int output_Para);

            Console.WriteLine("output variable equals: " + output_Para);
            divide.divide(input1);
            Console.Read();




            
        }
    }    
}




