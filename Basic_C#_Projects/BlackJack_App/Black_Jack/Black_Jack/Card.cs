using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    public class Card
    {
        //public Card() //Constructor
        //{
        //    Suit.Suit = "";
        //    Face = "";
        //}
        public Suit Suit { get; set; } //this data type matches the enum below
        public Face Face { get; set; } //this data type matches the enum below
    }

    public enum Suit
        {
            Diamonds,
            Hearts,
            Clubs,
            Spades
        }

        public enum Face
        {
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }
    
}
