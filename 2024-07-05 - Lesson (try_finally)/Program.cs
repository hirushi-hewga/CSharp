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
            Cleaning(false);
        }
        public void DoSomething()
        {
            WriteLine("Виконання певних операцій");
            if (true)
                throw new Exception();
        }
    }
    class User : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;
            DisposeExample test = new DisposeExample();
            try
            {
                test.DoSomething();
                // exception
                // // this.close();
            }
            catch (Exception ex) { WriteLine(ex.Message); } // this.close();
            finally
            {
                test.Dispose();
            }
            WriteLine("Continue...");

            using (DisposeExample test1 = new DisposeExample())
            {
                test1.DoSomething();
            } // Dispose(); this.Close();

            using (User test2 = new User())
            {
                //test2.DoSomething();
            } // test1.Dispose()

            using (FileStream str = new FileStream("Hello.txt", FileMode.Create))
            {
                // write...read
                // ex
            } //str.Dispose()
        }
    }
}
