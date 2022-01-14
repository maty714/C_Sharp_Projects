using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class Deck
    {
        public Deck() //This constructor will fill  the list "Cards" below and will be called in program.cs
        {
            
            //this section creates a blank list which will contain objects. 
            Cards = new List<Card>();

            //This is the process to fill the list
            List<string> Suits = new List<string>() { "Clubs", "Hearts,", "Spades", "Aces" };
            List<string> Faces = new List<string>()
            { 
                "Two", "Three", "Four", "Five", "Six", "Seven", 
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach(string suit in Suits)
                {
                    Card card = new Card(); //creates a new object/instance of class Card. The values in the class Card constructor are set to nothing automatically, these values will be replaced with the code below.
                    card.Face = face; //this sets those values (Face) in the class Card constructor to the current index  
                    card.Suit = suit; //this sets those values (Suit) in the class Card constructor to the current index
                    Cards.Add(card);  //this adds that "object" with the properties set from above to the list. Remember, this is a list of "object" type
                }
            }
        }

      
        public List<Card> Cards { get; set; } //"Card" is a type. this whole thing is considered a property that will be used in the constructor above
    }
}

 
