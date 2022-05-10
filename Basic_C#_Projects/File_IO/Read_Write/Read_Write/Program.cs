using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Read_Write
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name in order for the program to read it back to you: ");
            string name = Console.ReadLine();

            using (StreamWriter file = new StreamWriter(@"C:\Users\Matt\OneDrive\Documents\GitHub\C_Sharp_Projects\Basic_C#_Projects\File_IO\Read_Write\Name.txt"))
            {
                file.WriteLine(name);
            }

            string text = File.ReadAllText(@"C:\Users\Matt\OneDrive\Documents\GitHub\C_Sharp_Projects\Basic_C#_Projects\File_IO\Read_Write\Name.txt");
            Console.WriteLine(text);
            Console.Read();
        }
    }
}
