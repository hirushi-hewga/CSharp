using System.Collections;
using System.Text;

namespace _2024_07_08___Lesson__Standart_Generics_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region ArrayList


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



            Console.WriteLine("\nПочаткова колекція :");
            ArrayList arrayList = new ArrayList(new int[] { 1, 2, 3, 4 });
            foreach (int i in arrayList)
            {
                Console.WriteLine($"{i} ");
            }
            Console.WriteLine("Додавання елемента :");
            arrayList.Insert(2, "Hello");
            //arrayList.Sort();
            foreach (object item in arrayList)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine("\n\nВидалення елемента: ");
            arrayList.RemoveAt(3);
            foreach (object item in arrayList)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine("\n\nІндекс елемента \"Hello\" : " + arrayList.IndexOf("Hello"));
            Console.Write("\nОтримання діапазону : ");



            #endregion
        }
    }
}
