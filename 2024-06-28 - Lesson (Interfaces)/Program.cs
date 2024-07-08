using static System.Console;
namespace _2024_06_28___Lesson__Interfaces_
{
    interface IWorker
    {
        // public
        bool IsWorking { get; set; }
        void Work();
        event EventHandler<EventArgs> Worker;
    }

    abstract class Human
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
        public override string ToString()
        {
            return $"Fullname : {Lastname} {Firstname}. Birthday : {Birthday.ToShortDateString()}";
        }
    }

    abstract class Employee : Human
    {
        public string Position { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"\nPosition : {Position}. Salary {Salary} grn\n";
        }
    }

    interface IWorkable
    {
        bool IsWorking { get; }
        string Work();
    }

    interface IManager
    {
        List<IWorkable> ListOfWorkers { get; set; }
        void Organize();
        void Control();
        void MakeBudget();
    }

    class Director : Employee, IManager // implement(realize)
    {
        public List<IWorkable> ListOfWorkers { get; set; } // null

        public void Control()
        {
            WriteLine("I control work");
        }

        public void MakeBudget()
        {
            WriteLine("I make budget");
        }

        public void Organize()
        {
            WriteLine("I organize work");
        }
    }

    class Seller : Employee, IWorkable
    {
        // 1 - readonly - get
        //private bool isWorking = true;
        //public bool IsWorking
        //{
        //    get { return IsWorking; }
        //}

        // 2 - readonly - get
        //public bool IsWorking { get; } = true;

        // 3 - lambda
        public bool IsWorking => true; // readonly - get

        public string Work()
        {
            return "I selling product";
        }
    }

    class Cashier : Employee, IWorkable
    {
        public bool IsWorking => true;

        public string Work()
        {
            return "I get pay for product";
        }
    }
    class Administrator : Employee, IWorkable, IManager
    {
        public bool IsWorking => true;

        public List<IWorkable> ListOfWorkers { get; set; }

        public void Control()
        {
            WriteLine("I am a BOSSSS.....");
        }

        public void MakeBudget()
        {
            WriteLine("I am rich!!! I have a lot of money!!!");
        }

        public void Organize()
        {
            WriteLine("I organize work");
        }

        public string Work()
        {
            return "I do my work again ((((((";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IManager director = new Director()
            {
                Firstname = "Sasha",
                Lastname = "Mukoluk",
                Birthday = new DateTime(1985, 12, 7),
                Position = "Director",
                Salary = 45000
            };
            director.Control();
            director.Organize();
            director.MakeBudget();
            WriteLine(director);
            Seller seller = new Seller()
            // IWorkable seller = new Seller()
            {
                Firstname = "Olga",
                Lastname = "Nikituk",
                Birthday = new DateTime(2000, 7, 12),
                Position = "Seller",
                Salary = 7350
            };
            WriteLine(seller);
            director.ListOfWorkers = new List<IWorkable>
            {
                seller,
                new Cashier
                {
                    Firstname = "Petro",
                    Lastname = "Nikituk",
                    Birthday = new DateTime(2001, 1, 21),
                    Position = "Cashier",
                    Salary = 10000
                },
                new Seller
                {
                    Firstname = "Mira",
                    Lastname = "Nikituk",
                    Birthday = new DateTime(2001, 1, 21),
                    Position = "Cashier",
                    Salary = 12200
                },
                new Administrator
                {
                    Firstname = "Bob",
                    Lastname = "Nikituk",
                    Birthday = new DateTime(2002, 1, 21),
                    Position = "Cashier",
                    Salary = 22000
                }
            };
            foreach (IWorkable emp in director.ListOfWorkers)
            {
                WriteLine(emp.Work());

                if (emp is Cashier)
                    WriteLine("This is cashier");

                if (emp is Administrator)
                    (emp as Administrator).Control();
            }


            Administrator admin = new Administrator(); // 21v31d2fv1d5fv
            IManager manager = admin; // 21v31d2fv1d5fv
            manager.Control();
            IWorkable worker = admin; // 21v31d2fv1d5fv
            worker.Work();


        }
    }
}
