using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Statement_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Matt";
            //Console.WriteLine("Please guess my name: ");
            //string input = Console.ReadLine();
            //bool guess = name == input;

            ////checks if name equals input and exits program if it is
            //if (guess)
            //{
            //    Console.WriteLine("You guessed my name correctly! Press enter to exit");
            //    Console.Read();
            //    Environment.Exit(0);
            //}

            ////prompts user to guess again and checks the input 
            //while (!guess)
            //{
            //    Console.WriteLine("You did not guess my name, try again: ");
            //    string input1 = Console.ReadLine();

            //    if (input1 == name)
            //    {
            //        Console.WriteLine("You guessed my name correctly! Press enter to exit ");
            //        Console.Read();
            //        Environment.Exit(0);
            //    }
            //}


            string name = "Matt";
            Console.WriteLine("Please guess my name: ");
            string input = Console.ReadLine();
            bool guess = name == input;

            do
            {
                if (guess == true)
                {
                    Console.WriteLine("You guessed my name correctly! Press enter to exit");
                    Console.Read();
                    Environment.Exit(0);
                }

                else if (guess == false)
                {
                    Console.WriteLine("You did not guess my name correctly, try again: ");
                    string input2 = Console.ReadLine();
                    guess = name == input2;
                    //input = input2;
                }

            } while (guess == false);
            Console.WriteLine("You guessed my name correctly! Press enter to exit");
            Console.Read();
            


        }
    }
}
