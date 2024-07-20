namespace _2024_07_03___HW__Extension_
{
    static class Extension
    {
        public static bool IsPalindrome(this string word)
        {
            bool isPalindrome = true;
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                    isPalindrome = false;
            }
            return isPalindrome;
        }
        public static string Encryption(this string word, int number)
        {
            char[] encrypted_word = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                char ch = word[i];

                if (char.IsUpper(ch))
                {
                    for (int j = 0; j < number; j++)
                    {
                        if (ch == 90)
                            ch = (char)65;
                        else
                            ch = (char)(ch + 1);
                    }

                }
                else if (char.IsLower(ch))
                {
                    for (int j = 0; j < number; j++)
                    {
                        if (ch == 122)
                            ch = (char)97;
                        else
                            ch = (char)(ch + 1);
                    }
                }
                encrypted_word[i] = ch;
            }
            return new string(encrypted_word);
        }
        public static int EqualsNumbers(this Array array)
        {
            int[] arr = (int[])array;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && i != j)
                    {
                        count++;
                        break;
                    }
                }
            }
            return count;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IsPalindrome

            /*
            string word;
            Console.Write("Enter word : ");
            word = Console.ReadLine();
            if (word.IsPalindrome())
                Console.WriteLine("\nThis word is palindrome");
            else
                Console.WriteLine("\nThis word is not palindrome");
            */

            #endregion

            #region Encryption

            /*
            string word;
            Console.Write("Enter word : ");
            word = Console.ReadLine();
            Console.WriteLine($"Word : {word}");
            Console.WriteLine($"Encrypted word : {word.Encryption(3)}");
            */

            #endregion

            #region Count_Equal_Numbers

            /**/
            int[] arr = new int[16];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(16);
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine($"\nEqual numbers : {arr.EqualsNumbers()}");


            #endregion
        }
    }
}
