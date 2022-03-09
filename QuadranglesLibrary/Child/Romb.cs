using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadranglesLibrary.Child
{
    public class Romb : ConvexQuadrilateral
    {
        public Romb() : base()
        {
            X[1] = 1;
            Y[1] = 6;
            X[2] = 4;
            Y[2] = 10;
            X[3] = 7;
            Y[3] = 6;
            X[4] = 4;
            Y[4] = 2;
        }

        public Romb(double x, double y) : base()
        {
            
        }

        public override string ToSring()
        {
            return "Ромб:\n" + base.ToSring();
        }
    }
}
