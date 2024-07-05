using System;
using System.Collections.Generic;
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
            s.A--;
            return s;
        }
        public static Square operator +(Square s1, Square s2)
        {
            return new Square { A = s1.A + s2.A };
        }
        public static Square operator -(Square s1, Square s2)
        {
            return new Square { A = s1.A - s2.A };
        }
        public static Square operator *(Square s1, Square s2)
        {
            return new Square { A = s1.A * s2.A };
        }
        public static Square operator /(Square s1, Square s2)
        {
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
    }
}
