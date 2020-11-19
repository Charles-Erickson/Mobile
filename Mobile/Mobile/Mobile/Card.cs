using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile
{
    class Card : BaseFodyObservable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Element { get; set; }
        public bool Evolution { get; set; }   
    }
}
