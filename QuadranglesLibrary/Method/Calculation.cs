using System;

namespace QuadranglesLibrary.Method
{
    public class Calculation
    {
        public void Diagonals(double[] X, double[] Y)
        {
            double diag1 = Math.Sqrt(Math.Pow((X[3] - X[1]), 2) + Math.Pow((Y[3] - Y[1]), 2));
            double diag2 = Math.Sqrt(Math.Pow((X[4] - X[2]), 2) + Math.Pow((Y[4] - Y[2]), 2));
            Console.WriteLine("Diagonals = {0:f2}; {1:f2}", diag1, diag2);
        }

        //public void Perimetr(double[] x, double[] y)
        //{
        //    P = str[1] + str[2] + str[3] + str[4];
        //    Console.WriteLine("Perimetr = " + P);
        //}

        public void Storona(double[] x, double[] y)
        {
            double[] str = new double[5];
            x[5] = x[1]; y[5] = y[1];
            for(int i = 1; i<=4; i++)
            {
                str[i] = Math.Sqrt(Math.Pow((x[i + 1] - x[i]), 2) + Math.Pow((y[i + 1] - y[i]), 2));
                Console.WriteLine("Сторона {0} = {1}", i, str[i]);
            }
        }
    }
}

