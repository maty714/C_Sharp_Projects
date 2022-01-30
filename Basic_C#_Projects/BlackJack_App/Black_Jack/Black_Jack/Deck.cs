using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    public class Deck
    {
        public Deck() //This CONSTRUCTOR will fill  the list "Cards" below and will be called in program.cs
        {

            ////this section creates a blank list which will contain objects. 
            //Cards = new List<Card>();

            ////This is the process to fill the list with objects from the card class. which will mean that they have properties of face and suit
            //List<string> Suits = new List<string>() { "Clubs", "Hearts,", "Spades", "Aces" };
            //List<string> Faces = new List<string>()
            //{ 
            //    "Two", "Three", "Four", "Five", "Six", "Seven", 
            //    "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            //};

            //foreach (string face in Faces)
            //{
            //    foreach(string suit in Suits)
            //    {
            //        Card card = new Card(); //creates a new object/instance of class Card. The values in the class Card constructor are set to nothing automatically, these values will be replaced with the code below.
            //        card.Face = face; //this sets those values (Face) in the class Card constructor to the current index  
            //        card.Suit = suit; //this sets those values (Suit) in the class Card constructor to the current index
            //        Cards.Add(card);  //this adds that "object" with the properties set from above to the list. Remember, this is a list of "object" type
            //    }
            //}

            Cards = new List<Card>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Card card = new Card();
                    card.Suit = (Suit)i;
                    card.Face = (Face)j;
                    Cards.Add(card);
                }
            }
        }

        public void shuffle(out int timesShuffled, int times = 1) //"int times = 1" is optional. If a parameter is passed, that parameter will overide this optional one
        {
            timesShuffled = times;
            for (int i = 0; i < times; i++)
            {
                List<Card> Templist = new List<Card>(); //Creates a temp list to store shuffled deck into
                Random random = new Random(); //this is creating a new instance of the random class which is built in

                while (Cards.Count > 0) //"Cards" is accessed through the parameter here, and was set by the constructor
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    Templist.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex); //this removes each card from the deck and adds to the templist. this is also the counter for the loops condition. when a card is removed, the count goes down by 1 untill it is 0
                }
                Cards = Templist;  //remember deck.Cards, is the instance created above and it is accessing the list property that gets filled up through the constructor
            }

             
        }

        public List<Card> Cards { get; set; } //"Card" is a type. this whole thing is considered a property that will be used in the constructor above
    }
}

 
