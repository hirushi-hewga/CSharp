using static System.Console;
namespace _2024_07_02___HW__Delegates_
{
    class Number
    {
        public static bool IsNegative(int v)
        {
            if (v < 0) return true;
            return false;
        }
    }
    public delegate bool CalculationDelegate(int value);
    internal class Program
    {
        public static void CalculationNumbers(int[] arr, CalculationDelegate calculate)
        {
            for (int i = 0; i < arr.Length; i++)
            {

            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
