using System;
using System.Collections.Generic;

namespace Todo_Uygulaması_Proje2
{
    internal class Board
    {
        public List<Kart>? ToDO { get; set; }
        public List<Kart>? InProgress { get; set; }
        public List<Kart>? Done { get; set; }
    }
    
}