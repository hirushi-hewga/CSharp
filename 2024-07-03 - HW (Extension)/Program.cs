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
            string encrypted_word = word;
            for (int i = 0; i < encrypted_word.Length; i++)
            {
                if (char.IsUpper(encrypted_word[i]))
                {
                    for (int j = 0; j < number; j++)
                    {
                        if (encrypted_word[i] == 90)
                            encrypted_word[i] = (char)65;
                        else
                            encrypted_word[i] = (char)(encrypted_word[i] + 1);
                    }
                }
                else if (char.IsLower(encrypted_word[i]))
                {
                    for (int j = 0; j < number; j++)
                    {
                        if (encrypted_word[i] == 122)
                            encrypted_word[i] = (char)97;
                        else
                            encrypted_word[i] = (char)(encrypted_word[i] + 1);
                    }
                }
            }
            return encrypted_word;
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
