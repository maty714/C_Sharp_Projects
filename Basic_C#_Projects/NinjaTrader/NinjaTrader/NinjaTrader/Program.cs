using System;
using System.Collections.Generic;

namespace NinjaTrader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { -1, -2, -3, -4, -5, -6 };
            int count = 0;
            
            for(int i = list.Count - 1; i >= list.Count - 3; i--)
            {
               if (list[i] > 0)
                {
                    Console.WriteLine("Keep Trading");
                    break;
                }
               
            }
            
            
            Console.Read();

        }
    }
}
