using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string[] myarray = {"1.", "2.", "3."};



            //for (int i = 0; i < myarray.Length; i++)
            //{
            //    Console.WriteLine("Please enter some text that will be added to each element: ");
            //    string input = Console.ReadLine();
            //    myarray[i] += "" + input;

            //}

            //for (int i = 0; i < myarray.Length; i++)
            //{
            //    Console.WriteLine(myarray[i]);
            //}


            Console.WriteLine("Please enter some text that will be added to each element: ");
            string input = Console.ReadLine();

            for (int i = 0; i < myarray.Length; i++)
            {
                Console.WriteLine(myarray[i] + " " + input);
            }


            Console.Read();


        }
    }
}
