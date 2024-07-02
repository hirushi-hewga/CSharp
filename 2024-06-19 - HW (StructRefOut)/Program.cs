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
                $"Date of employment : {Date_of_employment}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[5];
            for (int i = 0; i < workers.Length; i++)
            {
                workers[i] = new Worker();
                workers[i].Salary = int.Parse(Console.ReadLine());
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
