using System;
using System.Linq;

namespace Todo_Uygulaması_Proje2
{
    public class Tasımaİslemi:Veri
    {
         public void Taşı()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            string input = Console.ReadLine();

            foreach (var item in kartlar)
            {
                if(item.Baslik == input)
                {
                    Console.WriteLine("Bulunan Kart Bigileri");
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Başlık     : " + item.Baslik);
                    Console.WriteLine("İçerik     : " + item.Icerik);
                    Console.WriteLine("Atanan Kişi: " + item.Kisi);
                    Console.WriteLine("Büyüklük   : " + item.Size);
                    Console.WriteLine("Line       : " + item.Line);
                    Console.WriteLine();
                    Console.WriteLine("Lütfen taşıman istediğiniz Line'ı seçiniz:");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) INPROGRESS");
                    Console.WriteLine("(3) DONE");
                    int input1 = Convert.ToInt32(Console.ReadLine());

                    switch (input1)
                    {                        
                        case 1:
                        item.Line = "TODO";
                        break;
                        case 2:
                        item.Line = "INPROGRESS";
                        break;
                        case 3:
                        item.Line = "DONE";
                        break;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Hatalı bir tuşlama yaptınız.");
                    break;
                }
            }
        }
    }
}