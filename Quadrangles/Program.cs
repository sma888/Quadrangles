using QuadranglesLibrary;
using QuadranglesLibrary.Child;
using QuadranglesLibrary.Method;
using System;

namespace Quadrangles
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выпуклый 4-х углольник");
            ConvexQuadrilateral convexQuadrilateral = new ConvexQuadrilateral();
            convexQuadrilateral.Print();

            Console.WriteLine("\nКвадрат:");
            Square square = new Square();
            square.Print();

            Console.WriteLine("\n Ромб:");
            Romb romb = new Romb();
            romb.Print();
            Console.ReadKey();
        }
    }
}
