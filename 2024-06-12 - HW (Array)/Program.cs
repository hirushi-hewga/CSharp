using System.Security.Cryptography;

namespace _2024_06_12___HW__Array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1

            /*
            int size;
            Console.Write("Enter arr size : ");
            size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Random random = new Random();
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                arr[i] = random.Next(20);
            }
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.Write("\n\nParni : ");
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                if (arr[i] % 2 == 0) Console.Write($"{arr[i]} ");
            }
            Console.Write("\nNe parni : ");
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                if (arr[i] % 2 != 0) Console.Write($"{arr[i]} ");
            }
            Console.Write("\nUnikalni : ");
            bool isUnique;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                isUnique = true;
                for (int j = 0; j <= arr.GetUpperBound(0); j++)
                {
                    if (arr[i] == arr[j] && i != j) isUnique = false;
                }
                if (isUnique == true) Console.Write($"{arr[i]} ");
            }
            */

            #endregion

            #region 2

            /*
            int[] arr = new int[15];
            Random random = new Random();
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                arr[i] = random.Next(99) + 1;
            }
            for (int i = 0; i < arr.GetUpperBound(0); i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.Write("\n\nEnter number : ");
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            Console.Write("\nCount : ");
            for (int i = 0; i < arr.GetUpperBound(0); i++)
            {
                if (number > arr[i]) count++;
            }
            Console.WriteLine(count);
            */

            #endregion

            #region 3

            int[] A = new int[5];
            double[,] B = new double[3, 4];
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"Enter the {i + 1} element of array A : ");
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nA : ");
            for (int i = 0; i <= A.GetUpperBound(0); i++)
            {
                Console.Write($"{A[i]} ");
            }
            Random random = new Random();
            for (int i = 0; i <= B.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= B.GetUpperBound(1); j++)
                {
                    B[i, j] = Math.Round(random.Next(90) + 10 + random.NextDouble(), 2);
                }
            }
            Console.Write("\n\nB : \n|");
            for (int i = 0; i <= B.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= B.GetUpperBound(1); j++)
                {
                    Console.Write($" {B[i, j]} |");
                }
                if (i < B.GetUpperBound(0)) Console.Write("\n---------------------------------\n|");
            }

            #endregion
        }
    }
}
