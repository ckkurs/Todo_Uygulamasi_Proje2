using System;
using System.Linq;

namespace Todo_Uygulaması_Proje2
{
    public class Silmeİslemi:Veri
    {
         public void sil()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen Kart başlığını yazınız:");
            string input = Console.ReadLine();

            foreach (var item in kartlar.ToList())
            {
                if (item.Baslik == input)
                {
                    kartlar.Remove(item);
                    break;
                }
                else
                {
                    Console.WriteLine("Aradığınız Kritere Uygun Kart board'da bulunamadı.");
                    Console.WriteLine("* Silmeyi sonlandırmak için (1)");
                    Console.WriteLine("*Yeniden denemek için (2)");
                    int input1 = Convert.ToInt32(Console.ReadLine());


                    if (input1 == 1)
                    {
                        Console.WriteLine("Çıkış Yapılıyor.");
                        break;
                    }
                    else
                    {
                        sil();
                    }


                }
            }
        }
    }
}