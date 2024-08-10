namespace _2024_07_08___HW__Generics_
{
    static class MyClass
    {
        public static T GetMax<T>(T num1, T num2, T num3) where T : IComparable
        {
            T max = num1.CompareTo(num2) > 0 ? num1 : num2;
            return max.CompareTo(num3) > 0 ? max : num3;
        }
        public static T GetMin<T>(T num1, T num2, T num3) where T : IComparable
        {
            T min = num1.CompareTo(num2) < 0 ? num1 : num2;
            return min.CompareTo(num3) < 0 ? min : num3;
        }
        public static T GetSumma<T>(T[] arr) where T : struct
        {
            dynamic sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }
    }
    class Stack<T>
    {
        private int top;
        private int size;
        private T[] arr;

        public Stack()
        {
            top = 0;
            size = 10;
            arr = new T[size];
        }

        public void Push(T value)
        {
            if (top >= size)
            {
                size *= 2;
                Array.Resize(ref arr, size);
            }
            arr[top++] = value;
        }
        public T Pop()
        {
            if (isEmpty())
                throw new InvalidOperationException("Cannot Pop from an empty stack");
            return arr[--top];
        }
        public T Peek()
        {
            if (isEmpty())
                throw new InvalidOperationException("Cannot Peek from an empty stack");
            return arr[top - 1];
        }
        public int Count()
        {
            return top;
        }
        public void Show()
        {
            Console.Write("Elements : ");
            for (int i = 0; i < top; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }

        public bool isEmpty()
        {
            return top == 0;
        }
    }
    class Queue<T>
    {
        private int top;
        private int maxSize;
        private T[] arr;

        public int MaxSize {
            get { return maxSize; }
            set {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("value");
                maxSize = value;
            }
        }

        public Queue(int size)
        {
            top = 0;
            MaxSize = size;
            arr = new T[MaxSize];
        }

        public void Enqueue(T value)
        {
            if (isFull())
                throw new InvalidOperationException();
            arr[top++] = value;
        }

        public T Dequeue()
        {
            if (isEmpty())
                throw new InvalidOperationException();
            T first = arr[0];
            for (int i = 1; i < top; i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[--top] = first;
            return first;
        }

        public T Peek()
        {
            if (isEmpty())
                throw new InvalidOperationException();
            return arr[0];
        }

        public int Count()
        {
            return top;
        }

        public void Show()
        {
            Console.Write("Elements : ");
            for (int i = 0; i < top; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }

        public bool isEmpty()
        {
            return top <= 0;
        }

        public bool isFull()
        {
            return top >= maxSize;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1

            /*
            Console.WriteLine($"Max : {MyClass.GetMax(21, 54, 13)}");
            */

            #endregion

            #region 2

            /*
            Console.WriteLine($"Min : {MyClass.GetMin(27.4f, 52.7f, 16.1f)}");
            */

            #endregion

            #region 3

            /*
            Console.WriteLine($"Summa : {MyClass.GetSumma(new int[] { 1, 5, 2, 4, 2, 9, 4, 7 })}");
            */

            #endregion

            #region 4

            /*
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Show();
            Console.WriteLine("\nPop : " + stack.Pop());
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            stack.Push(10);
            stack.Show();
            Console.WriteLine("\nCount : " + stack.Count());
            Console.WriteLine("Peek : " + stack.Peek());
            */

            #endregion

            #region 5


            Queue<int> queue = new Queue<int>(10);
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Show();
            Console.WriteLine("\nPeek : " + queue.Peek());
            queue.Enqueue(40);
            queue.Enqueue(50);
            queue.Show();
            Console.WriteLine("\nCount : " + queue.Count());
            Console.WriteLine("Dequeue : " + queue.Dequeue());
            queue.Show();


            #endregion
        }
    }
}
