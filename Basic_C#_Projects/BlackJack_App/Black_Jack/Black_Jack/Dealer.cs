using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand) //this takes the list of card object as a hand and will add another to it, if "hit". Card is the type as this has the face and suit property
        {
            Hand.Add(Deck.Cards.First()); // adds the first card from the Deck.Cards instance in line 12 and adds to the hand list that is passed into the method
            Console.WriteLine(Deck.Cards.First().ToString() + "/n");
            Deck.Cards.RemoveAt(0); //remove at is a built in method where you specify the index you want the item to be removed from. In this case it is 0 as that is the first card

        }
    }
}
