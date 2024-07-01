using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_06_17___HW__Intro_to_OOP_
{
    partial class Freezer
    {
        static Freezer()
        {
            min_t = 0;
            max_t = 0;
        }
        public Freezer()
        {
            model = null;
            color = null;
            Volume = 20;
        }
        public Freezer(string model)
        {
            Model = model;
            color = null;
        }
        public Freezer(string model, string color) : this(model)
        {
            Color = color;
        }
    }
    partial class Freezer
    {
        public string Model
        {
            get {
                if (model == null)
                    return "no model";
                return model;
            }
            private set { model = value; }
        }
        public string Color
        {
            get {
                if (color == null)
                    return "no model";
                return color;
            }
            set { color = value; }
        }
        public int Volume
        {
            get { return volume; }
            set
            {
                if (value > 0)
                    volume = value;
                else
                    volume = Math.Abs(value);
            }
        }
        public static int Min_t
        {
            get { return min_t; }
            set
            {
                if (value <= 0)
                    min_t = value;
                else
                    min_t = value * -1;
            }
        }
        public static int Max_t
        {
            get { return max_t; }
            set
            {
                if (value <= 0)
                    max_t = value;
                else
                    max_t = value * -1;
            }
        }
    }
    partial class Freezer
    {
        public override string ToString()
        {
            return $"Model : {Model} ,  Color : {Color} ,  Volume : {Volume} ,  Min temperature : {Min_t} ,  Max temperature : {Max_t}";
        }
        public string[] ToArray()
        {
            return new string[] { $"Model : {Model}", $"Color : {Color}", $"Volume : {Volume}", $"Min temperature : {Min_t}", $"Max temperature : {Max_t}" };
        }
        public void SetMinTemperature(int value) { Min_t = value; }
        public void GetMinTemperature(ref int var) { var = Min_t; }
        public int GetMinTemperature() { return min_t; }
        public void SetMaxTemperature(int value) { Max_t = value; }
        public void GetMaxTemperature(ref int var) { var = Max_t; }
        public int GetMaxTemperature() { return max_t; }
    }
}
