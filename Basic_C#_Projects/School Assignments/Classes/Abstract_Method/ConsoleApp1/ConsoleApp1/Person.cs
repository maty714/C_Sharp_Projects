using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public abstract void SayName(); //what is the point of these? Need to research more
        
    }
}
