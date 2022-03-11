using System;

namespace QuadranglesLibrary.Method
{
    public class Calculation
    {
        public double[] Diagonals(double[] X, double[] Y)
        {
            double[] diag = new double[3];
            diag[1] = Math.Sqrt(Math.Pow((X[3] - X[1]), 2) + Math.Pow((Y[3] - Y[1]), 2));
            diag[2] = Math.Sqrt(Math.Pow((X[4] - X[2]), 2) + Math.Pow((Y[4] - Y[2]), 2));
            Console.WriteLine($"Диагональ 1 = {diag[1]} Диагональ 2 = {diag[2]}");
            return diag;
        }

        public double Perimetr(double[] Storona)
        {
            double p = Storona[1] + Storona[2] + Storona[3] + Storona[4];
            Console.WriteLine("Периметр = " + p);
            return p;
        }

        public double[] Storona(double[] x, double[] y)
        {
            double[] storona = new double[5];
            x[5] = x[1]; y[5] = y[1];
            for (int i = 1; i <= 4; i++)
            { 
                storona[i] = Math.Sqrt(Math.Pow((x[i + 1] - x[i]), 2) + Math.Pow((y[i + 1] - y[i]), 2));
                Console.WriteLine("Сторона {0} = {1}", i, storona[i]);
            }
            return storona;
        }

        public double[] Angles(double[] Storona, double[] Diag)
        {
            double[] angle = new double[5];
            angle[1] = angle[3] = Math.Acos((Math.Pow(Storona[1], 2) + Math.Pow(Storona[4], 2) - Math.Pow(Diag[2], 2)) / (2 * Storona[1] * Storona[4])) * 180 / Math.PI;
            angle[2] = angle[4] = Math.Acos((Math.Pow(Storona[1], 2) + Math.Pow(Storona[2], 2) - Math.Pow(Diag[1], 2)) / (2 * Storona[1] * Storona[2])) * 180 / Math.PI;
            for(int i = 1; i<5; i++)
            {
                Console.WriteLine($"Угол {i} = {angle[i]}");
            }
            return angle;
        }
    }
}

