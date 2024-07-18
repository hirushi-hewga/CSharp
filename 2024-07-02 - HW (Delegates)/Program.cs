using System.Runtime.InteropServices;
using static System.Console;
namespace _2024_07_02___HW__Delegates_
{
    class Array
    {
        public static int Negative(int v)
        {
            if (v < 0) return 1;
            return 0;
        }
        public static int Prime(int v)
        {
            if (v == 0 || v == 1) return 0;
            else {
                for (int i = 2; i <= v / 2; i++)
                    if (v % i == 0) return 0;
                return 1;
            }
        }
        public static int SortByOddEven(int x, int y)
        {
            if (x % 2 == 0 && y % 2 != 0)
                return -1;
            else if (x % 2 != 0 && y % 2 == 0)
                return 1;
            return x.CompareTo(y);
        }
        public static void NegativeToZero(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] < 0) arr[i] = 0;
        }
    }
    public delegate int CalculateDelegate(int value);
    public delegate void ChangeDelegate(int[] value);
    internal class Program
    {
        public static int CalculateValues(int[] arr, CalculateDelegate calculate)
        {
            int value = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                value += calculate.Invoke(arr[i]); 
            }
            return value;
        }
        public static void ChangeValues(int[] arr, ChangeDelegate calculate)
        {
            calculate.Invoke(arr);
        }
        public static void ChangeValues(int[] arr, Comparison<int> comparison)
        {
            System.Array.Sort(arr, comparison);
        }
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Write("{0} ", arr[i]);
            WriteLine("\n");
        }
        static void Main(string[] args)
        {
            CalculateDelegate[] calcDelegates = new CalculateDelegate[]
            {
                Array.Negative,
                v => v,
                Array.Prime
            };
            ChangeDelegate[] changeDelegates = new ChangeDelegate[]
            {
                Array.NegativeToZero,
                array => System.Array.Sort(array)
            };
                

            int[] arr = new int[8];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = new Random().Next(101) - 50;

            int choice = 0;
            bool isValidData = true;
            do
            {
                Clear();
                if (!isValidData) WriteLine("Invalid choice\n");
                else isValidData = false;
                Write("Array | "); PrintArray(arr);
                Write("1 - Calculate array\n2 - Change array\nEnter your choice : ");
                int.TryParse(ReadLine(), out choice);
            } while (choice < 1 || choice > 2);

            isValidData = true;
            if (choice == 1)
            {
                do
                {
                    Clear();
                    if (!isValidData) WriteLine("Invalid choice\n");
                    else isValidData = false;
                    Write("Array | "); PrintArray(arr);
                    Write("1 - Get count of negative numbers\n2 - Get suma of numbers\n" +
                        "3 - Get count of prime numbers\nEnter your choice : ");
                    int.TryParse(ReadLine(), out choice);
                } while (choice < 1 || choice > 3);
                WriteLine("\nRes : {0}", CalculateValues(arr, calcDelegates[choice - 1]));
            }
            else if (choice == 2)
            {
                do
                {
                    Clear();
                    if (!isValidData) WriteLine("Invalid choice\n");
                    else isValidData = false;
                    Write("Array | "); PrintArray(arr);
                    Write("1 - Change negative elements to zero\n2 - Sort\n" +
                        "3 - Sort by even and odd elements\nEnter your choice : ");
                    int.TryParse(ReadLine(), out choice);
                } while (choice < 1 || choice > 3);
                if (choice == 3)
                {
                    ChangeValues(arr, Array.SortByOddEven);
                    WriteLine($"\nRes : {arr}");
                }
                else
                {
                    ChangeValues(arr, changeDelegates[choice - 1]);
                    WriteLine($"\nRes : {arr}");
                }
            }

            //WriteLine($"Count of negative numbers : {CalculateValues(arr, Number.Negative)}");
            //WriteLine($"Suma of numbers : {CalculateValues(arr, v => v)}");
            //WriteLine($"Count of prime numbers : {CalculateValues(arr, Number.Prime)}");

            //ChangeValues(arr, array => { for (int i = 0; i < array.Length; i++) { if (array[i] < 0) array[i] = 0; } });
            //Write("Negative to zero | "); PrintArray(arr);

            //ChangeValues(arr, array => System.Array.Sort(array));
            //Write("Sorted | "); PrintArray(arr);

            //ChangeValues(arr, (x, y) => { if (x % 2 == 0 && y % 2 != 0) { return -1; } else if (x % 2 != 0 && y % 2 == 0) { return 1; } return x.CompareTo(y); });
            //Write("Sorting by even and odd elements | "); PrintArray(arr);
        }
    }
}
