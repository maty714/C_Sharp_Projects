using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer dealer { get; set; }

        public override void Play()
        {
            dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.stay = false;
            }
            dealer.Hand = new List<Card>();
            dealer.stay = false;
            dealer.Deck = new Deck(); //this creates a new deck. Look at deck class for how that is made if you forget. We need this because we would then have a partial deck if we played again
            Console.WriteLine("Place your bet!");

            foreach(Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);   //calls the class Player method "bet" using the instance
                if (!successfullyBet)                   //This is equivalent to saying "successfullyBet == false"
                {
                    return;
                }
                Bets[player] = bet; //if the player is able to make the bet before the hand is dealt, we store it in a dictionary, so when it comes time to pay, we do it per what is in the dictionary
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing....");
                foreach (Player player in Players)
                {
                    Console.Write("Player {0}:  ", player.Name);
                    dealer.Deal(player.Hand);     //what is happening is that we are passing in a new list into the deal method of instance dealer of class twentyOneDealer, which inherits from class Dealer. This in turn adds the first card from the newly formed deck in line 23
                    if (i == 1)                     //think about indexing here. 1 is the technically the second card.
                    {
                        bool blackjack = TwentyOneRules.checkForBlackJack(player.Hand);
                        if (blackjack)
                        {
                            Console.Write("You Win! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += (Convert.ToInt32(Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }                
                }
                Console.Write("Dealer...");
                dealer.Deal(dealer.Hand);
                if (i == 1)
                {
                    bool blackjack = TwentyOneRules.checkForBlackJack(dealer.Hand);
                    if (blackjack)
                    {
                        Console.WriteLine("Dealer has blackjack!");
                        foreach(KeyValuePair<Player, int> entry in Bets)
                        {
                            dealer.Balance += entry.Value;
                        }
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card Card in player.Hand)
                    {
                        Console.WriteLine("{0}", Card.ToString());
                    }
                    Console.WriteLine("/n/nHit or stay");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.isBusted(player.Hand);
                    if (busted)
                    {
                        dealer.Balance += Bets[player];
                        Console.WriteLine("Bust!, you lose. Your balance is now {0}", player.Balance);
                        Console.WriteLine("Would you like to play again? Please input yes or no");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes")
                        {
                            player.isActivelyPlaying = true;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                        }
                    }
                }
            }
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
