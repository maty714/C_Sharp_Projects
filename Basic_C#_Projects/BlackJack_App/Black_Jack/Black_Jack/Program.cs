using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(); //this object automatically calls the constructor which values were set by the constructor. Since these are the current values of the class Deck properties, this is what will be displayed when looping through each "object" in the list
            deck = shuffle(deck);

            for (int i = 0; i < deck.Cards.Count; i++)// deck.cards comes from object created above
            {
                Card card = deck.Cards[i]; // "Card card", in this situation, we are looping through an objects, so the variable "card" needs the type of "object". just like if we were looping through ints, that would then be an int relates to below, "deck.Cards[i] references the blank list that was filled up in the class Deck constructor
                Console.WriteLine(card.Face + " of " + card.Suit); // this writes out each property of each object above
            }
            Console.WriteLine(deck.Cards.Count);
            Console.Read();
        }

       public static Deck shuffle(Deck deck) //takes instance of class Deck as arg
        {
            List<Card> Templist = new List<Card>(); //Creates a temp list to store shuffled deck into
            Random random = new Random(); //this is creating a new instance of the random class which is built in

            while (deck.Cards.Count > 0) //"deck" comes from the arg. because this is type class, we are able to access all the parameters
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                Templist.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex); //this removes each card from the deck and adds to the templist. this is also the counter for the loops condition. when a card is removed, the count goes down by 1 untill it is 0
            }
            deck.Cards = Templist;  //remember deck.Cards, is the instance created above and it is accessing the list property that gets filled up through the constructor
            return deck;
        }
    }
}
