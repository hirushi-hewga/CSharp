using System.Collections.Specialized;

namespace _2024_06_10___HW__Intro_to_Microsoft_.NET_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("It's easy to win forgiveness for being wrong;");
            Console.WriteLine("being right is what gets you into real trouble.");
            Console.WriteLine("Bjarne Stroustrup");
            */


            /*
            int suma = 0;
            int dobutok = 1;
            int? min = null;
            int? max = null;
            int a;
            Console.WriteLine("--- Enter five numbers ---");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter number : ");
                a = int.Parse(Console.ReadLine());
                if (min == null) min = max = a;
                if (min > a) min = a;
                if (max < a) max = a;
                suma += a;
                dobutok *= a;
            }
            Console.WriteLine($"\nDobutok : {dobutok}");
            Console.WriteLine($"Suma : {suma}");
            Console.WriteLine($"Min : {min}");
            Console.WriteLine($"Max : {max}");
            */


            /*
            Console.Write("Enter six-digit number : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Number : " + number % 10 + number % 100 / 10 + number % 1000 / 100 + number % 10000 / 1000 + number % 100000 / 10000 + number % 1000000 / 100000);
            */


            /*
            Console.WriteLine("--- Enter diapazon ---");
            Console.Write("Enter first number : ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second number : ");
            int second = int.Parse(Console.ReadLine());
            if (first > second)
            {
                int temp = first;
                first = second;
                second = temp;
            }
            int num_1 = 0;
            int num_2 = 1;
            while (num_1 < second)
            {
                if (num_1 >= first) Console.WriteLine(num_1);
                num_2 += num_1;
                num_1 = num_2 - num_1;
            }
            */


            /*
            int A = 2;
            int B = 8;
            for (; A <= B; A++)
            {
                for (int i = 0; i < A; i++)
                {
                    Console.Write($"{A} ");
                }
                Console.WriteLine();
            }
            */


            /*
            Console.Write("Enter symbol : ");
            ConsoleKeyInfo key = Console.ReadKey();
            char symbol = key.KeyChar;
            Console.Write("\nEnter length : ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("\n--- select a direction ---");
            Console.WriteLine("\n1 - horizontalno");
            Console.WriteLine("\n2 - vertikalno");
            Console.Write("\nEnter your choice : ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1 || choice == 2)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(symbol);
                    if (choice == 2) Console.WriteLine();
                }
            }
            else Console.WriteLine("\nError choice");
            */
        }
    }
}