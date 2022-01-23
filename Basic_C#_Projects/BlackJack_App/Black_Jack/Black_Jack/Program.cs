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
            int timesShuffled = 0;

            
            Game game = new TwentyOneGame(); //we use polymorphism to gain access to the listPlayers method in class TwentyOneGame. This method overides the one in class Game which will output the players, but also writes "Welcome to the game of 21"
            Player player = new Player();  //simple instance of class Player
            game.Players = new List<Player>();  //in order to list the players, we need to instantiate the List. Remember that TwentyOneGame inherits from class Game so we have that list property. This line of code instantiates this which is required
            
            player.Name = "Matt";
            game += player;
            game.ListPlayers();

            //Deck deck = new Deck(); //this object automatically calls the constructor which values were set by the constructor. Since these are the current values of the class Deck properties, this is what will be displayed when looping through each "object" in the list 
            //deck.shuffle(out timesShuffled, 3); //this will take the deck which was already created by the instructor and shuffle it. this part is done in the class Deck    
            
            //for (int i = 0; i < deck.Cards.Count; i++)// deck.cards comes from object created above
            //{
            //    Card card = deck.Cards[i]; // "Card card", in this situation, we are looping through an objects, so the variable "card" needs the type of "object". just like if we were looping through ints, that would then be an int relates to below, "deck.Cards[i] references the blank list that was filled up in the class Deck constructor
            //    Console.WriteLine(card.Face + " of " + card.Suit); // this writes out each property of each object above
            //}
            
            
            //Console.WriteLine(deck.Cards.Count);
            //Console.WriteLine("Number of times shuffled: " + timesShuffled);
            Console.Read();
        }

       
    }
}
