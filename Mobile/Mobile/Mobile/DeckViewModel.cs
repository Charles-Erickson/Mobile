using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Mobile
{
    class DeckViewModel : BaseFodyObservable
    {

        public DeckViewModel()
        {
            GroupedTodoList = GetGroupedTodoList();
        }
        public ILookup<string, Card> GroupedTodoList { get; set; }
        public string Title => "Pokemon";
        public new List<Card> _deck { get; set; } = new List<Card>
        {
            new Card { Id = 0, PokedexNum=1, Name = "Bulbasaur", Element="Grass", Evolution=true},
            new Card { Id = 1, PokedexNum=23, Name = "Bulbasaur", Element="Grass", Evolution=true},
            new Card { Id = 2, PokedexNum=144, Name = "Articuno", Element="Ice", Evolution=false}
        };
        private ILookup<string, Card> GetGroupedTodoList()
        {
            return _deck.OrderBy(t => t.PokedexNum).ThenByDescending(t=>t.Element);
        }
    }

}
