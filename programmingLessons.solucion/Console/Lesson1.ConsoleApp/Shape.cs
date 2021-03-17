namespace Lesson1.ConsoleApp
{
    public class Circle : Shape
    {
        public Circle() : base("Circle", 0)
        {
        }

        public int Radius { get; set; }

        public override decimal Area()
        {
            int result = 0;
            result = (Radius * Radius);
            return result;
        }
    }

    public class Shape
    {
        public Shape()
        {
        }

        public Shape(string name, int side)
        {
            Name = name;
            Side = side;
        }

        public string Name { get; set; }
        public int Side { get; set; }

        public virtual decimal Area()
        {
            return 0;
        }
    }

    public class Square : Shape
    {
        public Square() : base("Square", 4)
        {
        }

        public int Length { get; set; }

        public override decimal Area()
        {
            int result = 0;
            result = Length * Length;
            return result;
        }
    }

    public class Triangle : Shape
    {
        public Triangle() : base("Triangle", 3)
        {
        }

        public int Base { get; set; }
        public int Height { get; set; }

        public override decimal Area()
        {
            int result = 0;
            result = (Base * Height) / 2;
            return result;
        }
    }
}