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
            bool isValidAnswer = false;
            int bank = 0;

            Console.WriteLine("Welcome to Casino de Matt. Let's start by telling me your name: ");
            string playerName = Console.ReadLine();

            while (!isValidAnswer)
            {
                Console.WriteLine("How much money did you bring today?");
                string amount = Console.ReadLine();
                isValidAnswer = int.TryParse(amount, out bank);
                if (!isValidAnswer)
                {
                    Console.WriteLine("Please enter a number with digits and decimals only");
                }
                
            }


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
                    try 
                    {

                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security, kick this person out!");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occured, please contact your administrator.");
                        Console.ReadLine();
                        return;
                    }
                    
                }
                game -= player;
                Console.WriteLine("Thank you for playing");

            }
            Console.WriteLine("Please feel free to look around the casino!");
            Console.Read();
        }

       
    }
}
