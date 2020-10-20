namespace ShapeLibrary
{
    public class Triangle : Shape
    {
        private double A { get; }
        private double H { get; }

        public Triangle(double a, double b) : base("Triangle")
        {
            A = a;
            H = b;
        }

        public override double GetArea()
        {
            return 0.5 * A * H;
        }
    }
}
