using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using TonkCardGame.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TonkCardGame.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FourPlayerGamePage : ContentPage
    {
        
        public int Tapped;
        private Card playerCard;
        private Label playerLabel;
        public List<Label> PlayerOneCard = new List<Label>();

        public PlayerTurn turn = new PlayerTurn();


        public FourPlayerGamePage()
        {
            InitializeComponent();

            CardDeck.CreateDeck();
            CardDeck.ShuffleDeck(3000);
            GameManager.AddPlayers(4);

            PlayerOneCard.Add(p1Card1);
            PlayerOneCard.Add(p1Card2);
            PlayerOneCard.Add(p1Card3);
            PlayerOneCard.Add(p1Card4);
            PlayerOneCard.Add(p1Card5);
            PlayerOneCard.Add(p1Card6);

            Bank();

            BindingContext = Tapped;
        }

        public void Bank()
        {
            P1Name.Text = $"Bank Account: {GameManager.players[0].Bank:c}";
            CP1Name.Text = $"Bank Amount: {GameManager.players[1].Bank:c}";
            CP2Name.Text = $"Bank Amount: {GameManager.players[2].Bank:c}";
            CP3Name.Text = $"Bank Amount: {GameManager.players[3].Bank:c}";
        }

        private void StartGame_Clicked(object sender, EventArgs e)
        {
            
         

            GameManager.DealCards();
            Bank();

            PlayerOneCard[0].Text = GameManager.players[0].Card1;
            PlayerOneCard[1].Text = GameManager.players[0].Card2;
            PlayerOneCard[2].Text = GameManager.players[0].Card3;
            PlayerOneCard[3].Text = GameManager.players[0].Card4;
            PlayerOneCard[4].Text = GameManager.players[0].Card5;

            PlayerOneCard[0].IsVisible = true;
            PlayerOneCard[1].IsVisible = true;
            PlayerOneCard[2].IsVisible = true;
            PlayerOneCard[3].IsVisible = true;
            PlayerOneCard[4].IsVisible = true;


            if (sender is Button button)
            {
                button.IsEnabled = false;
                button.IsVisible = false;
            }

            drawCards.IsEnabled = true;
            drawCards.IsVisible = true;

        }


        public async void DisplayStartButton()
        {
            await Task.Delay(4000);

            startGame.IsVisible = true;
        }

        public void NextPlayerTurn()
        {
            
        }
        public void DrawCards_Clicked(object sender, EventArgs e)
        {

            var player = GameManager.players[0];
            GameManager.DrawCard(player, PlayerOneCard[5]);

            PlayerOneCard[0].IsEnabled = true;
            PlayerOneCard[1].IsEnabled = true;
            PlayerOneCard[2].IsEnabled = true;
            PlayerOneCard[3].IsEnabled = true;
            PlayerOneCard[4].IsEnabled = true;
            PlayerOneCard[5].IsEnabled = true;
            PlayerOneCard[5].IsVisible = true;

            drawCards.IsEnabled = false;
            drawCards.IsVisible = false;
        }

        public async void DisableButtons(Button button)
        {
            FiveButton.IsEnabled = false;
            TenButton.IsEnabled = false;
            TwentyFiveButton.IsEnabled = false;
            OnehundredButton.IsEnabled = false;

            if (button == FiveButton)
            {
                await FiveButton.FadeTo(0, 1000);
                await TenButton.FadeTo(0, 1000);
                await TwentyFiveButton.FadeTo(0, 1000);
                await OnehundredButton.FadeTo(0, 1000);
            }
            else if (button == TenButton)
            {
                await TenButton.FadeTo(0, 1000);
                await TwentyFiveButton.FadeTo(0, 1000);
                await OnehundredButton.FadeTo(0, 1000);
                await FiveButton.FadeTo(0, 1000);
            }
            else if (button == TwentyFiveButton)
            {
                await TwentyFiveButton.FadeTo(0, 1000);
                await OnehundredButton.FadeTo(0, 1000);
                await FiveButton.FadeTo(0, 1000);
                await TenButton.FadeTo(0, 1000);
            }
            else if (button == OnehundredButton)
            {
                await OnehundredButton.FadeTo(0, 1000);
                await FiveButton.FadeTo(0, 1000);
                await TenButton.FadeTo(0, 1000);
                await TwentyFiveButton.FadeTo(0, 1000);
            }

        }

        private async void FiveDollarBet_Clicked(object sender, EventArgs e)
        {
            GameManager.players[0].Bank -= GameManager.FiveDollarBet;
            GameManager.players[1].Bank -= GameManager.FiveDollarBet;
            GameManager.players[2].Bank -= GameManager.FiveDollarBet;
            GameManager.players[3].Bank -= GameManager.FiveDollarBet;

            await FiveButton.RelRotateTo(360, 1000);
            FiveButton.BackgroundColor = Color.White;
            DisableButtons(FiveButton);
            DisplayStartButton();
        }
        private async void TenDollarBet_Clicked(object sender, EventArgs e)
        {
            GameManager.players[0].Bank -= GameManager.TenDollarBet;
            GameManager.players[1].Bank -= GameManager.TenDollarBet;
            GameManager.players[2].Bank -= GameManager.TenDollarBet;
            GameManager.players[3].Bank -= GameManager.TenDollarBet;

            await TenButton.RelRotateTo(360, 1000);
            TenButton.BackgroundColor = Color.White;
            DisableButtons(TenButton);
            DisplayStartButton();
        }
        private async void TwentyFiveDollarBet_Clicked(object sender, EventArgs e)
        {
            GameManager.players[0].Bank -= GameManager.TwentyFiveDollar;
            GameManager.players[1].Bank -= GameManager.TwentyFiveDollar;
            GameManager.players[2].Bank -= GameManager.TwentyFiveDollar;
            GameManager.players[3].Bank -= GameManager.TwentyFiveDollar;

            await TwentyFiveButton.RelRotateTo(360, 1000);
            TwentyFiveButton.BackgroundColor = Color.White;
            DisableButtons(TwentyFiveButton);
            DisplayStartButton();
        }
        private async void OneHundredDollarBet_Clicked(object sender, EventArgs e)
        {

            GameManager.players[0].Bank -= GameManager.OneHundredDollarBet;
            GameManager.players[1].Bank -= GameManager.OneHundredDollarBet;
            GameManager.players[2].Bank -= GameManager.OneHundredDollarBet;
            GameManager.players[3].Bank -= GameManager.OneHundredDollarBet;

            await OnehundredButton.RelRotateTo(360, 1000);
            OnehundredButton.BackgroundColor = Color.White;
            DisableButtons(OnehundredButton);
            DisplayStartButton();
        }
        public void OnTapped(Label label)
        {
            var PlayerOne = GameManager.players[0].MyCard;
            PlayerLabel(label, PlayerOne);

           

        }

        public Card CardNumber(Label label, List<Card> card)
        {
            switch (label.TabIndex)
            {
                case 0:
                    playerCard = card[0];
                    playerLabel = label;
                    break;
                case 1:
                    playerCard = card[1];
                    playerLabel = label;
                    break;
                case 2:
                    playerCard = card[2];
                    playerLabel = label;
                    break;
                case 3:
                    playerCard = card[3];
                    playerLabel = label;
                    break;
                case 4:
                    playerCard = card[4];
                    playerLabel = label;
                    break;
                case 5:
                    playerCard = card[5];
                    playerLabel = label;
                    break;
            }

            return playerCard;
        }


        public void PlayerLabel(Label label, List<Card> PlayerOne)
        {

            if (label == PlayerOneCard[0])
            {
                CardNumber(PlayerOneCard[0], PlayerOne);

            }
            else if (label == PlayerOneCard[1])
            {
                CardNumber(PlayerOneCard[1], PlayerOne);
            }
            else if (label == PlayerOneCard[2])
            {
                CardNumber(PlayerOneCard[2], PlayerOne);
            }
            else if (label == PlayerOneCard[3])
            {
                CardNumber(PlayerOneCard[3], PlayerOne);
            }
            else if (label == PlayerOneCard[4])
            {
                CardNumber(PlayerOneCard[4], PlayerOne);
            }
            else if (label == PlayerOneCard[5])
            {
                CardNumber(PlayerOneCard[5], PlayerOne);
            }

        }

        public void OnSwippedUpAsync(Label label)
        {
            try
            {
                if (label.BackgroundColor == Color.Gold)
                {
                    GameManager.DiscardDeck.Push(playerCard);

                    turn.RemovePlayerCardSix(playerCard, label, PlayerOneCard, PlayerOneCard[5]);
                    turn.RemovePlayerCardFive(playerCard, label, PlayerOneCard, PlayerOneCard[4]);
                    cardDeck.Text = $"{GameManager.DiscardDeck.Peek().SuitValue}\n {GameManager.DiscardDeck.Peek().Symbol}";

                    cardDeck.BackgroundColor = Color.Gold;
                }
            }
            catch (NullReferenceException)
            {
                return;
            }

        }

        private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            switch (e.Direction)
            {
                case SwipeDirection.Up:
                    OnSwippedUpAsync(playerLabel);
                    break;
                case SwipeDirection.Down:
                    OnSwippedDown();
                    break;
                case SwipeDirection.Left:
                    break;
                case SwipeDirection.Right:
                    break;
            }
        }

        private void OnSwippedDown()
        {
            var PlayerOne = GameManager.players[0].MyCard;
            PlayerOne.Add(GameManager.DiscardDeck.Peek());
            GameManager.DiscardDeck.Pop();

            if(PlayerOne.Count == 6)
            {
                turn.AddPlayerCard(PlayerOneCard[5], cardDeck);
            }
           

           
        }

        private void TapGestureRecognizerTapped(object sender, EventArgs e)
        {
          

            var label = (Label)sender;

            OnLabelChange(label);
      
            label.BackgroundColor = Color.Gold;
            OnTapped(label);



        }

        private Label OnLabelChange( Label label)
        {
            foreach (var item in PlayerOneCard)
            {
                if(item.BackgroundColor == Color.Gold)
                {
                    item.BackgroundColor = Color.White;
                }
                label = item;
            }

            return label;
           
        }
    }
}