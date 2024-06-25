using System.Text;

namespace _2024_06_14___Lesson__StringBuilder_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string str = "hello";
            str += "hello";
            str += "hello";
            str += "hello";
            str += "hello";
            str += "hello";
            str += "hello";
            str += "hello";
            str += "hello";
            str += "hello";
            str += "hello";
            str += "hello";
            str += "hello";
            str += "hello";
            str += "hello";
            */


            string str = "hello";
            str += "hello";

            StringBuilder builder = new StringBuilder();
            Console.WriteLine($"Length : {builder.Length}");
            Console.WriteLine($"Capacity : {builder.Capacity}");

            builder.Append("Hello");
            builder.Append("Hello");
            builder.Append("Hello");
            Console.WriteLine($"Length : {builder.Length}");
            Console.WriteLine($"Capacity : {builder.Capacity}");
            
            builder.AppendLine("World");
            Console.WriteLine($"Length : {builder.Length}");
            Console.WriteLine($"Capacity : {builder.Capacity}");


            Console.WriteLine(builder);
            builder.Append("Hello");
            builder.Append("Hello");
            builder.Append("Hello");
            Console.WriteLine($"Length : {builder.Length}");
            Console.WriteLine($"Capacity : {builder.Capacity}");
            Console.WriteLine(builder);
        }
    }
}
