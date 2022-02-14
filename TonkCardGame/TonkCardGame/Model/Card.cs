using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TonkCardGame.Model
{
    public class Card
    {

        public Suit CardSuit { get; }
        public Rank Value { get; set; }

        public string Symbol { get; set; }

        public string SuitValue { get; set; }

        public string  LabelName { get; set; }
        public bool IsVisible { get; internal set; }
     
        public enum Suit
        {
            Clubs,
            Diamonds,
            Spades,
            Hearts
        }
        public enum Rank
        {
            Ace = 1, Two, Three, Four, Five, Six,
            Seven, Eight, Nine, Ten, Jack, Queen, King
        }

        public Card(Suit suit, Rank value)
        {
            if (!Enum.IsDefined(typeof(Suit), suit))
                throw new ArgumentOutOfRangeException("suit");
            if (!Enum.IsDefined(typeof(Rank), value))
                throw new ArgumentOutOfRangeException("rank");
            CardSuit = suit;
            Value = value;

            switch(CardSuit)
            {
                case Suit.Clubs:
                    Symbol = "♣";
                    break;
                case Suit.Hearts:
                    Symbol = "♥";
                    break;
                case Suit.Diamonds:
                    Symbol = "♦";
                    break;
                case Suit.Spades:
                    Symbol = "♠";
                    break;

            }

            switch (Value)
            {
                case Card.Rank.Ace:
                    SuitValue = "A";
                    break;
                case Card.Rank.King:
                    SuitValue = "K";
                    break;
                case Card.Rank.Queen:
                    SuitValue = "Q";
                    break;
                case Card.Rank.Jack:
                    SuitValue = "J";
                    break;
                case Card.Rank.Ten:
                    SuitValue = "10";
                    break;
                case Card.Rank.Nine:
                   SuitValue = "9";
                    break;
                case Card.Rank.Eight:
                    SuitValue = "8";
                    break;
                case Card.Rank.Seven:
                   SuitValue = "7";
                    break;
                case Card.Rank.Six:
                    SuitValue = "6";
                    break;
                case Card.Rank.Five:
                    SuitValue = "5";
                    break;
                case Card.Rank.Four:
                    SuitValue = "4";
                    break;
                case Card.Rank.Three:
                    SuitValue = "3";
                    break;
                case Card.Rank.Two:
                    SuitValue = "2";
                    break;
            }
        }

   
    }


        



    
   
}
