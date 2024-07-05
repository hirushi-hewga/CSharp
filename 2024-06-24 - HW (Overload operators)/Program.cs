using System.Drawing;
using System.Security.AccessControl;
using static System.Console;
namespace _2024_06_24___HW__Overload_operators_
{
    class InvalidValueException : Exception
    {
        public InvalidValueException(string message) : base("Invalid value exception. " + message) { }
    }
    partial class Square
    {
        public uint A { get; set; }
        public Square() : this(0) { }
        public Square(uint a)
        {
            A = a;
        }
    }
    partial class Rectangle
    {
        public uint A { get; set; }
        public uint B { get; set; }
        public Rectangle() : this(0, 0) { }
        public Rectangle(uint a, uint b)
        {
            A = a;
            B = b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Square s1 = new Square(12);
            Square s2 = new Square(7);
            try
            {
                WriteLine(s1.ToString());
                s1--;
                WriteLine("-- : " + s1.ToString());
                s1++;
                WriteLine("++ : " + s1.ToString());
                WriteLine("s1 + s2 : " + (s1 + s2).ToString());
                WriteLine("s1 - s2 : " + (s1 - s2).ToString());
                WriteLine("s1 * s2 : " + (s1 * s2).ToString());
                WriteLine("s1 / s2 : " + (s1 / s2).ToString());
            }
            catch (InvalidValueException ex)
            {
                WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                WriteLine("Unknown exception");
            }
            if (s1 < s2)
                WriteLine("s1 < s2");
            else
                WriteLine("not s1 < s2");
            if (s1 > s2)
                WriteLine("s1 > s2");
            else
                WriteLine("not s1 > s2");
            if (s1 <= s2)
                WriteLine("s1 <= s2");
            else
                WriteLine("not s1 <= s2");
            if (s1 >= s2)
                WriteLine("s1 >= s2");
            else
                WriteLine("not s1 >= s2");
            if (s1 == s2)
                WriteLine("s1 == s2");
            else
                WriteLine("not s1 == s2");
            if (s1 != s2)
                WriteLine("s1 != s2");
            else
                WriteLine("not s1 != s2");
            if (s1)
                WriteLine("s1 : true");
            else
                WriteLine("s1 : false");
            Rectangle r = s1;
            Square s = (Square)r;
            int int_r = (int)r;
            int int_s = s;
            WriteLine("Rectangle r = {0}", r.ToString());
            WriteLine("Square s = {0}", s.ToString());
            WriteLine("r to int = {0}", int_r);
            WriteLine("s to int = {0}", int_s);
        }
    }
}
