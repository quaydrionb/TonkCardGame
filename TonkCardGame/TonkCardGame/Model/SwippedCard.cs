using System;
using System.Collections.Generic;
using System.Text;

namespace TonkCardGame.Model
{
    public class SwippedCard
    {
       public Card CardSwippedUp { get; set; }
        public Card CardSwippedDown { get; set; }
        public Card CardSwippedLeft { get; set; }
        public Card CardSwippedRight { get; set; }


        public void OnSwippedUp(Card card)
        {
           

        }




    }
}
