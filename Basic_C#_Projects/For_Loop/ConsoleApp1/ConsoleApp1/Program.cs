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
            List<string> myList = new List<string>() { "car", "motorcycle", "truck", "airplane", "tractor", "golfcart" };


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


            //Console.WriteLine("Please enter some text that will be added to each element: ");
            //string input = Console.ReadLine();

            ////for loop using "<" operator
            //for (int i = 0; i < myarray.Length; i++)
            //{
            //    Console.WriteLine(myarray[i] + " " + input);
            //}
            
            ////infinite loop
            //do
            //{
            //    Console.WriteLine("Infinite Loooop!");
            //} while (false); //switch to true to create an infinite loop

            ////for loop using "<=" operator
            //for (int i = 0; i <= myarray.Length - 1; i++)
            //{
            //    Console.WriteLine(myarray[i] + " " + input);
            //}

            Console.WriteLine("Select an item from the list: ");
            string item = Console.ReadLine();

                for (int i = 0; i < myList.Count; i++)
                {
                    //if (item == "") 
                    //{
                    //    Console.WriteLine("Please search an item");
                    //    break;
                    //}


                    while (item == "")
                    {
                    Console.WriteLine("Please enter a value: ");
                    string input = Console.ReadLine();
                    item = input;
                    }

                    if (item == myList[i])
                    {
                        Console.WriteLine("This item is in the list!");
                        break;
                    }
                    else if (i == myList.Count - 1)
                    {
                        Console.WriteLine("This item does not exist in the list");
                    }
                }               
            
            Console.Read();
        }
    }
}
