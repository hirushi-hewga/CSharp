namespace _2024_07_05___Lesson__Finalizer_
{
    class TestClass
    {
        public int MyProperty { get; set; }
        public TestClass()
        {
            Console.WriteLine("Constructor!");
        }
        // protected override void Finalize();
        ~TestClass()
        {
            Console.WriteLine("Finalize!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            if (true)
            {
                TestClass test = new TestClass();
            }

            Console.ReadKey();
        }
    }
}
