using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    class Constructor_Chain
    {
        public Constructor_Chain() : this(10)
        {
            // No parameter constructor method.// First Constructor  
        }

        public Constructor_Chain(int Age)
        {
            Console.WriteLine("This number is from the constructor chain: " + Age); 
        }

    }

}
