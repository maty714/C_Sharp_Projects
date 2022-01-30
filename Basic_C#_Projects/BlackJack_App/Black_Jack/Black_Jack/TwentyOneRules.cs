using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    public static class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
         
        };


        private static int[] getAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace); //counts the number of aces in the hand
            int[] result = new int[aceCount + 1]; //Here we are creating an array with all possible values you can have with an ace. the size of the array depends on the number of aces. the plus 1 is taking into account the fact that ace can equal 11 or 1. If i have an ace and 10, well the total possible values are 11 or 21, which means there are two possible values, thus the array size is 2.
            int value = Hand.Sum(x => _cardValues[x.Face]); //this will find the lowest value. If I have an ace and 10, then the value is 11. This lambda expression looks up the values in the dictionary
            result[0] = value; //this takes the first value in the result array
            if (result.Length == 1)
            {
                return result;
            }

            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10);   //Note to self: You figured this out, look again if it isnt making sense in the future...This works as follows. index 0 is assigned the smallest amount per line 34. Now if we have Ace, Ace, 3, then the totals are 5, 15, 25. Since 5 belongs in index 0, 15 is the next value we worry about. value always starts at 5, and since we only want to add 10 to one of the aces(to get to 15), thats where 1*10 comes into play. This is why the loop starts at 1. this will represent the index for storing the value, and how many aces will be multiplied by 10. next round will be 2 which will add 20 cause 2 * 10. this represents the two aces being added by 10 
                result[i] = value;  //each index of the array is assigned a value based on i, which you know from the past
            }
            return result;
        }


        public static bool checkForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = getAllPossibleHandValues(Hand);
            int value = possibleValues.Max(); //If the hand has two aces, then this will not pass the blackjack test either it is valued at 2, or 22, either way it will not meet the requirment below. Same holds true if the max is above 21. Then you bust and false is returned
            if (value == 21)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool isBusted(List<Card> Hand)
        {
            int value = getAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        public static bool shouldDealerStay(List<Card> Hand)
        {

        }
    }
}
