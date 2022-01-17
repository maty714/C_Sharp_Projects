using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Class2
    {
        public int addition(int arg1)
        {
            return arg1 + 2;
        }

        public int addition(int arg1, decimal arg2)
        {
            return arg1 + Convert.ToInt32(arg2);
        }

        public int addition(int arg1, decimal arg2, string arg3)
        {
            return arg1 + Convert.ToInt32(arg2) + Convert.ToInt32(arg3);
        }

    }
}