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

            string line = "Дано текст. Визначте відсоткове відношення" +
                " малих і великих літер до загальної кількості символів в ньому";
            foreach (char item in line)
            {
                Console.Write(item);
            }

            #endregion

            #region 4

            #endregion

            #region 5

            #endregion

            #region 6

            #endregion

            #region 7

            #endregion
        }
    }
}
