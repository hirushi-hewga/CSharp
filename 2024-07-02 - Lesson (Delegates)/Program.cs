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
    internal class Program
    {
        static void Main(string[] args)
        {
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
            VoidDelegate @void = new VoidDelegate(superClass.Print)
        }
    }
}
