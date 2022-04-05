using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Class2
    {
        public void divide(string arg1)
        {
            int num1 = Convert.ToInt32(arg1);
            Console.WriteLine(num1 / 2);
        }

        public void divide(string arg1, string arg2)
        {
            int num1 = Convert.ToInt32(arg1);
            int num2 = Convert.ToInt32(arg2);
            Console.WriteLine((num1 + num2) / 2);
        }

    }
}
