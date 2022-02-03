using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino2
{
    public class Player
    {
        public Player(string PlayerName, int beginningBalance)
        {
            Hand = new List<Card>();
            Name = PlayerName;
            Balance = beginningBalance;
           
        }

        private List<Card> _hand = new List<Card>(); //again this gets created as we need to instantiate the List<Card> property, otherwise it will return a null when called upon. Same as the List<Card> in class Game
        public List<Card> Hand { get { return _hand; } set { _hand = value; } } //this is the players hand
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool stay { get; set; }
        public Guid ID { get; set; }
        
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
