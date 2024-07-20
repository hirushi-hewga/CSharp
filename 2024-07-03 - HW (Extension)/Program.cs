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

            /**/
            string word;
            Console.Write("Enter word : ");
            word = Console.ReadLine();


            #endregion
        }
    }
}
