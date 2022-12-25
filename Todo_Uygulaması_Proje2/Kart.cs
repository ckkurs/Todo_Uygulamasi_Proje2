using System;

namespace Todo_Uygulaması_Proje2
{
    public class Kart
    {
        
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string Kisi { get; set; }
        public string Size { get; set; }
        public string Line { get; set; }
        
        public Kart(string baslik, string icerik, string kisi, string size, string line)
        {
            this.Baslik = baslik;
            this.Icerik = icerik;
            this.Kisi = kisi;
            this.Size = size;
            this.Line = line;

        }

        public Kart() { }
    }
    
    

    
}