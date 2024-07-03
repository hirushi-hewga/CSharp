using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_06_19___HW__StructRefOut_
{
    partial class Calculator
    {
        private float a;
        private float b;
        public Calculator(float a, float b)
        {
            A = a;
            B = b;
        }
    }
    partial class Calculator
    {
        public float A
        {
            get { return a; }
            set { a = value; }
        }
        public float B
        {
            get { return b; }
            set { b = value; }
        }
    }
}
