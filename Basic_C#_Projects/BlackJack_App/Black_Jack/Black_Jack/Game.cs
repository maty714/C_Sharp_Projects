using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    public abstract class Game
    {

        public List<Player> Players { get; set; } //with lists, we still have to instantiate them even though this property us defined here
        public string Name { get; set; }
        public string Dealer { get; set; }

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
