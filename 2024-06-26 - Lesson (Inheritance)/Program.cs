using static System.Console;
namespace _2024_06_26___Lesson__Inheritance_
{
    // public private protected

    abstract class Person
    {
        protected string name;
        private readonly DateTime birthday;
        public Person()
        {
            name = "no name";
            birthday = new DateTime(2000, 5, 5);
        }
        public Person(string n, DateTime b)
        {
            name = n;
            if (b > DateTime.Now)
            {
                birthday = new DateTime(2000, 5, 5);
            }
            else
            {
                birthday = b;
            }
        }
        public virtual void Print()
        {
            WriteLine($"Name : {name} ,  Birthday : {birthday.ToShortDateString()}");
        }
        public abstract void DoWork(); // = 0
        public override string ToString()
        {
            return $"Name : {name} ,  Birthday : {birthday.ToShortDateString()}";
        }
    }

    // class Name : BaseClass, Interface, Interface2
    class Worker : Person
    {
        private double salary;
        public double Salary
        {
            get { return salary; }
            set
            {
                this.salary = value > 0 ? value : 0;
            }
        }
        public Worker() : base()
        {
            Salary = 0;
        }
        public Worker(string n, DateTime b, double s) : base(n, b)
        {
            Salary = s;
        }
        public override void DoWork()
        {
            WriteLine("Doing some work......");
        }
        public override void Print()
        {
            base.Print();
            WriteLine($"Salary : {Salary}");
        }
    }

    sealed class Programmer : Worker
    {
        public int CodeLines { get; set; }
        public Programmer() : base()
        {
            CodeLines = 0;
        }
        public Programmer(string n, DateTime b, double s) : base(n, b, s)
        {
            CodeLines = 0;
        }
        public sealed override void DoWork()
        {
            WriteLine("Write C# code");
        }
        public override void Print()
        {
            base.Print();
            WriteLine($"Code lines {CodeLines}");
        }
        public void WriteCode()
        {
            CodeLines++;
        }
    }

    class TeamLead : Worker
    {
        public int ProjectCount { get; set; }
        //public override void DoWork()
        //{
        //    WriteLine("Manage team project");
        //}
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker("Vova", new DateTime(1995, 7, 8), 32000);
            worker.Print();
            Programmer programmer = new Programmer("Ivan", new DateTime(2000, 12, 14), 45);
            programmer.WriteCode();
            programmer.WriteCode();
            programmer.WriteCode();
            programmer.Print();
            Person[] people = new Person[]
            {
                // new Person(),
                worker,
                programmer,
                new Worker("Petro", new DateTime(1999, 5, 7), 15000)
            };


            Programmer pr = null;
            // 1 - use cast ()
            try
            {
                pr = (Programmer)people[1];
                pr.DoWork();
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }

            // 2 - use as
            pr = people[2] as Programmer;
            if (pr != null)
                pr.DoWork();
            else WriteLine("Null");

            // 3 - use is and as
            if (people[2] is Programmer)
            {
                pr = people[2] as Programmer;
                pr.DoWork();
            }


            foreach (var item in people)
            {
                WriteLine("---------------- Info ----------------");
                item.Print();
                WriteLine();
            }
        }
    }
}
