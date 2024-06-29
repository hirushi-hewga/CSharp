using System.Drawing;
using System.Reflection;

namespace _2024_06_17___HW__Intro_to_OOP_
{
    partial class Freezer
    {
        private string model;
        private string color;
        private int volume;
        private int min_t;
        private int max_t;
        public override string ToString()
        {
            return $"Model : {Model} ,  Color : {Color} ,  Volume : {Volume} ,  Min temperature : {Min_t} ,  Max temperature : {Max_t}";
        }
    };
    class Program
    {
        static void Main(string[] args)
        {
            Freezer freezer = new Freezer("freezer", "Black");
            string string_freezer = freezer.ToString();
            Console.WriteLine(string_freezer);
        }
    }
}
