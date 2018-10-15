using System;

namespace TD_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cas rectangle");
            Rectangle rectangle1 = new Rectangle(2,5);
            Console.WriteLine(rectangle1.AfficherRectangle());

            Console.WriteLine();
            Console.WriteLine("Cas carré");
            Rectangle rectangle2 = new Rectangle(2, 2);
            Console.WriteLine(rectangle2.AfficherRectangle());
        }
    }
}
