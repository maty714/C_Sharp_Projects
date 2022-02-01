using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public abstract class Game
    {

        private List<Player> _players = new List<Player>(); //we use this to instantiate the list. We have to do this if we are to use it and fill with items. Remove this and the get set and run the program to see what happens
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } } //with lists, we still have to instantiate them even though this property is defined here
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        public abstract void Play();
        public virtual void ListPlayers() //virtual methods exist inside abstract classes. They have implementation unlike abstract methods, but they can be overriden
        {

            foreach(Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }

    }
}
