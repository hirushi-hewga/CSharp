using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Channels;

namespace _2024_06_14___HW__Enum_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region 1

            /*
            string str_1 = "Hello, !";
            string str_2 = "World";
            int pos = 7;
            Console.WriteLine(str_1);
            Console.WriteLine(str_2);
            StringBuilder str_3 = new StringBuilder(str_1);
            str_3.Insert(pos, str_2);
            Console.WriteLine(str_3);
            */

            #endregion

            #region 2

            /*
            Console.Write("Enter word : ");
            string word = Console.ReadLine();
            bool isPalindrome = true;
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                    isPalindrome = false;
            }
            if (isPalindrome)
                Console.WriteLine("\nThis word is palindrome");
            else
                Console.WriteLine("\nThis word is not palindrome");
            */

            #endregion

            #region 3

            /*
            string line = "Дано текст. Визначте відсоткове відношення" +
                " малих і великих літер до загальної кількості символів в ньому";
            string line_2 = line.Replace(" ", "").Replace(".", "");
            Console.WriteLine(line);
            Console.WriteLine($"\nЛітери становлять {Math.Round(((float)line_2.Length / line.Length) * 100, 1)}% від загальної кількості символів");
            */

            #endregion

            #region 4

            /*
            string[] words = { "Book", "Summer", "Sun", "Music", "Friendship", "Travel", "Happiness", "Love", "Freedom", "Health" };
            foreach (string word in words) { Console.Write("{0} ", word); }
            Console.WriteLine();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 5)
                {
                    words[i] = words[i].Substring(0, words[i].Length - 3) + "$$$";
                }
            }
            foreach (string word in words) { Console.Write("{0} ", word); }
            Console.WriteLine();
            */

            #endregion

            #region 5

            /*
            string line = "Знайти слово, що стоїть в тексті" +
                " під певним номером, і вивести його першу букву.";
            string[] words = line.Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, words[i]);
            }
            Console.Write("\nChoice word : ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < words.Length; i++)
            {
                if (number - 1 == i)
                    Console.WriteLine("\nПерша буква - {0}", words[i][0]);
            }
            */

            #endregion

            #region 6

            /*
            string line = "кожен день ми можемо вчитися чомусь новому";
            Console.WriteLine(line);
            line = line.Replace(' ', '*');
            Console.WriteLine(line);
            */

            #endregion

            #region 7

            string[] words = new string[1];
            string word = "123";
            while (true)
            {
                Console.Write("\nEnter word : ");
                word = Console.ReadLine();
                if (word[word.Length - 1] != '.')
                    Array.Resize(ref words, words.Length + 1);
                else break;
            }
            StringBuilder str = new StringBuilder();
            foreach (string item in words)
            {
                if (item != null) str.Append(item);
                if (item != null && item[item.Length - 1] != '.')
                    str.Append(", ");
            }

            #endregion
        }
    }
}
