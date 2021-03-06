using System;
using System.Linq;

public class TextHelper
{
    public static void Main()
    {
        Console.WriteLine("Please enter a string");
        string input = Console.ReadLine();
        Console.WriteLine("Please enter the number of characters you want to show");
        int num = Convert.ToInt32(Console.ReadLine());

        
        Console.WriteLine(Character_Limit(input, num));
        Console.Read();
    }

    //Limits the the amount of characters shown in a string.
    public static string Character_Limit(string input, int num)
    {

        //converts a string to a character array
        char[] ch = input.ToCharArray();


        //loops through the array from the last element to the first, and replaces each element with a "."
        for (int i = ch.Count(); i > num; i--)
        {
            ch[i - 1] = '.';
        }

        //converts character array back to string to be returned by the method
        string output = new string(ch);
        return output;



    }




}
