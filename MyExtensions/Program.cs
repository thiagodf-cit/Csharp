using System;

namespace MyExtensions
{
    class Program
    {
        static void Main()
        {
            Console.Write("24/04/2020 11:48:22: ");
            DateTime dt = new DateTime(2020, 04, 24, 11, 48, 22);

            Console.Write(dt.ElapsedTime());

            string str = "Good morning dear students!";
            Console.Write("\nCut: ");
            Console.Write(str.Cut(10));
        }
    }
}
