using System.Text;
using static System.Console;
namespace _2024_07_05___Lesson__Dispose_template_
{
    class DisposeExample : IDisposable
    {
        private bool isDisposed = false;

        private void Cleaning(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    WriteLine("Звільнення керованих ресурсів");
                }
                WriteLine("Звільнення некерованих ресурсів");
            }
            isDisposed = true;
        }
        public void Dispose()
        {
            Cleaning(true);

            GC.SuppressFinalize(this);
        }
        ~DisposeExample()
        {
            Cleaning(true);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;
            DisposeExample test = new DisposeExample();
            test.Dispose();
            DisposeExample test1 = new DisposeExample();

            FileStream fs = new FileStream("raefae", FileMode.Open);
            // read / write
            // exception
            fs.Dispose();
        }
    }
}
