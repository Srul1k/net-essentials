namespace ShapeLibrary
{
    public abstract class Shape
    {
        public string Name { get; }

        public Shape(string name) => Name = name;

        public abstract double GetArea();
    }
}
