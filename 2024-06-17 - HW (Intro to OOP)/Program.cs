using System.Drawing;
using System.Dynamic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace _2024_06_17___HW__Intro_to_OOP_
{
    partial class Freezer
    {
        private string model;
        private string color;
        private int volume;
        private static int min_t;
        private static int max_t;
        public override string ToString()
        {
            return $"Model : {Model} ,  Color : {Color} ,  Volume : {Volume} ,  Min temperature : {Min_t} ,  Max temperature : {Max_t}";
        }
        public void SetMinTemperature(int value) { Min_t = value; }
        public void GetMinTemperature(ref int var) { var = Min_t; }
        public void SetMaxTemperature(int value) { Max_t = value; }
        public void GetMaxTemperature(ref int var) { var = Max_t; }
    };
    class Program
    {
        static void Main(string[] args)
        {
            Freezer freezer = new Freezer("freezer", "Black");
            
            //string string_freezer = freezer.ToString();
            //Console.WriteLine(string_freezer);

            // Ще не доробив //




        }
    }
}
