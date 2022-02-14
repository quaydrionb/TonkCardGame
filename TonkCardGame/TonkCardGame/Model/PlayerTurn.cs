using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace TonkCardGame.Model
{
    public class PlayerTurn
    {
        public bool Tapped;
        public void AddPlayerCard( Label playerLabel, Label discardPile)
        {
            List<Card> Player;
            Player = GameManager.players[0].MyCard;

            playerLabel.Text = $"{Player[5].SuitValue}\n {Player[5].Symbol}";

            discardPile.Text = $"{GameManager.DiscardDeck.Peek().SuitValue}\n{GameManager.DiscardDeck.Peek().Symbol}";

            discardPile.BackgroundColor = Color.White;

            playerLabel.IsVisible = true;

        }

        public void RemovePlayerCardSix(Card card,  Label label, List<Label> CardList, Label removedCard)
        {

            var Player = GameManager.players[0].MyCard;
            if (card == Player[0] || card == Player[1] || card == Player[2] || card == Player[3] || card == Player[4] || card == Player[5])
            {
                Player.Remove(card);

                label.BackgroundColor = Color.White;
                CardList[0].Text = $"{Player[0].SuitValue}\n {Player[0].Symbol}";
                CardList[1].Text = $"{Player[1].SuitValue}\n {Player[1].Symbol}";
                CardList[2].Text = $"{Player[2].SuitValue}\n {Player[2].Symbol}";
                CardList[3].Text = $"{Player[3].SuitValue}\n {Player[3].Symbol}";
                CardList[4].Text = $"{Player[4].SuitValue}\n {Player[4].Symbol}";
                removedCard.IsVisible = false;
            }
        

        }
        public void RemovePlayerCardFive(Card card, Label label, List<Label> CardList, Label removedCard)
        {


            var Player = GameManager.players[0].MyCard;
            if (card == Player[0] || card == Player[1] || card == Player[2] || card == Player[3] || card == Player[4])
            {
                Player.Remove(card);

                label.BackgroundColor = Color.White;
                CardList[0].Text = $"{Player[0].SuitValue}\n {Player[0].Symbol}";
                CardList[1].Text = $"{Player[1].SuitValue}\n {Player[1].Symbol}";
                CardList[2].Text = $"{Player[2].SuitValue}\n {Player[2].Symbol}";
                CardList[3].Text = $"{Player[3].SuitValue}\n {Player[3].Symbol}";
                removedCard.IsVisible = false;
            }


        }

        public void RemovePlayerCardFour(Card card, Label label, List<Label> CardList, Label removedCard)
        {


            var Player = GameManager.players[0].MyCard;
            if (card == Player[0] || card == Player[1] || card == Player[2] || card == Player[3] )
            {
                Player.Remove(card);

                label.BackgroundColor = Color.White;
                CardList[0].Text = $"{Player[0].SuitValue}\n {Player[0].Symbol}";
                CardList[1].Text = $"{Player[1].SuitValue}\n {Player[1].Symbol}";
                CardList[2].Text = $"{Player[2].SuitValue}\n {Player[2].Symbol}";
                removedCard.IsVisible = false;
            }


        }

        public void RemovePlayerCardThree(Card card, Label label, List<Label> CardList, Label removedCard)
        {


            var Player = GameManager.players[0].MyCard;
            if (card == Player[0] || card == Player[1] || card == Player[2] )
            {
                Player.Remove(card);

                label.BackgroundColor = Color.White;
                CardList[0].Text = $"{Player[0].SuitValue}\n {Player[0].Symbol}";
                CardList[1].Text = $"{Player[1].SuitValue}\n {Player[1].Symbol}";
                removedCard.IsVisible = false;
            }

        }

        public void RemovePlayerCardTwo(Card card, Label label, List<Label> CardList, Label removedCard)
        {

            var Player = GameManager.players[0].MyCard;
            if (card == Player[0] || card == Player[1] )
            {
                Player.Remove(card);

                label.BackgroundColor = Color.White;
                CardList[0].Text = $"{Player[0].SuitValue}\n {Player[0].Symbol}";
                removedCard.IsVisible = false;
            }

        }


    }


    

  

  
}
