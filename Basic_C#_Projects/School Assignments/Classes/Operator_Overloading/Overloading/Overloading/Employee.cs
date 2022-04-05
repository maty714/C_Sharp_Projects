using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    public class Employee <t>
    {
        //public Employee()
        //{
        //    this.ID = 0;

        //}

        //public Employee(int id)
        //{
        //    this.ID = id;

        //}

        //public static bool operator ==(Employee Id1, Employee Id2) //these will not have arguments like traditional functions. they are what is being compared.
        //{
        //    return (Id1.ID == Id2.ID);
        //}

        //public static bool operator !=(Employee Id1, Employee Id2)
        //{
        //    return (Id1.ID != Id2.ID);
        //}

        //public int ID { get; set; }


        public List<t> NewList { get; set; }
    }
}
