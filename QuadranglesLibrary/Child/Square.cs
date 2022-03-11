namespace QuadranglesLibrary.Child
{
    public class Square : ConvexQuadrilateral
    {
        public Square() : base()
        {
            X[1] = 2;
            Y[1] = 2;
            X[2] = 2;
            Y[2] = 5;
            X[3] = 5;
            Y[3] = 5;
            X[4] = 5;
            Y[4] = 2;
        }

        public Square(double x, double y) : base()
        {
            
        }

        public override string ToSring()
        {
            return base.ToSring();
        }
    }
}
