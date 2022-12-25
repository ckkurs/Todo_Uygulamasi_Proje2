using System;

namespace Todo_Uygulaması_Proje2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz.");
            Console.WriteLine("*****************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            int input = Convert.ToInt32(Console.ReadLine());
            

            switch (input)
            { 
                case 1:
                Listelemeİslemi listeleme = new Listelemeİslemi(); 
                listeleme.Listele();
                break;
                case 2:
                Eklemeİslemi ekleme = new Eklemeİslemi();
                ekleme.Ekle();
                break;
                case 3:
                Silmeİslemi silme = new Silmeİslemi();
                silme.sil();
                break;
                case 4:
                Tasımaİslemi taşıma = new Tasımaİslemi();
                taşıma.Taşı();
                break;
                default:
                Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                break;
            }
        }
    }
}
