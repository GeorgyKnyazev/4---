using System;

namespace _4___задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPicturesInRow = 3;
            int imagesFromUser = 52;
            int fullyFilledRows = imagesFromUser / numberOfPicturesInRow;
            int picturesInAnIncompleteRow = imagesFromUser % numberOfPicturesInRow;
            Console.WriteLine("Количество заполненых рядов " + fullyFilledRows + ", кртинок в не полном ряду " + picturesInAnIncompleteRow + ".");
        }
    }
}
