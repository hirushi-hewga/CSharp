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
    };
    class Program
    {
        static void Main(string[] args)
        {
            Freezer freezer = new Freezer("freezer", "Black");

            string string_freezer = freezer.ToString();
            Console.WriteLine(string_freezer);

            freezer.SetMinTemperature(-30);
            freezer.SetMaxTemperature(-10);
            freezer.Volume = 27;

            string_freezer = freezer.ToString();
            Console.WriteLine(string_freezer);



            int min_t = 0, max_t = 0;
            freezer.GetMinTemperature(ref min_t);
            freezer.GetMaxTemperature(ref max_t);
            Console.WriteLine("Min : {0} ,  Max : {1}", min_t, max_t);
            freezer.SetMinTemperature(-35);
            freezer.SetMaxTemperature(-15);
            min_t = freezer.GetMinTemperature();
            max_t = freezer.GetMaxTemperature();
            Console.WriteLine("Min : {0} ,  Max : {1}", min_t, max_t);



            string[] arr = freezer.ToArray();

            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
