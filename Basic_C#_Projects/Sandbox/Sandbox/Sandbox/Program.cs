using System;
using System.Collections.Generic;


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

            //StringBuilder sb = new StringBuilder();


            //sb.Append(new char[] { 'D', 'E', 'F' });
            //sb.Replace("E", ""); // note to self: use this to remove PM in hacker rank

            //Console.WriteLine(sb);
            //Console.Read();

            //calling methods from a class

            //Class1 Math = new Class1();
            //Console.WriteLine("Please enter a number which will have math performed on it: ");
            //string input = Console.ReadLine();
            //int num = Convert.ToInt32(input);

            ////calls each method within the class1 and stores the returned values withing a variable
            //int addition = Math.addition(num);
            //int subtraction = Math.subtraction(num);
            //int multiplication = Math.multiplication(num);


            //Console.WriteLine("Your number added by 2 = " + addition);
            //Console.WriteLine("Your number subtracted by 2 = " + subtraction);
            //Console.WriteLine("Your number multiplied by 2 = " + multiplication);

            //Console.Read();

            ////Utilizes Class2 methods
            //Class2 math = new Class2();
            //Console.WriteLine(math.addition(2));
            //Console.WriteLine(math.addition(2, 2.44m));
            //Console.WriteLine(math.addition(2, 2.44m, "3"));
            //Console.Read();

            //Utilizes Class3 Methods

            Class3 math = new Class3();
            Console.WriteLine("Please input up to two numbers: ");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();



            math.multiply(input1);
            Console.Read();




        }
    }
}
