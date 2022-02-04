using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino2
{
   public  class FraudException: Exception
    {
        public FraudException(): base() { } //we utitilize this contructor when we DO NOT pass in any argument into the FraudException in class TwentyOneGame
        public FraudException(string message) : base(message) { } //we utilize this contructor when passing an argument into the Fraud Exception in class TwentyOneGame

    }
}
