using System;

namespace Enum_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
              
                Console.Write("Please enter the day of the week: ");
                string input = Console.ReadLine();
                string dayOfWeek = input.ToLower();

                Day day = (Day)Enum.Parse(typeof(Day), dayOfWeek);

                if (day == Day.monday)
                {
                    Console.WriteLine(Day.monday);
                }
                else if(day == Day.tuesday)
                {
                    Console.WriteLine(Day.tuesday);
                }
                else if (day == Day.wednesday)
                {
                    Console.WriteLine(Day.wednesday);
                }
                else if (day == Day.thursday)
                {
                    Console.WriteLine(Day.thursday);
                }
                else if (day == Day.friday)
                {
                    Console.WriteLine(Day.friday);
                }
                else if (day == Day.saturday)
                {
                    Console.WriteLine(Day.saturday);
                }
                else if (day == Day.sunday)
                {
                    Console.WriteLine(Day.sunday);
                }
                else
                {
                    Console.WriteLine("That day of the week does not exist");
                }

            }
            catch
            {
                Console.WriteLine("That day of the week does not exist");
            }
            
        }
    }
}
