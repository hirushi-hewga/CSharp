using System.Collections;
using System.Text.RegularExpressions;

namespace _2024_07_12___HW__Regular_Expression__LINQ_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1

            /*
            string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\file1.txt";
            if (File.Exists(filePath))
                File.Delete(filePath);

            File.WriteAllText(filePath, "3.14 3,14 56.314 3489,457");
            string str = File.ReadAllText(filePath);

            Match m = Regex.Match(str, @"\d+\.\d+|\d+,\d+");
            while (m.Success)
            {
                Console.WriteLine(m.Value);
                m = m.NextMatch();
            }
            */

            #endregion

            #region 2

            /*
            string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\file1.txt";
            if (File.Exists(filePath))
                File.Delete(filePath);

            File.WriteAllText(filePath, "3.14 3,14 56.314 3489,457");
            string str = File.ReadAllText(filePath);

            Match m = Regex.Match(str, @"\d+");
            while (m.Success)
            {
                Console.WriteLine(m.Value);
                m = m.NextMatch();
            }
            */

            #endregion

            #region 3

            /*
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(100) - 50;
                Console.Write("{0}   ", arr[i]);
            }
            Console.WriteLine("\n");
            IEnumerable<int> newarr = from v in arr
                           where v > 0
                           orderby v ascending
                           select v;
            foreach (int item in newarr)
            {
                Console.Write("{0}   ", item);
            }
            */

            #endregion

            #region 4

            /*
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(100) - 50;
                Console.Write("{0}   ", arr[i]);
            }
            Console.WriteLine("\n");
            var query = arr.Where(item => item >= 10).Select(v => v);
            foreach (int item in query)
            {
                Console.Write("{0}   ", item);
            }
            Console.WriteLine("\n\nAvg : {0}", query.Average(v => v));
            */

            #endregion
        }
    }
}
