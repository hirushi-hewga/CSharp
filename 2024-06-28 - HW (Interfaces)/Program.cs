using System.Globalization;
using static System.Console;
namespace _2024_06_28___HW__Interfaces_
{
    interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int value_to_search);
    }

    interface IOutput
    {
        void Show();
        void Show(string info);
    }


    class Array : IOutput, IMath
    {
        private int[] arr;
        public int Arr
        {
            set {
                if (value <= 0)
                    throw new ArgumentException();
                else
                {
                    arr = new int[value];
                    Random random = new Random();
                    for (int i = 0; i < arr.Length; i++)
                        arr[i] = random.Next(100);
                }
            }
        }

        public Array() : this(5) { }
        public Array(int count)
        {
            Arr = count;
        }

        public void Show()
        {
            for (int i = 0; i < arr.Length; i++)
                Write("{0} ", arr[i]);
            WriteLine();
        }

        public void Show(string info)
        {
            Write(info + " - ");
            Show();
        }

        public int Max()
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > max) max = arr[i];
            return max;
        }

        public int Min()
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > min) min = arr[i];
            return min;
        }

        public float Avg()
        {
            int suma = 0;
            for (int i = 0; i < arr.Length; i++)
                suma += arr[i];
            return suma / arr.Length;
        }

        public bool Search(int value_to_search)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == value_to_search) return true;
            return false;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1

            
            
            try
            {
                IOutput array1 = new Array();
                IOutput array2 = new Array(8);
                array1.Show();
                array2.Show();
                array1.Show("Array 1");
                array2.Show("Array 2");
                // IOutput array3 = new Array(-1);
            }
            catch (ArgumentException ex)
            {
                WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }

            

            #endregion
        }
    }
}
