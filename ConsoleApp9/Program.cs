using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
         int photosCount = 52;
         int photosRow = 3;

         int fullRowsCount = photosCount / photosRow;
         int overRowsCount = photosCount % photosRow;

         Console.WriteLine("Полностью заполненных рядов - " + fullRowsCount);
         Console.WriteLine("Картинок сверх меры - " + overRowsCount);
        }
    }
}
