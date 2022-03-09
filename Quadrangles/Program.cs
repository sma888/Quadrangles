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
            Calculation calculation = new Calculation();

            Console.WriteLine("Выпуклый четырехугольнк:");
            ConvexQuadrilateral convexQuadrilateral = new ConvexQuadrilateral();
            convexQuadrilateral.Print();
            Console.WriteLine();

            Square square = new Square();
            square.Print();
            calculation.Storona(square.X, square.Y);
            calculation.Diagonals(square.X, square.Y);
            Console.WriteLine();

            Romb romb = new Romb();
            romb.Print();
            Console.WriteLine();

            
            calculation.Diagonals(romb.X,romb.Y);
            Console.WriteLine();

            calculation.Storona(romb.X, romb.Y);
            Console.ReadKey();
        }
    }
}
