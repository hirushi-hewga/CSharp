namespace _2024_07_03___Lesson__Extension_
{
    static class ExampleExtension
    {
        public static int NumberWords(this string data)
        {
            if (string.IsNullOrEmpty(data)) return 0;
            return data.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static int NumberSymbols(this string data, char s)
        {
            if (string.IsNullOrEmpty(data)) return 0;
            int count = 0;
            foreach (char c in data)
            {
                if (c == s) count++;
            }
            return count;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Nulla placerat massa a turpis vestibulum egestas. Maecenas eleifend " +
                "nisl dapibus magna cursus, vitae ultricies ligula dictum. Morbi libero " +
                "est, varius nec nisi ac, egestas fringilla lorem. Vivamus dignissim " +
                "tristique nunc, sed efficitur urna porttitor.";

            Console.WriteLine($"Count words : {str.NumberWords()}");
            Console.WriteLine($"Count symbols 'o' : {str.NumberSymbols('o')}");
            Console.WriteLine($"Count symbols 'a' : {str.NumberSymbols('a')}");
        }
    }
}
