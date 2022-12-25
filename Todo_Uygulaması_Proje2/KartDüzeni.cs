using System;
using System.Collections.Generic;

namespace Todo_Uygulaması_Proje2
{
    public class KartDüzeni
    {
         public static void KartGöster(string Line, List<Kart> listeismi)
        {
            Console.WriteLine(Line);
            Console.WriteLine("*********************");
            foreach (var item in listeismi)
            {
                Console.WriteLine("Başlık   :" + item.Baslik);
                Console.WriteLine("İçerik   :" + item.Icerik);
                Console.WriteLine("Atanan Kişi:" + item.Kisi);
                Console.WriteLine("Büyüklük   :" + item.Size);
                Console.WriteLine("-----------------------");

            }
        }
    }
}
