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

            Employee Id = new Employee();
            Id.ID = 123;
            Employee Id2 = new Employee();
            Id2.ID = 123;

            Console.WriteLine(Id == Id2);
            Console.Read();
        }
    }
}
