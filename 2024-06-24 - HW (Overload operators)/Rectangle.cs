using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_06_24___HW__Overload_operators_
{
    partial class Rectangle
    {
        public override string ToString()
        {
            return $"A : {A} ,  B : {B}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Rectangle rectangle &&
                   A == rectangle.A &&
                   B == rectangle.B;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(A, B);
        }

        public static Rectangle operator ++(Rectangle r)
        {
            r.A++;
            r.B++;
            return r;
        }
        public static Rectangle operator --(Rectangle r)
        {
            r.A--;
            r.B--;
            return r;
        }
        public static Rectangle operator +(Rectangle r1, Rectangle r2)
        {
            return new Rectangle { A = r1.A + r2.A, B = r1.B + r2.B };
        }
        public static Rectangle operator -(Rectangle r1, Rectangle r2)
        {
            return new Rectangle { A = r1.A - r2.A, B = r1.B - r2.B };
        }
        public static Rectangle operator *(Rectangle r1, Rectangle r2)
        {
            return new Rectangle { A = r1.A * r2.A, B = r1.B * r2.B };
        }
        public static Rectangle operator /(Rectangle r1, Rectangle r2)
        {
            return new Rectangle { A = r1.A / r2.A, B = r1.B / r2.B };
        }
        public static bool operator <(Rectangle r1, Rectangle r2)
        {
            return r1.A + r1.B < r2.A + r2.B;
        }
        public static bool operator >(Rectangle r1, Rectangle r2)
        {
            return r1.A + r1.B > r2.A + r2.B;
        }
        public static bool operator <=(Rectangle r1, Rectangle r2)
        {
            return !(r1 > r2);
        }
        public static bool operator >=(Rectangle r1, Rectangle r2)
        {
            return !(r1 < r2);
        }
        public static bool operator ==(Rectangle r1, Rectangle r2)
        {
            return r1.Equals(r2);
        }
        public static bool operator !=(Rectangle r1, Rectangle r2)
        {
            return !(r1 == r2);
        }
    }
}
