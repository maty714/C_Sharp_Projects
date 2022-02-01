using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            DateTime time_now = DateTime.Now; 
            DateTime time = DateTime.Now.AddHours(num);

            Console.WriteLine("The current time is {0}", time_now);
            Console.WriteLine("The current time in 2 hours is {0}", time);

            Console.Read();
        }
    }
}
