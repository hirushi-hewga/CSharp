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
            return $"Fullname : {Full_name.surname}.{Full_name.name[0]}.{Full_name.lastname[0]}" +
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
                Console.Write("Enter worker name : ");
                workers[i].Salary = int.Parse(Console.ReadLine());
            }
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker.ToString());
            }
        }
    }
}
