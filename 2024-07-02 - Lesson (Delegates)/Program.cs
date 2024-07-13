using static System.Console;
namespace _2024_07_02___Lesson__Delegates_
{
    //class MyDelegate : Delegate
    //{
    //
    //}
    //public delegate void VoidDelegate();
    //public delegate int IntDelegate(double value);

    public delegate void SetStringDelegate(string value);
    public delegate double DoubleDelegate();
    public delegate void VoidDelegate();
    class SuperClass
    {
        public void Print(string str)
        {
            WriteLine(str + "!!!");
        }
        public static double GetKoef()
        {
            double res = new Random().NextDouble();
            return res;
        }
        public double GetNumber()
        {
            return new Random().Next();
        }
        public void DoWork()
        {
            WriteLine("I do some work");
        }
        public void Test()
        {
            WriteLine("I testing");
        }
    }
    public delegate double CalculatorDelegate(double x, double y);
    class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Multy(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            if (y != 0)
                return x / y;
            else
                throw new DivideByZeroException();
        }
    }
    public delegate int ChangeDelegate(int value)
    internal class Program
    {
        public static void DoOperator(double a, double b, CalculatorDelegate operation)
        {
            WriteLine(operation.Invoke(a, b));
        }
        public static void ChangeElements(int[] arr, ChangeDelegate change)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = change.Invoke(arr[i]);
            }
        }
        public static int Sqr(int v)
        {
            return v * v;
        }
        public static int Increment(int v)
        {
            return ++v;
        }
        public static int Decrement(int v)
        {
            return --v;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 7, 8, 9, 6, 5, 4, 23, 5 };
            foreach (var item in arr) Write(item + ' '); WriteLine();

            ChangeElements(arr, Sqr);
            foreach (var item in arr) Write(item + ' '); WriteLine();

            ChangeElements(arr, Increment);
            foreach (var item in arr) Write(item + ' '); WriteLine();

            ChangeElements(arr, Decrement);
            foreach (var item in arr) Write(item + ' '); WriteLine();

            ChangeElements(arr, delegate (int v) { return v + 10; });
            foreach (var item in arr) Write(item + ' '); WriteLine();

            //lambda expression
            ChangeElements(arr, v => --v);
            foreach (var item in arr) Write(item + ' '); WriteLine();



            /*
            Calculator calculator = new Calculator();
            CalculatorDelegate calcDelegate = null;
            calcDelegate += calculator.Add;
            calcDelegate += calculator.Sub;
            calcDelegate += calculator.Multy;
            calcDelegate += calculator.Div;
            calcDelegate -= calculator.Div;
            foreach (CalculatorDelegate i in calcDelegate.GetInvocationList())
            {
                WriteLine($"Res = {calcDelegate.Invoke(100, 25)}");
            }
            */


            /*
            SuperClass superClass = new SuperClass();
            superClass.Test();
            SuperClass.GetKoef();

            DoubleDelegate method = new DoubleDelegate(SuperClass.GetKoef);

            //if (method == null)
            //{
            //    WriteLine("method is null");
            //}
            //else
            //{
            //    WriteLine(method());
            //}

            WriteLine(method?.Invoke());

            DoubleDelegate[] arr = new DoubleDelegate[]
            {
                SuperClass.GetKoef,
                superClass.GetNumber
            };
            WriteLine(arr[0].Invoke());
            WriteLine(arr[1]());

            SetStringDelegate stringDelegate = new SetStringDelegate(superClass.Print);
            VoidDelegate @void = new VoidDelegate(superClass.DoWork);
            stringDelegate.Invoke("Hello academy");
            @void.Invoke();

            Delegate.Combine(method, superClass.GetType);
            method += new DoubleDelegate(superClass.GetNumber);
            method += superClass.GetNumber;
            method += superClass.GetNumber;
            method += SuperClass.GetKoef;
            foreach (var item in method.GetInvocationList())
            {
                WriteLine((item as DoubleDelegate)!.Invoke());
            }

            WriteLine($"Last Method : {method.Invoke()}");
            */
        }
    }
}
