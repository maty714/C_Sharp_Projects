using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    public class Player
    {
        public Player(string PlayerName, int beginningBalance)
        {
            Hand = new List<Card>();
            Name = PlayerName;
            Balance = beginningBalance;
           
        }
        
        public List<Card> Hand { get; set; } //this is the players hand
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool stay { get; set; }
        
        public bool Bet (int amount) //bet from TwentyOneGame is fed as the parameter
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to make a bet that size");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }

        public static Game operator-(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
