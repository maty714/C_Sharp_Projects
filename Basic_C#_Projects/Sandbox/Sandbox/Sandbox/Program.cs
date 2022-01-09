using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Program
    {
        static void Main()
        {
            ////Math
            //int x = 5; 
            //float y = 7.67f;
            //int total;

            //total = x + Convert.ToInt32(y);
            //Console.WriteLine(total);
            //Console.WriteLine(x - y);
            //Console.WriteLine(x * y);
            //Console.WriteLine(y / x);


            ////string concatenation
            //string a = "Hello";
            //int b = 5;
            //string sentence = a + b;
            //Console.WriteLine(sentence);
            //Console.Read();

            ////Inputs
            //Console.WriteLine("Please enter a number to be multiplied by 50:");
            //string input = Console.ReadLine();
            //long num = Convert.ToInt32(input);

            //Console.WriteLine("Please enter a number to be added by 25: ");
            //string input2 = Console.ReadLine();
            //int num2 = Convert.ToInt32(input2);

            //Console.WriteLine("Please enter a number to be divided by 12.5: ");
            //string input3 = Console.ReadLine();
            //int num3 = Convert.ToInt32(input3);

            //Console.WriteLine("Please enter a number that see if it is greater than 50: ");
            //string input4 = Console.ReadLine();
            //int num4 = Convert.ToInt32(input4);
            //bool TrueORFalse = num4 > 50;

            //Console.WriteLine("Please enter a number that will ouput the remainder when divided by 7: ");
            //string input5 = Console.ReadLine();
            //int num5 = Convert.ToInt32(input5);


            ////Output
            //Console.WriteLine(num * 50);
            //Console.WriteLine(num2 + 25);
            //Console.WriteLine(num3 / 12.5);
            //Console.WriteLine(TrueORFalse);
            //Console.WriteLine(num5 % 7);

            //Console.Read();


            //string Fname = "Matthew";
            //string Mname = "Aaron";
            //string Lname = "Clark";

            //string FullName = Fname + " " + Mname + " " + Lname;
            //Console.WriteLine(FullName);
            //Console.Read();

            StringBuilder sb = new StringBuilder();


            sb.Append(new char[] { 'D', 'E', 'F' });
            sb.Replace("E", "");

            Console.WriteLine(sb);
            Console.Read();
        }
    }
}
