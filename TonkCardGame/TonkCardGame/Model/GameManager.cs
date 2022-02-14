using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TonkCardGame.Model
{
    public static class GameManager
    {
  
        public static Stack<Card> DiscardDeck = new Stack<Card>();
        
        public static int FiveDollarBet = 5;
        public static int TenDollarBet = 10;
        public static int TwentyFiveDollar = 25;
        public static int OneHundredDollarBet = 100;

        public static List<Player> players = new List<Player>();
   
        public static void AddPlayers(int count)
        {
            Player p1 = new Player();
            Player cp1 = new Player();
            Player cp2 = new Player();
            Player cp3 = new Player();


            if (count == 2)
            {
                players.Add(p1);
                players.Add(cp1);
            }
            else if (count == 3)
            {
                players.Add(p1);
                players.Add(cp1);
                players.Add(cp2);
            }
            else if (count == 4)
            {
                players.Add(p1);
                players.Add(cp1);
                players.Add(cp2);
                players.Add(cp3);
            }

        }

        
        public static void DealCards()
        {
            players[0].MyCard = players[0].DealtCard();

            if (players.Count == 2)
            { 
                players[1].DealtCard();
            }
            else if(players.Count == 3)
            { 
                players[1].DealtCard();
                players[2].DealtCard();
            }
            else if (players.Count == 4)
            {
                players[1].DealtCard();
                players[2].DealtCard();
                players[3].DealtCard();
            }

           
            var PlayerOne = players[0].MyCard;
            players[0].Card1 = $"{PlayerOne[0].SuitValue}\n{PlayerOne[0].Symbol}";
            players[0].Card2 = $"{PlayerOne[1].SuitValue}\n{PlayerOne[1].Symbol}";
            players[0].Card3 = $"{PlayerOne[2].SuitValue}\n{PlayerOne[2].Symbol}";
            players[0].Card4 = $"{PlayerOne[3].SuitValue}\n{PlayerOne[3].Symbol}";
            players[0].Card5 = $"{PlayerOne[4].SuitValue}\n{PlayerOne[4].Symbol}";


        }

        public static Label DrawCard(Player player, Label label)
        {
            int index;
          
            var c = CardDeck.cards;
            var p = player.MyCard;

            if (p.Count <= 5 && p.Count > 0)
            {
                index = p.Count;

                p.Add(c[0]);

                label.Text = $"{p[index].SuitValue}\n{p[index].Symbol}";

                c.RemoveAt(0);
            }

            return label;
        }




        

        

        

    }
}
