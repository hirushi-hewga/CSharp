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
        public override float GetArea()
        {
            throw new NotImplementedException();
        }
        public override float GetPerimetr()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
