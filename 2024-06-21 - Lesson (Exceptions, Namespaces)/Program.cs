using System.Collections;

namespace _2024_06_21___Lesson__Exceptions__Namespaces_
{
    class MyTestException : Exception
    {

    }
    class MyClass
    {
        public void BadMethod()
        {
            Exception exception = new Exception("MyException message");

            exception.HelpLink = "https://google.com";
            exception.Data.Add("Exception reason : ", "Test exception");
            exception.Data.Add("Time invokation : ", DateTime.Now);
            exception.Data.Add("User Name : ", "Vlad");
            throw exception;
        }
    }
    internal class Program
    {
        static double SafeDivision(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Second operand = 0");
            }
            return x / y;
        }
        static void Main(string[] args)
        {
            /*
            try
            {
                MyClass instance = new MyClass();
                instance.BadMethod();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.TargetSite);
                Console.WriteLine("{0}", e.TargetSite.DeclaringType);
                Console.WriteLine("{0}", e.TargetSite.MemberType);
                Console.WriteLine("{0}", e.TargetSite.Name);
                Console.WriteLine("{0}", e.Message);
                Console.WriteLine("{0}", e.Source);
                Console.WriteLine("{0}", e.HelpLink);
                Console.WriteLine("{0}", e.StackTrace);

                foreach (DictionaryEntry de in e.Data)
                    Console.WriteLine("{0} : {1}", de.Key, de.Value);
            }
            */



            /*
            double a = 98, b = 10;
            double result = 0;
            try
            {
                result = SafeDivision(a, b);
                Console.WriteLine("{0} divided by {1} = {2}", a, b, result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Attempted divide by zero.");
                Console.WriteLine(ex.Message);
            }
            */



            /*
            int a = 1, n = 2;
            try
            {
                Console.Write("Enter a : ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Enter b : ");
                n = int.Parse(Console.ReadLine());

                a = a / n;

                Console.WriteLine("a = {0}", a);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero");
                Console.WriteLine(e.Message);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Argument null exception");
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Overflow exception");
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format exception");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception catch!" + new string('-', 20));
                Console.WriteLine(e.Message);
            }
            */
        }
    }
}