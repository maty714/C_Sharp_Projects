using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erro_Handling
{
    class Program
    {
        static void Main()
        {
            List<int> myList = new List<int>() { 1,2,3,4,5,6,7 };

            try { 
            Console.WriteLine("Please enter a divisor: ");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);


            for (int i = 0; i < myList.Count; i++) 
            {
                Console.WriteLine("index " + i + " divided by " + num + " = " + myList[i] / num);
            }
            }

            catch (DivideByZeroException dbz) //if user enters 0, displays message that user cannot divide by 0
            {
                Console.WriteLine(dbz.Message);
                Console.WriteLine("Cannot divide by 0");
            }

            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Please enter a number");
            }

            finally{
                Console.Read();
            }
            
        }
    }
}
