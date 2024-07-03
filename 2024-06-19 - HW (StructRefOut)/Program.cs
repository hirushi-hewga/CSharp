using System.Transactions;

namespace _2024_06_19___HW__StructRefOut_
{
    enum Actions
    {
        ADD = 1, SUB, MUL, DIV
    }
    struct Fullname
    {
        public string name;
        public string surname;
        public string lastname;
        public Fullname(string name, string surname, string lastname)
        {
            this.name = name;
            this.surname = surname;
            this.lastname = lastname;
        }
    }
    partial class Calculator
    {
        public float Add()
        {
            return A + B;
        }
        public float Sub()
        {
            return A - B;
        }
        public float Mul()
        {
            return A * B;
        }
        public float Div()
        {
            if (B != 0) return A / B;
            throw new Exception("Cannot divide by zero");
        }
    }
    partial class Worker
    {
        public override string ToString()
        {
            return $"Fullname : {Full_name.surname}.{Full_name.name[0]}.{Full_name.lastname[0]}" +
                $"  |  Age : {Age}  |  Salary : {Salary}  |  " +
                $"Date of employment : {Date_of_employment.ToLongDateString}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1
            Worker[] workers = new Worker[5];
            for (int i = 0; i < workers.Length; i++)
            {
                workers[i] = new Worker();
                string name, surname, lastname;
                Console.Write("Enter worker name : ");
                name = Console.ReadLine();
                Console.Write("Enter worker surname : ");
                surname = Console.ReadLine();
                Console.Write("Enter worker lastname : ");
                lastname = Console.ReadLine();
                workers[i].Full_name = new Fullname(name, surname, lastname);
                Console.Write("Enter worker age : ");
                workers[i].Age = int.Parse(Console.ReadLine());
                Console.Write("Enter worker salary : ");
                workers[i].Salary = int.Parse(Console.ReadLine());
                Console.Write("Enter date of employment (yyyy-mm-dd) : ");
                string date = Console.ReadLine();
                string[] split_date = date.Split('-', StringSplitOptions.None);
                workers[i].Date_of_employment = new DateTime(int.Parse(split_date[0]), int.Parse(split_date[1]), int.Parse(split_date[2]));
            }
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker.ToString());
            }
            */



            /* 2
            Calculator calc;
            float a, b;
            int action;
            while (true)
            {
                Console.Clear();
                Console.Write("Enter first number : ");
                a = float.Parse(Console.ReadLine());
                Console.Write("Enter second number : ");
                b = float.Parse(Console.ReadLine());
                calc = new Calculator(a, b);
                Console.WriteLine();
                do
                {
                    Console.WriteLine();
                    Console.Write("1. +\n2. -\n3. *\n4. /\nChoice an action : ");
                    action = int.Parse(Console.ReadLine());
                } while (action < 1 || action > 4);
                Console.WriteLine();
                switch (action)
                {
                    case (int)Actions.ADD: Console.WriteLine(calc.Add()); break;
                    case (int)Actions.SUB: Console.WriteLine(calc.Sub()); break;
                    case (int)Actions.MUL: Console.WriteLine(calc.Mul()); break;
                    case (int)Actions.DIV: Console.WriteLine(calc.Div()); break;
                }
                Console.ReadLine();
            }
            */
        }
    }
}
