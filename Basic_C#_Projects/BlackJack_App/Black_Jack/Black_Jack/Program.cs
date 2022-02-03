using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino2;
using Casino2.TwentyOne;

namespace Black_Jack
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Welcome to Casino de Matt. Let's start by telling me your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello {0}, would you like to play Black Jack?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.ID = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Matt\OneDrive\Documents\GitHub\C_Sharp_Projects\Basic_C#_Projects\BlackJack_App\Black_Jack\Log.txt", true))
                {
                    file.WriteLine(player.ID);
                }
                Game game = new TwentyOneGame();  //used to expose the overloaded methods
                game += player; //What part of the game is this player being added to?
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing");

            }
            Console.WriteLine("Please feel free to look around the casino!");
            Console.Read();
        }

       
    }
}
