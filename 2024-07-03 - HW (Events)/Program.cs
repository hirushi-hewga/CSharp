using System.Diagnostics;

namespace _2024_07_03___HW__Events_
{
    class Trader
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public float USD { get; set; }
        public float UAH { get; set; }
        public void PassExam(string task)
        {
            Console.WriteLine($"{FirstName} {LastName} , Birthday : {Birthday.ToShortDateString()}\nUSD : {USD} , UAH : {UAH}\n");
        }
    }
    class Exchange
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Trader> students = new List<Trader>
            {
                new Trader
                {
                    FirstName = "Bill",
                    LastName = "Tomson",
                    Birthday = new DateTime(2005, 4, 7)
                },
                new Trader
                {
                    FirstName = "Olga",
                    LastName = "Ivanchuk",
                    Birthday = new DateTime(2003, 10, 17)
                },
                new Trader
                {
                    FirstName = "Candice",
                    LastName = "Leman",
                    Birthday = new DateTime(2006, 3, 12)
                },
                new Trader
                {
                    FirstName = "Nicol",
                    LastName = "Taylor",
                    Birthday = new DateTime(2004, 7, 14)
                }
            };
        }
    }
}
