using System.Transactions;

namespace _2024_06_19___HW__StructRefOut_
{
    struct Fullname
    {
        public string name;
        public string surname;
        public string lastname;
    }
    partial class Worker
    {
        public override string ToString()
        {
            return $"Fullname : {Full_name[0]}.{Full_name[1][0]}.{Full_name[2][0]}" +
                $"  |  Age : {Age}  |  Salary : {Salary}  |  " +
                $"Date of employment : {Date_of_employment[0]}:{Date_of_employment[1]}:{Date_of_employment[2]}";
        }
        public void InitializeData()
        {
            string[] fullname = new string[3];
            Console.WriteLine();
            Console.Write("Enter worker name : ");
            fullname[0] = Console.ReadLine();
            Console.Write("Enter worker surname : ");
            fullname[1] = Console.ReadLine();
            Console.Write("Enter worker lastname : ");
            fullname[2] = Console.ReadLine();
            int age, salary;
            Console.Write("Enter worker age : ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter worker salary : ");
            salary = int.Parse(Console.ReadLine());
            int[] date = new int[3];
            Console.Write("Enter worker year of employment : ");
            date[0] = int.Parse(Console.ReadLine());
            Console.Write("Enter worker month of employment : ");
            date[1] = int.Parse(Console.ReadLine());
            Console.Write("Enter worker day of employment : ");
            date[2] = int.Parse(Console.ReadLine());
            Full_name = fullname;
            Age = age;
            Salary = salary;
            Date_of_employment = date;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[5];
            foreach (Worker worker in workers)
            {
                worker.InitializeData();
            }
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker.ToString());
            }





            /*
            Worker[] workers_ =
            {
                new Worker(new string[] { "Vladyslav", "Yanchuk", "Maksymovych" }, 17, 1000, new int[] { 2024, 7, 2 }),
                new Worker(new string[] { "Bogdan", "Kurylo", "Andriyavych" }, 17, 1100, new int[] { 2024, 7, 2 }),
                new Worker(new string[] { "Vladyslav", "Dmysh", "Anatoliyovych" }, 17, 1200, new int[] { 2024, 7, 2 }),
                new Worker(new string[] { "Nazar", "Petriuk", "Volodymyrovych" }, 17, 1300, new int[] { 2024, 7, 2 }),
                new Worker(new string[] { "Olena", "Iliushyn", "Sergiivna" }, 17, 1400, new int[] { 2024, 7, 2 })
            };
            */
        }
    }
}
