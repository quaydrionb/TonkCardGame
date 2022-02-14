using System.Collections.Generic;
using Xamarin.Forms;

namespace TonkCardGame.Model
{
    public class ComputerTurn
    {
        public void AddPlayerCard( Image playerCard, int index, Label discardPile)
        {
            List<Card> Player;
            Player = GameManager.players[index].MyCard;

          
            discardPile.Text = $"{GameManager.DiscardDeck.Peek().SuitValue}\n{GameManager.DiscardDeck.Peek().Symbol}";

            discardPile.BackgroundColor = Color.White;

            playerCard.IsVisible = true;

        }

        public void RemovePlayerCardSix(Card card, int index, Image removedCard)
        {

            var Player = GameManager.players[index].MyCard;
            if (card == Player[0] || card == Player[1] || card == Player[2] || card == Player[3] || card == Player[4] || card == Player[5])
            {
                Player.Remove(card);

                removedCard.IsVisible = false;
            }

        }
        public void RemovePlayerCardFive(Card card, int index, Image removedCard)
        {

            var Player = GameManager.players[index].MyCard;
            if (card == Player[0] || card == Player[1] || card == Player[2] || card == Player[3] || card == Player[4])
            {
                Player.Remove(card);

                removedCard.IsVisible = false;
            }

        }

        public void RemovePlayerCardFour(Card card, int index, Image removedCard)
        {


            var Player = GameManager.players[index].MyCard;
            if (card == Player[0] || card == Player[1] || card == Player[2] || card == Player[3])
            {
                Player.Remove(card);

                removedCard.IsVisible = false;
            }


        }

        public void RemovePlayerCardThree(Card card, int index, Image removedCard)
        {


            var Player = GameManager.players[index].MyCard;
            if (card == Player[0] || card == Player[1] || card == Player[2])
            {
                Player.Remove(card);

                removedCard.IsVisible = false;
            }

        }

        public void RemovePlayerCardTwo(Card card, int index, Image removedCard)
        {

            var Player = GameManager.players[index].MyCard;
            if (card == Player[0] || card == Player[1])
            {
                Player.Remove(card);
                removedCard.IsVisible = false;
            }

        }
    }
}
