using System.Drawing;
using System.Reflection;

namespace _2024_06_17___HW__Intro_to_OOP_
{
    class Freezer
    {
        private string model;
        private string color;
        private int volume;
        private int min_t;
        private int max_t;

        public Freezer()
        {
            model = "no model";
            color = "no color";
            Volume = 20;
            Min_t = 0;
            Max_t = 0;
        }
        public Freezer(string model) : base()
        {
            this.model = model;
        }
        public Freezer(string model, string color) : this(model)
        {
            this.color = color;
        }

        public string Model { get; }
        public string Color { get; set; }
        public int Volume
        {
            get { return volume; }
            set
            {
                if (value > 0)
                    volume = value;
            }
        }
        public int Min_t
        {
            get { return min_t; }
            set
            {
                if (value <= 0)
                    min_t = value;
            }
        }
        public int Max_t
        {
            get { return max_t; }
            set
            {
                if (value <= 0)
                    max_t = value;
            }
        }

        public override string ToString()
        {
            return $"Model : {model}, Color : {color}, Volume : {volume}, Min temperature : {min_t}, Max temperature : {max_t}";
        }
    };
    class Program
    {
        static void Main(string[] args)
        {
            Freezer freezer = new Freezer("freezer", "black");
            string string_freezer = freezer.ToString();
            Console.WriteLine(string_freezer);
        }
    }
}
