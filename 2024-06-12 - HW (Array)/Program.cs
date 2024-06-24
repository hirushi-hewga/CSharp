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

            /*
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
            Console.WriteLine("\n\nB :");
            for (int i = 0; i <= B.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= B.GetUpperBound(1); j++)
                {
                    Console.Write($"{B[i, j]} ");
                }
                Console.WriteLine();
            }
            double total_max_elem = A[0];
            double total_min_elem = A[0];
            double total_suma = 0;
            double total_dobutok = 1;
            int suma_even_elem_A = 0;
            double suma_odd_cols_B = 0;
            for (int i = 0; i <= A.GetUpperBound(0); i++)
            {
                if (A[i] > total_max_elem) total_max_elem = A[i];
                if (A[i] < total_min_elem) total_min_elem = A[i];
                total_suma += A[i];
                total_dobutok *= A[i];
                if (A[i] % 2 == 0) suma_even_elem_A += A[i];
            }
            for (int i = 0; i <= B.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= B.GetUpperBound(1); j++)
                {
                    if (B[i, j] > total_max_elem) total_max_elem = B[i, j];
                    if (B[i, j] < total_min_elem) total_min_elem = B[i, j];
                    total_suma += B[i, j];
                    total_dobutok *= B[i, j];
                    if (j % 2 != 0) suma_odd_cols_B += B[i, j];
                }
            }
            Console.WriteLine($"\nTotal max element : {total_max_elem}");
            Console.WriteLine($"\nTotal min element : {total_min_elem}");
            Console.WriteLine($"\nTotal suma : {Math.Round(total_suma, 2)}");
            Console.WriteLine($"\nTotal dobutok : {total_dobutok}");
            Console.WriteLine($"\nTotal suma the even elements of array A : {suma_even_elem_A}");
            Console.WriteLine($"\nTotal suma the odd elements of array B : {suma_odd_cols_B}");
            */

            #endregion

            #region 4

            int[,] arr = new int[5, 5];
            Random random = new Random();
            int min_i = 0, min_j = 0, max_i = 0, max_j = 0;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    arr[i, j] = random.Next(201) - 100;
                    Console.Write($" {arr[i, j]}  ");
                    if (arr[min_i, min_j] > arr[i, j]) 
                    {
                        min_i = i;
                        min_j = j;
                    }
                    if (arr[max_i, max_j] < arr[i, j])
                    {
                        max_i = i;
                        max_j = j;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\n Min element : {arr[min_i, min_j]}");
            Console.WriteLine($" Max element : {arr[max_i, max_j]}");
            int suma = 0;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    if ((min_i < max_i) || (min_i == max_i && min_j < max_j))
                    {
                        if ((i >= min_i && i <= max_i) && ((i == min_i && j > min_j) || (i == max_i && j < max_j) || (i != min_i && i != max_i)))
                            suma += arr[i, j];
                    }
                    else
                    {
                        if ((i >= max_i && i <= min_i) && ((i == max_i && j > max_j) || (i == min_i && j < min_j) || (i != max_i && i != min_i)))
                            suma += arr[i, j];
                    }
                }
            }
            Console.WriteLine($" Suma : {suma}");

            #endregion
        }
    }
}
