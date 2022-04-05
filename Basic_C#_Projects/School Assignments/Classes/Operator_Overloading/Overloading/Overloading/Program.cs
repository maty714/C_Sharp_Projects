using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<int> generic = new Employee<int>();
            Employee<string> generic2 = new Employee<string>();
            generic.NewList = new List<int>() { 1, 2, 3, 4, 5, 6 };
            generic2.NewList = new List<string>() { "a", "b", "c", "d", "e" };


            foreach (int nums in generic.NewList)
            {
                Console.WriteLine(nums);
            }

            foreach(string letter in generic2.NewList)
            {
                Console.WriteLine(letter);
            }

            //Employee Id = new Employee();
            //Id.ID = 123;
            //Employee Id2 = new Employee();
            //Id2.ID = 123;

            //Console.WriteLine(Id == Id2);
            Console.Read();
        }
    }
}
