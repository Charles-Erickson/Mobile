using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Mobile
{
    class DeckViewModel : BaseFodyObservable
    {
        public string Title => "Pokemon";
        public new ObservableCollection<Card> Deck { get; set; } = new ObservableCollection<Card>
        {
            new Card { Id = 0, PokedexNum=1, Name = "Bulbasaur", Element="Grass", Evolution=true},
            new Card { Id = 1, PokedexNum=23, Name = "Bulbasaur", Element="Grass", Evolution=true},
            new Card { Id = 2, PokedexNum=144, Name = "Articuno", Element="Ice", Evolution=false}
        };
    }

}
