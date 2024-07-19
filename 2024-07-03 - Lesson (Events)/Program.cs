using System.Threading.Channels;

namespace _2024_07_03___Lesson__Events_
{
    public delegate void ActionDelegate();
    internal class Program
    {
        static void HardWork(ActionDelegate action)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Operation {i + 1} working.....");
                Thread.Sleep(random.Next(500));
                Console.WriteLine($"Operation {i + 1} finished.....");
            }
            action.Invoke();
            // Console.WriteLine(); // another message
        }
        static void Action1()
        {
            Console.WriteLine("You are very good worker!!!");
        }
        static void Action2()
        {
            Console.WriteLine("You are normal worker!!!");
        }
        static void Action3()
        {
            Console.WriteLine("You are loser!!!");
        }
        static void Main(string[] args)
        {
            HardWork(Action1);
            HardWork(Action2);
            HardWork(Action3);
            HardWork(null);
        }
    }
}
