using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TonkCardGame.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TonkCardGame
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void GamePlay_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GameStartPage());
        }
    }
}