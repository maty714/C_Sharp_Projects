using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    public class TwentyOneDealer : Dealer
    {
        public List<Card> Hand { get; set; }
        public bool stay { get; set; }
        public bool isBusted { get; set; }
    }
}
