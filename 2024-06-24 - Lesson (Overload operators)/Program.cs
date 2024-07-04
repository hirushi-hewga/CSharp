using System.Globalization;
using static System.Console;
namespace _2024_06_24___Lesson__Overload_operators_
{
    class Point_3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point_3D() : this(0, 0, 0) { }
        public Point_3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"X : {X} ,  Y : {Y} ,  Z : {Z}";
        }
    }
        class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point() : this(0, 0) { }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"X : {X} ,  Y : {Y}";
        }
        public override bool Equals(object? obj)
        {
            return obj is Point point &&
                   X == point.X &&
                   Y == point.Y;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
        #region Унарні оператори

        // - ++ --

        public static Point operator -(Point p)
        {
            Point res = new Point
            {
                X = p.X * -1,
                Y = p.Y * -1
            };
            return res;
        }
        public static Point operator ++(Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }
        public static Point operator --(Point p)
        {
            p.X--;
            p.Y--;
            return p;
        }
        #endregion
        #region Бінарні оператори

        // + - * /

        public static Point operator +(Point p1, Point p2)
        {
            Point res = new Point()
            {
                X = p1.X + p2.X,
                Y = p1.Y + p2.Y
            };
            return res;
        }
        public static Point operator -(Point p1, Point p2)
        {
            Point res = new Point()
            {
                X = p1.X - p2.X,
                Y = p1.Y - p2.Y
            };
            return res;
        }
        public static Point operator *(Point p1, Point p2)
        {
            Point res = new Point()
            {
                X = p1.X * p2.X,
                Y = p1.Y * p2.Y
            };
            return res;
        }
        public static Point operator /(Point p1, Point p2)
        {
            Point res = new Point()
            {
                X = p1.X / p2.X,
                Y = p1.Y / p2.Y
            };
            return res;
        }
        #endregion
        #region оператори рівності

        // == !=

        public static bool operator ==(Point p1, Point p2)
        {
            //return p1.X == p2.X && p1.Y == p2.Y;
            return p1.Equals(p2);
        }
        public static bool operator !=(Point p1, Point p2)
        {
            //return p1.X != p2.X || p1.Y != p2.Y;
            return !(p1 == p2);
        }
        #endregion
        #region оператори порівняння

        // > < >= <=

        public static bool operator >(Point p1, Point p2)
        {
            return p1.X + p1.Y > p2.X + p2.Y;
        }
        public static bool operator <(Point p1, Point p2)
        {
            return !(p1 > p2 && p1 == p2);
        }
        public static bool operator >=(Point p1, Point p2)
        {
            return !(p1 < p2);
        }
        public static bool operator <=(Point p1, Point p2)
        {
            return !(p1 > p2);
        }
        #endregion
        #region true/false operators

        public static bool operator true(Point p)
        {
            return p.X >= 0 && p.Y >= 0;
        }
        public static bool operator false(Point p)
        {
            return p.X < 0 || p.Y < 0;
        }

        #endregion
        #region Оператори перетворення типів

        public static explicit operator int(Point p)
        {
            return p.X + p.Y;
        }
        public static implicit operator double(Point p)
        {
            return p.X + p.Y;
        }
        public static implicit operator Point_3D(Point p)
        {
            return new Point_3D(p.X, p.Y, 55);
        }

        #endregion
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Point point = new Point(2, 4);
            Point_3D _3D = point;
            WriteLine(point.ToString());
            WriteLine(_3D.ToString());
            */



            /*
            Point point = new Point(7, 8);
            int a = 5; // int ==> int
            double b = 3.14; // double ==> double

            b = a; // int ==> double implicit 5.0000000000
            a = (int)b; // double ==> int explicit 3

            a = (int)point; // Point ==> int explicit
            b = point; // Point ==> double implicit
            */



            /*
            Point p1 = new Point(12, 74);
            Point p2 = new Point(2, 4);
            if (p1 > p2)
                WriteLine("p1 > p2");
            else if (p1 < p2)
                WriteLine("p1 < p2");
            else
                WriteLine("Equals");

            if (p1) WriteLine("True");
            else WriteLine("False");
            */



            /*
            string str = "Hello";
            string str2 = str;
            if (str.Equals(str2))
                WriteLine("Equals");
            else
                WriteLine("not Equals");
            */



            /*
            Point p1 = new Point(8, 9);
            Point p2 = new Point(2, 4);
            WriteLine($"Point ++: {p1++}");
            WriteLine($"Point ++: {++p1}");
            WriteLine($"Point --: {p1--}");
            WriteLine($"Point --: {--p1}");

            Point res = -p1;
            WriteLine($"Res -: {res}");


            res = p1 + p2;
            WriteLine($"Res +: {res}");
            res = p1 - p2;
            WriteLine($"Res -: {res}");
            res = p1 * p2;
            WriteLine($"Res *: {res}");
            res = p1 / p2;
            WriteLine($"Res /: {res}");
            */
        }
    }
}
