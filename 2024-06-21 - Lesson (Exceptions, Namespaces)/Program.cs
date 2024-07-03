namespace _2024_06_21___Lesson__Exceptions__Namespaces_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1, n = 2;
            try
            {
                Console.Write("Enter a : ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Enter b : ");
                n = int.Parse(Console.ReadLine());

                a = a / n;

                Console.WriteLine("a = {0}", a);
            }
            catch (DivideByZeroException e)
            {

            }
        }
    }
}
