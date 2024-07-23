using static System.Console;
namespace _2024_07_05___Lesson__Dispose_
{
    class DisposeExample : IDisposable
    {
        Stream stream;
        public DisposeExample()
        {
            WriteLine("Open stream...");
            stream = new FileStream(@"C:\Users\helen\Desktop\doc.txt", FileMode.Open)
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
