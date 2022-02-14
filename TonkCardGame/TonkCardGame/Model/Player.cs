using System;
using System.Collections.Generic;
using System.Text;

namespace TonkCardGame.Model
{
    public  class Player
    {
        public string Name { get; set; }


        //This determines the starting turn order
        public int Position { get; set; }

        public int Bank = 500;

    

        public string Card1 { get; set; }
        public string Card2 { get; set; }
        public string Card3 { get; set; }
        public string Card4 { get; set; }
        public string Card5 { get; set; }


        public List<Card> MyCard { get; set; }


    

        public  List<Card> DealtCard()
        {

            var c = CardDeck.cards;

            List<Card> Hand = new List<Card>
            {
                 // Adds the first five cards from the deck
                c[0],
                c[1],
                c[2],
                c[3],
                c[4]
            };

            // Removes the five cards from the deck
            c.RemoveRange(0, 5);

            return Hand;

        }

    }

}
