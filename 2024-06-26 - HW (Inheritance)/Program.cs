using System.Reflection.Metadata;
using System.Security.AccessControl;
using static System.Console;
namespace _2024_06_26___HW__Inheritance_
{
    abstract class Shape
    {
        public abstract float GetArea();
        public abstract float GetPerimetr();
    }
    class Triangle : Shape
    {
        private float side_a;
        private float side_b;
        public float Side_a
        {
            get { return side_a; }
            set {
                if (value > 0)
                    side_a = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public float Side_b
        {
            get { return side_b; }
            set {
                if (value > 0)
                    side_b = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public Triangle() : this(1, 1) { }
        public Triangle(float side_a, float side_b)
        {
            Side_a = side_a;
            Side_b = side_b;
        }
        public override float GetArea()
        {
            return 1;
        }
        public override float GetPerimetr()
        {
            return 1;
        }
    }
    class Square : Shape
    {
        private float side_a;
        private float side_b;
        public float Side_a
        {
            get { return side_a; }
            set
            {
                if (value > 0)
                    side_a = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public float Side_b
        {
            get { return side_b; }
            set
            {
                if (value > 0)
                    side_b = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public Square() : this(1, 1) { }
        public Square(float side_a, float side_b)
        {
            Side_a = side_a;
            Side_b = side_b;
        }
        public override float GetArea()
        {
            return 1;
        }
        public override float GetPerimetr()
        {
            return 1;
        }
    }
    class Diamond : Shape
    {
        private float side_a;
        private float side_b;
        public float Side_a
        {
            get { return side_a; }
            set
            {
                if (value > 0)
                    side_a = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public float Side_b
        {
            get { return side_b; }
            set
            {
                if (value > 0)
                    side_b = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public Diamond() : this(1, 1) { }
        public Diamond(float side_a, float side_b)
        {
            Side_a = side_a;
            Side_b = side_b;
        }
        public override float GetArea()
        {
            return 1;
        }
        public override float GetPerimetr()
        {
            return 1;
        }
    }
    class Rectangle : Shape
    {
        private float side_a;
        private float side_b;
        public float Side_a
        {
            get { return side_a; }
            set
            {
                if (value > 0)
                    side_a = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public float Side_b
        {
            get { return side_b; }
            set
            {
                if (value > 0)
                    side_b = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public Rectangle() : this(1, 1) { }
        public Rectangle(float side_a, float side_b)
        {
            Side_a = side_a;
            Side_b = side_b;
        }
        public override float GetArea()
        {
            return 1;
        }
        public override float GetPerimetr()
        {
            return 1;
        }
    }
    class Parallelogram : Shape
    {
        private float side_a;
        private float side_b;
        public float Side_a
        {
            get { return side_a; }
            set
            {
                if (value > 0)
                    side_a = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public float Side_b
        {
            get { return side_b; }
            set
            {
                if (value > 0)
                    side_b = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public Parallelogram() : this(1, 1) { }
        public Parallelogram(float side_a, float side_b)
        {
            Side_a = side_a;
            Side_b = side_b;
        }
        public override float GetArea()
        {
            return 1;
        }
        public override float GetPerimetr()
        {
            return 1;
        }
    }
    class Trapeze : Shape
    {
        private float side_a;
        private float side_b;
        public float Side_a
        {
            get { return side_a; }
            set
            {
                if (value > 0)
                    side_a = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public float Side_b
        {
            get { return side_b; }
            set
            {
                if (value > 0)
                    side_b = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public Trapeze() : this(1, 1) { }
        public Trapeze(float side_a, float side_b)
        {
            Side_a = side_a;
            Side_b = side_b;
        }
        public override float GetArea()
        {
            return 1;
        }
        public override float GetPerimetr()
        {
            return 1;
        }
    }
    class Circle : Shape
    {
        private float side_a;
        private float side_b;
        public float Side_a
        {
            get { return side_a; }
            set
            {
                if (value > 0)
                    side_a = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public float Side_b
        {
            get { return side_b; }
            set
            {
                if (value > 0)
                    side_b = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public Circle() : this(1, 1) { }
        public Circle(float side_a, float side_b)
        {
            Side_a = side_a;
            Side_b = side_b;
        }
        public override float GetArea()
        {
            return 1;
        }
        public override float GetPerimetr()
        {
            return 1;
        }
    }
    class Ellipse : Shape
    {
        private float side_a;
        private float side_b;
        public float Side_a
        {
            get { return side_a; }
            set
            {
                if (value > 0)
                    side_a = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public float Side_b
        {
            get { return side_b; }
            set
            {
                if (value > 0)
                    side_b = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public Ellipse() : this(1, 1) { }
        public Ellipse(float side_a, float side_b)
        {
            Side_a = side_a;
            Side_b = side_b;
        }
        public override float GetArea()
        {
            return 1;
        }
        public override float GetPerimetr()
        {
            return 1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}