using static System.Console;
namespace _2024_07_05___Lesson__Dispose_
{
    class DisposeExample : IDisposable
    {
        Stream stream;
        public DisposeExample()
        {
            WriteLine("Open stream...");
            stream = new FileStream(@"C:\Users\helen\Desktop\doc.txt", FileMode.Open);
        }
        // protected override void Finalize() { }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundent

        public void Dispose()
        {
            WriteLine("Close stream...");
            stream.Close();
        }
        #endregion
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DisposeExample de = new DisposeExample();

            // extension
            de.Dispose();
            // code...
        }
    }
}
