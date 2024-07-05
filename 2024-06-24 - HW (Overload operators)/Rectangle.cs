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
            if (r.A == 0 || r.B == 0) throw new InvalidValueException("Value cannot be less than zero");
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
            if (r1.A < r2.A || r1.B < r2.B) throw new InvalidValueException("Left rectangle is smaller than right");
            return new Rectangle { A = r1.A - r2.A, B = r1.B - r2.B };
        }
        public static Rectangle operator *(Rectangle r1, Rectangle r2)
        {
            return new Rectangle { A = r1.A * r2.A, B = r1.B * r2.B };
        }
        public static Rectangle operator /(Rectangle r1, Rectangle r2)
        {
            if (r2.A == 0 || r2.B == 0) throw new InvalidValueException("You cannot divide by zero");
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
        public static bool operator true(Rectangle r)
        {
            return r.A != 0 && r.B != 0;
        }
        public static bool operator false(Rectangle r)
        {
            return r.A == 0 || r.B == 0;
        }
        public static explicit operator Square(Rectangle r)
        {
            return new Square((r.A + r.B)/2);
        }
        public static explicit operator int(Rectangle r)
        {
            return (int)(r.A + r.B) / 2;
        }
    }
}
