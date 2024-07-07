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
        private float side_c;
        public float Side_a
        {
            get { return side_a; }
            private set {
                if (value > 0)
                    side_a = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public float Side_b
        {
            get { return side_b; }
            private set {
                if (value > 0)
                    side_b = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public float Side_c
        {
            get { return side_c; }
            private set {
                if (value > 0)
                    side_c = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public Triangle() : this(1, 1, 1) { }
        public Triangle(float side_a, float side_b, float side_c)
        {
            Side_a = side_a;
            Side_b = side_b;
            Side_c = side_c;
        }
        public override float GetArea()
        {
            float s = (Side_a + Side_b + Side_c) / 2;
            float area = (float)Math.Sqrt(s * (s - Side_a) * (s - Side_b) * (s - Side_c));
            return area;
        }
        public override float GetPerimetr()
        {
            return Side_a + Side_b + Side_c;
        }
    }
    class Square : Shape
    {
        private float side;
        public float Side
        {
            get { return side; }
            private set
            {
                if (value > 0)
                    side = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public Square() : this(1) { }
        public Square(float side)
        {
            Side = side;
        }
        public override float GetArea()
        {
            return Side * Side;
        }
        public override float GetPerimetr()
        {
            return Side * 4;
        }
    }
    class Diamond : Shape
    {
        private float side;
        public float Side
        {
            get { return side; }
            private set
            {
                if (value > 0)
                    side = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public Diamond() : this(1) { }
        public Diamond(float side)
        {
            Side = side;
        }
        public override float GetArea()
        {
            return (Side * Side) / 2;
        }
        public override float GetPerimetr()
        {
            return Side * 4;
        }
    }
    class Rectangle : Shape
    {
        private float base_length;
        private float side_length;
        public float Base_length
        {
            get { return base_length; }
            private set
            {
                if (value > 0)
                    base_length = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public float Side_length
        {
            get { return side_length; }
            private set
            {
                if (value > 0)
                    side_length = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public Rectangle() : this(1, 1) { }
        public Rectangle(float base_length, float side_length)
        {
            Base_length = base_length;
            Side_length = side_length;
        }
        public override float GetArea()
        {
            return Base_length * Side_length;
        }
        public override float GetPerimetr()
        {
            return (Base_length + Side_length) * 2;
        }
    }
    class Parallelogram : Shape
    {
        private float base_length;
        private float side_length;
        private float height;
        public float Base_length
        {
            get { return base_length; }
            private set
            {
                if (value > 0)
                    base_length = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public float Side_length
        {
            get { return side_length; }
            private set
            {
                if (value > 0)
                    side_length = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public float Height
        {
            get { return height; }
            private set
            {
                if (value > 0)
                    height = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public Parallelogram() : this(1, 1, 1) { }
        public Parallelogram(float base_length, float side_length, float height)
        {
            Base_length = base_length;
            Side_length = side_length;
            Height = height;
        }
        public override float GetArea()
        {
            return Base_length * Height;
        }
        public override float GetPerimetr()
        {
            return (Base_length + Side_length) * 2;
        }
    }
    class Trapeze : Shape
    {
        private float base_length_1;
        private float base_length_2;
        private float side_length;
        private float height;
        public float Base_length_1
        {
            get { return base_length_1; }
            private set
            {
                if (value > 0)
                    base_length_1 = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public float Base_length_2
        {
            get { return base_length_2; }
            private set
            {
                if (value > 0)
                    base_length_2 = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public float Side_length
        {
            get { return side_length; }
            private set
            {
                if (value > 0)
                    side_length = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public float Height
        {
            get { return height; }
            private set
            {
                if (value > 0)
                    height = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public Trapeze() : this(1, 1, 1, 1) { }
        public Trapeze(float base_length_1, float base_length_2, float side_length, float height)
        {
            Base_length_1 = base_length_1;
            Base_length_2 = base_length_2;
            Side_length = side_length;
            Height = height;
        }
        public override float GetArea()
        {
            return (Base_length_1 + Base_length_2) / 2 * Height;
        }
        public override float GetPerimetr()
        {
            return (Side_length * 2) + Base_length_1 + Base_length_2;
        }
    }
    class Circle : Shape
    {
        private float radius;
        public float Radius
        {
            get { return radius; }
            private set
            {
                if (value > 0)
                    radius = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public Circle() : this(1) { }
        public Circle(float radius)
        {
            Radius = radius;
        }
        public override float GetArea()
        {
            return (float)(Math.PI * Radius * Radius);
        }
        public override float GetPerimetr()
        {
            return (float)(2 * Math.PI * Radius);
        }
    }
    class Ellipse : Shape
    {
        private float base_axis;
        private float additional_axis;
        public float Base_axis
        {
            get { return base_axis; }
            private set
            {
                if (value > 0)
                    base_axis = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public float Additional_axis
        {
            get { return additional_axis; }
            private set
            {
                if (value > 0)
                    additional_axis = value;
                else
                    throw new ArgumentException("Argument exception. Side cannot be equal or less than zero");
            }
        }
        public Ellipse() : this(1, 1) { }
        public Ellipse(float base_axis, float additional_axis)
        {
            Base_axis = base_axis;
            Additional_axis = additional_axis;
        }
        public override float GetArea()
        {
            return (float)(Math.PI * Base_axis * Additional_axis);
        }
        public override float GetPerimetr()
        {
            double h = Math.Pow((Base_axis - Additional_axis), 2) / Math.Pow((Base_axis + Additional_axis), 2);
            return (float)(Math.PI * (Base_axis + Additional_axis) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h))));
        }
    }
    class Composite_figure
    {
        private Shape[] shapes;
        public Composite_figure()
        {
            shapes = null;
        }
        public Composite_figure(int size)
        {
            shapes = new Shape[size];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}