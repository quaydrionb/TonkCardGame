using System;
using System.Collections.Generic;
using System.Text;
using static TonkCardGame.Model.Card;

namespace TonkCardGame.Model
{
    public static class  CardDeck
    {


        public static List<Card> cards;
       
        //getting current deck
      

        //Creates the deck
        public static void CreateDeck()
        {
            cards = new List<Card>();

            for(int suit = (int)Suit.Clubs; suit <= (int)Suit.Hearts; suit++)
            {
                for (int rank = (int)Rank.Ace; rank <= (int)Rank.King ; rank++)
                {
                    Card card = new Card((Suit)suit, (Rank)rank);
                    cards.Add(card);       
                    
                }
            }

        }

        // This shuffles the deck
        public static void ShuffleDeck(int shuffleTimes)
        {
            int cardCount = cards.Count;
            Random r = new Random();
            Card temp;

            for (int time = 0; time < shuffleTimes; time++)
            {

                for (int index = 0; index < cardCount; index++)
                {
                    //swap the cards
                    int SwapCards = r.Next(cardCount);
                    temp = cards[SwapCards];
                    cards[SwapCards] = cards[index];
                    cards[index] = temp;

                }

            }

        }
    }


}
