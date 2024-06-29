namespace _2024_06_17___HW__Intro_to_OOP_
{
    internal class Freezer
    {
        private string model;
        private string color;
        private float volume;
        private int min_t;
        private int max_t;
        public Freezer()
        {
            model = "no model";
            color = "no color";
            volume = 10;
            min_t = -30;
            max_t = -8;
        }
        public Freezer(string model) : base()
        {
            Model = model;
        }
        public Freezer(string model, string color) : base()
        {
            Model = model;
            Color = color;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
