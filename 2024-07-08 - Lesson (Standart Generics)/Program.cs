using System.Collections;
using System.Drawing;
using System.Text;

namespace _2024_07_08___Lesson__Standart_Generics_
{
    class MyClass
    {
        public int Number { get; set; }

        public MyClass()
        {
            Number = 0;
        }
        public MyClass(int number)
        {
            Number = number;
        }

        public void Show()
        {
            Console.WriteLine($"Number : {Number}");
        }
        public static explicit operator int(MyClass myClass)
        {
            return myClass.Number;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region ArrayList

            /*
            ArrayList arrayList1 = new ArrayList();
            ArrayList arrayList2 = new ArrayList(new int[] { 1, 2, 5, 8 });
            ArrayList arrayList3 = new ArrayList(10);
            Console.WriteLine($"Місткість по замовчуванню : {arrayList1.Capacity}");
            arrayList1.Add("one");
            arrayList1.Add(3.14f);
            arrayList1.Add(0.999);
            arrayList1.Add(3.36m);
            arrayList1.Add(false);

            Console.WriteLine($"Місткість після додавання одного елемента : {arrayList1.Capacity}");
            arrayList1.AddRange(new int[] { 2, 5, 48, 14 });
            Console.WriteLine($"Місткість після додавання колекції : {arrayList1.Capacity}");
            arrayList1.Capacity = 10;
            Console.WriteLine($"Місткість задана через property : {arrayList1.Capacity}");
            Console.WriteLine($"Фактична кількість елементів : {arrayList1.Count}");
            arrayList1.TrimToSize();
            Console.WriteLine($"Місткість зменшена до фактичної кількості елементів : {arrayList1.Capacity}");
            Console.WriteLine($"Елемент за індексом 2 : {arrayList1[2]}");
            Console.WriteLine($"Всі елементи колекції :");

            foreach (object item in arrayList1)
            {
                Console.WriteLine("\t{0}", item);
                if (item is int)
                {
                    int a = (int)item;
                    a++;
                    Console.WriteLine(a);
                }
                if (item is float)
                {
                    float a = (float)item;
                    a++;
                    Console.WriteLine(a);
                }
            }
            */

            /*
            Console.Write("\nПочаткова колекція :");
            ArrayList arrayList = new ArrayList(new int[] { 1, 2, 3, 4 });
            foreach (int i in arrayList)
            {
                Console.Write($"{i} ");
            }
            Console.Write("\n\nДодавання елемента :");
            arrayList.Insert(2, "Hello");
            //arrayList.Sort();
            foreach (object item in arrayList)
            {
                Console.Write($"{item} ");
            }
            Console.Write("\n\nВидалення елемента: ");
            arrayList.RemoveAt(3);
            foreach (object item in arrayList)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n\nІндекс елемента \"Hello\" : " + arrayList.IndexOf("Hello"));
            Console.Write("\nОтримання діапазону : ");
            ArrayList days = new ArrayList(new string[] { "Sunday", "Monday", "Tuesday",
                "Wednesday", "Thursday", "Friday", "Saturday" });
            ArrayList onlyWork = new ArrayList(days.GetRange(1, 5));
            foreach (string s in onlyWork)
            {
                Console.Write($"{s} ");
            }
            Console.Write("\n\nСортування колекції : ");
            onlyWork.Sort();
            foreach (string s in onlyWork)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();
            */

            #endregion

            #region Stack

            /*
            Stack stack1 = new Stack();
            Stack stack2 = new Stack(7);
            Stack stack3 = new Stack(new ArrayList { 3, 5 });
            Stack stack = new Stack();
            Console.Write("Метод Push() : ");
            stack.Push("one");
            stack.Push("two");
            stack.Push("three");
            foreach (string item in stack)
            {
                Console.Write($"{item} ");
            }
            Console.Write("\n\nМетод Pop() : ");
            stack.Pop();
            foreach (string item in stack)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\n\nМетод Peek() : {(string)stack.Peek()}");
            Console.WriteLine("\nЧи існує елеммент \"ten\" : " + stack.Contains("ten"));
            Console.WriteLine("\nЧи існує елеммент \"two\" : " + stack.Contains("two"));
            Console.Write("\nМетод CopyTo() : ");
            string[] strArr = new string[stack.Count];
            stack.CopyTo(strArr, 0);
            foreach (string item in strArr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n\nКількість елементів : " + stack.Count);
            stack.Clear();
            Console.WriteLine("\nКількість елементів виклику методу Clear() : " + stack.Count);
            */

            /*
            var stackk = new Stack();
            stackk.Push("First");
            stackk.Push("Secons");
            stackk.Push("Third");
            stackk.Push("Fourth");
            // Peek - get first
            if (stackk.Peek() is string)
            {
                string str = (string)stackk.Pop();
                Console.WriteLine(str);
            }
            while (stackk.Count > 0)
            {
                Console.WriteLine(stackk.Pop());
            }
            Console.WriteLine(stackk.Pop());
            */

            #endregion

            #region BoxingUnboxing

            /*
            object obj = new object(); // ref
            int number = 45; // value - stack

            // Boxing
            obj = (object)number; // value - ref
            Console.WriteLine(obj);

            // Unboxing
            number = (int)obj;
            Console.WriteLine(number);

            // Boxing
            MyClass myClass = new MyClass(number); // value => ref

            // Unboxing
            int res = (int)myClass;
            */


            int a = 5;
            string str = "Hello";
            ArrayList arrayList1 = new ArrayList(new int[] { 1, 2, 5, 8 });
            ArrayList arrayList3 = new ArrayList(10);
            Console.WriteLine($"Місткість по замовчуванню : {arrayList1.Capacity}");
            arrayList1.Add("one");
            arrayList1.Add(3.14f);
            arrayList1.Add(0.999);
            arrayList1.Add(3.36m);
            arrayList1.Add(false);



            #endregion
        }
    }
}
