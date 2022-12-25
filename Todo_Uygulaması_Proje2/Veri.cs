using System;
using System.Collections.Generic;

namespace Todo_Uygulaması_Proje2
{
    
    public class Veri:Kart
    {
        public static List<Kart> kartlar = new List<Kart>();
        public static List<Kisi> kişiler = new List<Kisi>();

        static Veri()
        {
            kişiler = new List<Kisi>()
            {
                new Kisi{Id = 1, Isim= "Yusuf"},
                new Kisi{Id = 2, Isim= "Okan"},
                new Kisi{Id = 3, Isim= "Mehmet"},
                new Kisi{Id = 4, Isim= "Ali"},
            };

            kartlar = new List<Kart>()
            {
                new Kart{Baslik= "Ödev", Icerik= "C# Ödevi ", Kisi = "Yusuf",Size ="M",Line ="TODO"},
                new Kart{Baslik="Toplantı",Icerik=" Proje Ödevi",Kisi="Okan",Size= "XL",Line ="DONE"},
                new Kart{Baslik= "Eğitim", Icerik= "C# Video ", Kisi = "Mehmet",Size ="XS",Line ="TODO"},
                new Kart{Baslik="Proje",Icerik=" TODO Ödevi",Kisi="Ali",Size= "L",Line ="DONE"}
            };
        }
             public static void VeriYaz()
             {
                  foreach (var item in kartlar)
                  {
                    Console.WriteLine(item.Baslik + " " + item.Icerik + " " + item.Kisi + " " + item.Size + " " + item.Line);
                  }
             }
    }
}
