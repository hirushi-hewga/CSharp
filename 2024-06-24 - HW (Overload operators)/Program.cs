using System.Security.AccessControl;
using static System.Console;
namespace _2024_06_24___HW__Overload_operators_
{
    partial class Square
    {
        public int A { get; set; }
        public Square() : this(1) { }
        public Square(int a)
        {
            A = a;
        }
    }
    partial class Rectangle
    {
        public int A { get; set; }
        public int B { get; set; }
        public Rectangle() : this(1, 1) { }
        public Rectangle(int a, int b)
        {
            A = a;
            B = b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
