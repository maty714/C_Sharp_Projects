using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class TwentyOneGame : Game, IWalkAway
    {
        public override void Play()
        {
            Console.WriteLine("This is the play method that overides game");
        }

        public override void ListPlayers() //this will override the ListPlayers in the base class Game. We then added functionality
        {
            Console.WriteLine("Welcome to the game of 21!");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
           throw new NotImplementedException();
        }
    }
}
