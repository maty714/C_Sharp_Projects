using System;
using System.Collections.Generic;


namespace Array_App
{
    class Program
    {
        static void Main()
        {
            string[] Car = new string[] { "Tesla", "F-150", "Corolla" };
            int[] Miles = new int[] { 10000, 5000, 80000 };
            List<string> myList = new List<string>();
            myList.Add("Index1");
            myList.Add("Index2");
            myList.Add("Index3");

            Console.WriteLine("Please select a number between 0-2: ");
            string input1 = Console.ReadLine();
            int index = Convert.ToInt32(input1);

            Console.WriteLine("Please select another number between 0-2: ");
            string input3 = Console.ReadLine();
            int index1 = Convert.ToInt32(input3);

            while (index > 2 && index1 > 2)
            {
                Console.WriteLine("Please select a number between 0-2;");
                string input2 = Console.ReadLine();
                index = Convert.ToInt32(input2);

                Console.WriteLine("Please select a number between 0-2;");
                string input4 = Console.ReadLine();
                index1 = Convert.ToInt32(input4);
            }
            Console.WriteLine(Car[index]);
            Console.WriteLine(Miles[index1]);

            Console.WriteLine("Please select a number from 0-2 to display the index of a list: ");
            string list_input = Console.ReadLine();
            int index2 = Convert.ToInt32(list_input);
            Console.WriteLine(myList[index2]);

            Console.Read();
        }
    }
}
