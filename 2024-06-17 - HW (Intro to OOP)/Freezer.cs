using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_06_17___HW__Intro_to_OOP_
{
    internal class Freezer
    {
        public string Model { get; }
        public string Color { get; set; }
        public float Volume {
            get { return volume; }
            set {
                if (value > 0)
                    volume = value;
            }
        }
        public int Min_t {
            get { return min_t; }
            set{
                if (value <= 0)
                    min_t = value;
            }
        }
        public int Max_t {
            get { return max_t; }
            set{
                if (value <= 0)
                    max_t = value;
            }
        }
    }
}
