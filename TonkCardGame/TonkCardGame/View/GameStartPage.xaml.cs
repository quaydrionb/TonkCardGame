using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TonkCardGame.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GameStartPage : ContentPage
    {

        public GameStartPage()
        {
            InitializeComponent();
        }

        private async void TwoPlayer_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TwoPlayerGamePage());
        }

        private async void ThreePlayer_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ThreePlayerGamePage());
        }

        private async void FourPlayer_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FourPlayerGamePage());
        }
    }
}