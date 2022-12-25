using System;
using System.Linq;

namespace Todo_Uygulaması_Proje2
{
    public class Listelemeİslemi
    {
        private static Board boards;
        public static void LineBoard()
        {
            var todo = Veri.kartlar.Where(x => x.Line == "TODO").ToList();
            var inprogress = Veri.kartlar.Where(x => x.Line == "INPROGRESS").ToList();
            var done = Veri.kartlar.Where(x => x.Line == "DONE").ToList();


            boards = new Board();
            boards.ToDO = todo;
            boards.InProgress = inprogress;
            boards.Done = done;

        }
        public  void Listele()
        {
            LineBoard();
            KartDüzeni.KartGöster("TODO Line", boards.ToDO);
            KartDüzeni.KartGöster("INPROGRESS Line", boards.InProgress);
            KartDüzeni.KartGöster("DONE Line", boards.Done);
        }

    }
}