﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
   public class Card
    {
        public Card()
        {
            Suit = "";
            Face = "";
        }
        public string Suit { get; set; }
        public string Face { get; set; }
        
    }
}