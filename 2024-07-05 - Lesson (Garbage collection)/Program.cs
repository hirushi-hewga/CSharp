using System.Text;

namespace _2024_07_05___Lesson__Garbage_collection_
{
    class GarbageHelper
    {
        public void MakeGarbage()
        {
            for (int i = 0; i < 1000; i++)
            {
                Person p = new Person();
            }
        }
        class Person
        {
            string _name;
            string _surname;
            string _age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 5;
            string str = "1";
            string copy = null;
            if (true)
            {
                int b = 10;
                string str2 = "2";
                //delete str2;
                copy = str2;
                Console.WriteLine(str2);
                Console.WriteLine(b);
            }
            //Console.WriteLine(b);
            //Console.WriteLine(str2);
            Console.WriteLine(copy);
            Console.WriteLine(copy + str);
            copy = "Hello";
            */



            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Демонстрація System.GC");
            Console.WriteLine($"Максимальне покоління : {GC.MaxGeneration}");
            GarbageHelper hlp = new GarbageHelper();

            // Покоління, в якому знаходиться об'єкт
            Console.WriteLine($"Покоління об'єкта : {GC.GetGeneration(hlp)}");
            // Кількість зарезервованої пам'яті
            Console.WriteLine($"Зарезервовано пам'яті (байт) : {GC.GetTotalMemory(false)}");
            // Створення сміття
            hlp.MakeGarbage();
            Console.WriteLine($"Зарезервовано пам'яті (байт) : {GC.GetTotalMemory(false)}");
            // Явний виклик збору сміття в поколінні 0
            GC.Collect(0);

            Console.WriteLine($"Зарезервовано пам'яті (байт) : {GC.GetTotalMemory(false)}");
            Console.WriteLine($"Покоління об'єкта : {GC.GetGeneration(hlp)}");
            // якний виклик збору сміття у всіх поколіннях
            GC.Collect(1);

            Console.WriteLine($"Зарезервовано пам'яті (байт) : {GC.GetTotalMemory(false)}");
            Console.WriteLine($"Покоління об'єкта : {GC.GetGeneration(hlp)}");

            hlp.GetType();
        }
    }
}
