using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public static class Class1
    {
        public static void static_class(string arg1, out int output_Para)
        {
            output_Para = 4;
            int num1 = Convert.ToInt32(arg1);;
            Console.WriteLine( "Input plus 2 =  " + (num1 + 3));
        }
    }
}
