using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Black_Jack
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand) //this takes the list of card object as a hand and will add another to it, if "hit". Card is the type as this has the face and suit property
        {                                 // remember "Hand" is a list, so it will have the built in functions of list, hence why hand.add is next
            Hand.Add(Deck.Cards.First()); // adds the first card from the Deck.Cards instance in line 12 and adds to the hand list that is passed into the method
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Matt\OneDrive\Documents\GitHub\C_Sharp_Projects\Basic_C#_Projects\BlackJack_App\Black_Jack\Log.txt", true))
            {
                file.WriteLine(card);
            }
            
            Deck.Cards.RemoveAt(0); //remove at is a built in method where you specify the index you want the item to be removed from. In this case it is 0 as that is the first card. Yes we are removing from the deck created in class Deck

        }
    }
}
