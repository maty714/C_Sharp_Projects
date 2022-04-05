using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> newList = new List<Employee>();
            List<Employee> empList = new List<Employee>() 
            {
                new Employee(){ fName = "Joe", lname = "Smith", id = 1 },
                new Employee(){ fName = "Joe", lname = "Clark", id = 3  },
                new Employee(){ fName = "Jill", lname = "Clark", id = 4  },
                new Employee(){ fName = "Matt", lname = "Clark", id = 5  },
                new Employee(){ fName = "Adam", lname = "Lopez", id = 6  },
                new Employee(){ fName = "Joe", lname = "Packer", id = 7  },
                new Employee(){ fName = "Brittney", lname = "Smith", id = 8  },
                new Employee(){ fName = "Joe", lname = "Adams", id = 9  },
                new Employee(){ fName = "Mike", lname = "Trout", id = 10  },
                new Employee(){ fName = "Kevin", lname = "Costner", id = 11  },
            };

            //------------
            //   Step 2  
            //------------


            /*
            for (int i = 0; i < empList.Count; i++)
            {
                if (empList[i].fName == "Joe")
                {
                    newList.Add(empList[i]);
                }

            }*/




            //------------
            //   Step 3  
            //------------


            /*
            foreach (Employee employee in empList.FindAll(e => (e.fName == "Joe")))
            {
                newList.Add(employee);

            }*/




            //------------
            //   Step 4  
            //------------

            foreach (Employee employee in empList.FindAll(e => (e.id > 5)))
            {
                newList.Add(employee);

            }



            
            


            //Writes list to console
            for (int j = 0; j < newList.Count; j++)
            {
                Console.WriteLine(newList[j].fName);
            }



            Console.Read();
        }
    }
}
