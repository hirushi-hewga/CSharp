namespace _2024_06_10___Lesson__Intro_to_Microsoft_.NET_
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new object();

            byte a = 255;


            Byte b = 5;
            //Console.WriteLine(a);





            Console.WriteLine("Hello, World!");
            Console.Write("Hello\n");
            Console.Write("\tHello\n");
            Console.Write("\t\tHello");
            Console.Write("Hello");
            Console.Write("Hello");
            Console.Write("Hello");
            Console.Write("Hello\n");

            Console.WriteLine("Enter number : ");
            string str = Console.ReadLine();

            int number = int.Parse(str);
            Console.WriteLine(str + "!!!!!");
            Console.WriteLine(str + 100);
            Console.WriteLine(number + 100);
            Console.WriteLine("You entered ", number + 100, "!!!!!");
            Console.WriteLine($"You entered {number + 100} !!!!!");


            //int d = 0;
            //int? r = null;
            // int* ptr = nullptr;
            // int* ptr = new int(5)
        }
    }
}
