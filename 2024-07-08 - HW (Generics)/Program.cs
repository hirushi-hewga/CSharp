namespace _2024_07_08___HW__Generics_
{
    static class MyClass
    {
        public static T GetMax<T>(T num1, T num2, T num3) where T : IComparable
        {
            T max = num1.CompareTo(num2) > 0 ? num1 : num2;
            return max.CompareTo(num3) > 0 ? max : num3;
        }
        public static T GetMin<T>(T num1, T num2, T num3) where T : IComparable
        {
            T min = num1.CompareTo(num2) < 0 ? num1 : num2;
            return min.CompareTo(num3) < 0 ? min : num3;
        }
        public static T GetSumma<T>(T[] arr) where T : struct
        {
            dynamic sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }
    }
    class Stack
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1

            /*
            Console.WriteLine($"Max : {MyClass.GetMax(21, 54, 13)}");
            */

            #endregion

            #region 2

            /*
            Console.WriteLine($"Min : {MyClass.GetMin(27.4f, 52.7f, 16.1f)}");
            */

            #endregion

            #region 3

            /*
            Console.WriteLine($"Summa : {MyClass.GetSumma(new int[] { 1, 5, 2, 4, 2, 9, 4, 7 })}");
            */

            #endregion

            #region 4

            



            #endregion
        }
    }
}
