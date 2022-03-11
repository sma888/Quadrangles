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
            Console.WriteLine("Выпуклый прямоугольник: ");
            ConvexQuadrilateral convexQuadrilateral = new ConvexQuadrilateral();
            convexQuadrilateral.Print();
            Console.WriteLine();

            Romb romb = new Romb();
            romb.Print();
            Console.ReadKey();
        }
    }
}
