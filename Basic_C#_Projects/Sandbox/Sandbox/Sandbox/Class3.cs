using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Class3
    {
        public void multiply(string arg1, string arg2 = "2")
        {
            int num1 = Convert.ToInt32(arg1);
            int num2 = Convert.ToInt32(arg2);
            Console.WriteLine("Your two numbers multiplied = " + (num1 * num2));
        }

    }
}
