using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_06_24___HW__Overload_operators_
{
    partial class Square
    {
        public override string ToString()
        {
            return $"A : {A}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Square square &&
                   A == square.A;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(A);
        }

        public static Square operator ++(Square s)
        {
            s.A++;
            return s;
        }
        public static Square operator --(Square s)
        {
            if (s.A == 0) throw new InvalidValueException("Value cannot be less than zero");
            s.A--;
            return s;
        }
        public static Square operator +(Square s1, Square s2)
        {
            return new Square { A = s1.A + s2.A };
        }
        public static Square operator -(Square s1, Square s2)
        {
            if (s1.A < s2.A) throw new InvalidValueException("Left square is smaller than right");
            return new Square { A = s1.A - s2.A };
        }
        public static Square operator *(Square s1, Square s2)
        {
            return new Square { A = s1.A * s2.A };
        }
        public static Square operator /(Square s1, Square s2)
        {
            if (s2.A == 0) throw new InvalidValueException("You cannot divide by zero");
            return new Square { A = s1.A / s2.A };
        }
        public static bool operator <(Square s1, Square s2)
        {
            return s1.A < s2.A;
        }
        public static bool operator >(Square s1, Square s2)
        {
            return s1.A > s2.A;
        }
        public static bool operator <=(Square s1, Square s2)
        {
            return !(s1 > s2);
        }
        public static bool operator >=(Square s1, Square s2)
        {
            return !(s1 < s2);
        }
        public static bool operator ==(Square s1, Square s2)
        {
            return s1.Equals(s2);
        }
        public static bool operator !=(Square s1, Square s2)
        {
            return !(s1 == s2);
        }
        public static bool operator true(Square s)
        {
            return s.A != 0;
        }
        public static bool operator false(Square s)
        {
            return s.A == 0;
        }
        public static implicit operator Rectangle(Square s)
        {
            return new Rectangle(s.A, s.A);
        }
        public static implicit operator int(Square s)
        {
            return (int)s.A;
        }
    }
}
