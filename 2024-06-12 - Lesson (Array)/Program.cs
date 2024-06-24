namespace _2024_06_12___Lesson__Array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region one_dimension_arr

            /* 1
            
            // int == Array
            // int arr[6] = { 1, 2, 5, 8, 9, 6 }; 
            int[] arr = new int[5];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;
            arr[4] = 50;

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);
            Console.WriteLine(arr[3]);
            Console.WriteLine(arr[4]);

            */



            /* 2
            
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 2;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            */



            /* 3

            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            */



            /* 4

            int[] arr = new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            */



            /* 5

            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            */



            /* 6

            int[] arr = new int[10];

            arr.SetValue(77, 2);
            arr.SetValue(22, 3);

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            */

            #endregion

            #region two_dimension_arr

            /* 1

            int[,] arr = new int[3, 3];
            arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[0, 2] = 3;
            
            arr[1, 0] = 4;
            arr[1, 1] = 5;
            arr[1, 2] = 6;

            arr[2, 0] = 7;
            arr[2, 1] = 8;
            arr[2, 2] = 9;

            Console.Write(arr[0, 0] + " ");
            Console.Write(arr[0, 1] + " ");
            Console.Write(arr[0, 2] + " ");
            Console.WriteLine();
            Console.Write(arr[1, 0] + " ");
            Console.Write(arr[1, 1] + " ");
            Console.Write(arr[1, 2] + " ");
            Console.WriteLine();
            Console.Write(arr[2, 0] + " ");
            Console.Write(arr[2, 1] + " ");
            Console.Write(arr[2, 2] + " ");
            Console.WriteLine();

            */



            /* 2

            int[,] arr = new int[3, 5];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = i * j + 1;
                }
            }
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            */



            /* 3

            int[,] arr =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            Console.WriteLine(arr.Length);
            Console.WriteLine(arr);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
            }

            */

            #endregion

            #region three_dimension_arr

            /* 1

            int[,,] arr = new int[3, 3, 3];

            arr[0, 0, 0] = 1;
            arr[0, 0, 1] = 2;
            arr[0, 0, 2] = 3;
            arr[0, 1, 0] = 4;
            arr[0, 1, 1] = 5;
            arr[0, 1, 2] = 6;
            arr[0, 2, 0] = 7;
            arr[0, 2, 1] = 8;
            arr[0, 2, 2] = 9;

            arr[1, 0, 0] = 1;
            arr[1, 0, 1] = 2;
            arr[1, 0, 2] = 3;
            arr[1, 1, 0] = 4;
            arr[1, 1, 1] = 5;
            arr[1, 1, 2] = 6;
            arr[1, 2, 0] = 7;
            arr[1, 2, 1] = 8;
            arr[1, 2, 2] = 9;

            arr[2, 0, 0] = 1;
            arr[2, 0, 1] = 2;
            arr[2, 0, 2] = 3;
            arr[2, 1, 0] = 4;
            arr[2, 1, 1] = 5;
            arr[2, 1, 2] = 6;
            arr[2, 2, 0] = 7;
            arr[2, 2, 1] = 8;
            arr[2, 2, 2] = 9;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("{0} ", arr[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            */



            /* 2

            int[,,] arr =
            {
                { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }
            };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write("{0} ", arr[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            */

            #endregion

            #region fourth_dimension_arr
            ////////
            #endregion

            #region jagged_arr

            /*

            int[][] jagged = new int[3][];

            jagged[0] = new int[] { 1, 2 };
            jagged[1] = new int[] { 1, 2, 3, 4, 5 };
            jagged[2] = new int[] { 1, 2, 3 };

            // Console.WriteLine(jagged.Length);

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write($" {jagged[i][j]}  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ReadKey();

            foreach (int[] item in jagged)
            {
                foreach (int i in item)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine();
            }

            */

            #endregion

            #region array_methods

            /*

            Console.OutputEncoding = Encoding.UTF8;
            int[] myArr1 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            PrintArr("Масив myArr1", myArr1);
            int[] tempArr = (int[])myArr1.Clone(); // shallow copy
            PrintArr("Clone", tempArr);

            //_ = myArr1.Reverse();// cw        
            Array.Reverse(myArr1, 5, 3);
            PrintArr("Масив myArr1 післе реверсу", myArr1);
            myArr1 = tempArr;
            PrintArr("Масив myArr1 післе відновлення", myArr1);
            int[] myArr2 = new int[20];
            PrintArr("Масив myArr2 до копіювання", myArr2);
            myArr1.CopyTo(myArr2, 10);
            PrintArr("Масив myArr2 післе копіювання", myArr2);
            Console.WriteLine(myArr2.Length);
            Console.WriteLine(myArr2.GetLength(0));
            Array.Clear(myArr2, 8, 3);
            PrintArr("Масив myArr2 післе очистки: ", myArr2);
            Array.Resize(ref myArr2, 5);
            PrintArr("Масив myArr2 післе зміни розміру:", myArr2);
            myArr2 = new[] { 1, 5, 3, 2, 8, 9, 6, 10, 7, 4 };
            PrintArr("Несортований масив myArr2: ", myArr2);
            Array.Sort(myArr2);
            PrintArr("Масив myArr2 післе сортування: ", myArr2);
            Console.WriteLine(Array.IndexOf(myArr1, 5));
            Console.WriteLine("Число 5 знаходится в масиве на " +
                Array.BinarySearch(myArr2, 5) + " позиції");

            Console.WriteLine("Максимальный елемент в масиві myArr2: " + myArr2.Max());
            Console.WriteLine("Мінимальный елемент в масиві myArr2: " + myArr2.Min());
            Console.WriteLine("Середнє арифметичне елементів myArr2: " +
                myArr2.Average());

            Console.WriteLine("Кількість вимірів масиву myArr3: " + myArr2.Rank);
            int[,] myArr3 = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("Количество измерений массива myArr3: " + myArr3.Rank);

            */

            #endregion

            #region MethodsWithArray

            /*

            int[] myArray = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + ", ");
            }
            Console.WriteLine();
            myArray = ModifyArray(myArray, 5);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + ", ");
            }

            Console.ReadKey();

            */

            #endregion

            #region Params

            /*

            var numbers = new int[] { 11, 11, 11, 14, 11 };

            //foreach (var i in numbers.GroupBy(i => i).Where(g => g.Count() == 1).Select(g => g.Key))
            //    Console.WriteLine(i);


            int[] items = { 2, 3, 5, 3, 7, 5 };
            int n = items.Length;

            Console.WriteLine("Unique array elements: ");

            for (int i = 0; i < n; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (items[i] == items[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    Console.WriteLine(items[i]);

                }
            }

            int[] arr = new int[] { 3, 3, 3, 7, 7, 7 };
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()!);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            ShowArray(1, arr);
            ShowArray(10, 3, 3, 3, 7, 7, 7, 47, 58, 96, 25, 23, 14, 74, 54, 85);
            //ShowArray("hello", 10, 15, 14, 47, 2, 3, 6, 9, 8);

            //int a = 5;
            ShowArray(2, new int[] { 3, 3, 3, 7, 7, 7 });
            // pause
            //Console.ReadKey();

            //var a = 5;
            Random random = new Random();

            double res = random.Next(100) + random.NextDouble();
            Console.WriteLine(res);

            res = Math.Round(res, 2);
            Console.WriteLine(res);
            ////ShowArray(10, 15, 14, 47, 2, 3, 6, 9, 8);

            */

            #endregion
        }
        #region functions

        static int[] ModifyArray(int[] array, int modifier)
        {
            for (int i = 0; i < array.Length; i++)
            {
                //array[i] = array[i] * modifier;
                array[i] *= modifier;
            }

            return array;
        }
        static void ShowArray(int num, int[] array)
        {
            Console.WriteLine("Number of arr : " + num);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
        static void ShowArray(int a, int b, int c, params int[] array)
        {
            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }

        #endregion
    }
}
