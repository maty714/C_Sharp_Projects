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
            List<string> myList2 = new List<string>() { "laptop", "ipad", "desktop", "laptop", "desktop", "smartphone", "laptop" };

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
            //assignment 4
            //Console.WriteLine("Select an item from the list: ");
            //string item = Console.ReadLine();

            //    for (int i = 0; i < myList.Count; i++)
            //    {

            //        while (item == "")
            //        {
            //        Console.WriteLine("Please enter a value: ");
            //        string input = Console.ReadLine();
            //        item = input;
            //        }

            //        if (item == myList[i])
            //        {
            //            Console.WriteLine("This item is in the list!");
            //            break;
            //        }
            //        else if (i == myList.Count - 1)
            //        {
            //            Console.WriteLine("This item does not exist in the list");
            //        }
            //    }
            //assignment 5
            //Console.WriteLine("Select an item from the list: ");
            //string item = Console.ReadLine();
            //int count = 0;

            //for (int i = 0; i < myList2.Count; i++)
            //{
            //    while (item == "")
            //    {
            //        Console.WriteLine("Please enter a value: ");
            //        string input = Console.ReadLine();
            //        item = input;
            //    }

            //    if (item == myList2[i])
            //    {
            //        Console.WriteLine(myList2[i]);
            //        count += 1;
            //    }

            //    else if (i == myList2.Count - 1 && count < 1)
            //    {
            //        Console.WriteLine("This item is not on the list");
            //    }

            //}

            List<string> myList3 = new List<string>() { "knife", "knife", "spoon" };
            List<string> myList3_copy = new List<string>();

            foreach (string i in myList3)
            {
                
                
                foreach(string j in myList3_copy)
                {
                    
                    if(i == j)
                    {
                        Console.WriteLine(i + " has appeared before");

                      
                    }
                    
                    
                }
                myList3_copy.Add(i);
                
            }
            
            Console.Read();
        }
    }
}
