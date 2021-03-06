using QuadranglesLibrary.Method;
using System;

namespace QuadranglesLibrary
{
    public class ConvexQuadrilateral
    {
        public double[] X = new double[7];
        public double[] Y = new double[7];
        Calculation calculation = new Calculation();

        public ConvexQuadrilateral()
        {
            X[1] = 0;
            Y[1] = 0;
            X[2] = 0;
            Y[2] = 2;
            X[3] = 10;
            Y[3] = 2;
            X[4] = 10;
            Y[4] = 0;

        }

        public ConvexQuadrilateral(double x, double y)
        {
            X[1] = x;
            Y[1] = y;
            X[2] = x;
            Y[2] = y;
            X[3] = x;
            Y[3] = y;
            X[4] = x;
            Y[4] = y;
        }

        public virtual string ToSring() => "X1 = " + X[0] + "\tY1 = " + Y[0] + "\nX2 = " + X[1] + "\tY2 = " + Y[1] + "\nX3 = " + X[2] + "\tY3 = " + Y[2] + "\nX4 = " + X[3] + "\tY4 = " + Y[3] + calculation.Angles(calculation.Storona(X, Y), calculation.Diagonals(X, Y)) + calculation.Perimetr(calculation.Storona(X, Y));

        public void Print() => Console.WriteLine(ToSring());
    }
}
