using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TonkCardGame.Model
{
    public class DiscardCard
    {
        public static ObservableCollection<Card> DiscardPile { get; set; }
    }
}
