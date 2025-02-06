using System;

namespace training_pattern_prototip
{
    public abstract class Shape
    {
        protected int x, y;
        protected string color;

        public override string ToString()
        {
            return $"Shape at ({x}, {y}) with color {color}";
        }

        public abstract Shape Clone();
        public Shape(int x, int y, string color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }

    }


    public class Circle : Shape
    {
        private int radius;

        public Circle(int x, int y, string color, int radius)
            : base(x, y, color)
        {
            this.radius = radius;
        }

        public override Shape Clone()
        {
            return new Circle(x, y, color, radius);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Radius: {radius}";
        }
    }

    public class Sphere : Shape
    {
        private int radius;

        public Sphere(int x, int y, string color, int radius)
            : base(x, y, color)
        {
            this.radius = radius;
        }

        public override Shape Clone()
        {
            return new Sphere(x, y, color, radius);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Radius: {radius}";
        }
    }
    public class Rectangle : Shape
    {
        private int width, height;

        public Rectangle(int x, int y, string color, int width, int height)
            : base(x, y, color)
        {
            this.width = width;
            this.height = height;
        }

        public override Shape Clone()
        {
            return new Rectangle(x, y, color, width, height);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Width: {width}, Height: {height}";
        }
    }
    public class Cube : Shape
    {
        private int side;

        public Cube(int x, int y, string color, int side)
            : base(x, y, color)
        {
            this.side = side;
        }

        public override Shape Clone()
        {
            return new Cube(x, y, color, side);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Side: {side}";
        }
    }

    public class Application
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle(15, 25, "Blue", 20);
            Circle circleClone = (Circle)circle.Clone();
            Console.WriteLine(circle);
            Console.WriteLine(circleClone);

            Sphere sphere = new Sphere(20, 30, "Yellow", 15);
            Sphere sphereClone = (Sphere)sphere.Clone();
            Console.WriteLine(sphere);
            Console.WriteLine(sphereClone);

            Rectangle rect = new Rectangle(10, 20, "Red", 50, 30);
            Rectangle rectClone = (Rectangle)rect.Clone();
            Console.WriteLine(rect);
            Console.WriteLine(rectClone);

            Cube cube = new Cube(5, 10, "Green", 40);
            Cube cubeClone = (Cube)cube.Clone();
            Console.WriteLine(cube);
            Console.WriteLine(cubeClone);
        }
    }
}
