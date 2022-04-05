using System;
using System.Collections.Generic;
using System.Text;

namespace Enum_Assignment
{
    public class Week
    {
        public Day day { get; set; }
       
    }

    public enum Day
    {
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday,
        sunday
    }
}
