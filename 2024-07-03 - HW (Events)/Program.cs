using System.Diagnostics;

namespace _2024_07_03___HW__Events_
{
    public delegate void CourseDelegate(float c);
    class Trader
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public float USD { get; set; }
        public float UAH { get; set; }
        public void CourseHandler(float dollar_course)
        {
            if (dollar_course < 27)
            {
                float amountToBuy = UAH / dollar_course;
                Console.WriteLine($"{FirstName} {LastName} bought {amountToBuy:F2} USD at the rate of {dollar_course} UAH.");
                UAH = 0;
                USD += amountToBuy;
            }
            else if (dollar_course > 30)
            {
                if (USD > 0)
                {
                    Console.WriteLine($"{FirstName} {LastName} sold {USD:F2} USD at the rate of {dollar_course} UAH.");
                    UAH += USD * dollar_course;
                    USD = 0;
                }
                else
                {
                    Console.WriteLine($"{FirstName} {LastName} has no USD to sell.");
                }
            }
            else
            {
                Console.WriteLine($"{FirstName} {LastName} is waiting for better rates.");
            }
            
        }
    }
    class Exchange
    {
        public event CourseDelegate CourseDelegate;
        public void CreateCourse(float course)
        {
            CourseDelegate?.Invoke(course);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Trader> traders = new List<Trader>
            {
                new Trader
                {
                    FirstName = "Madden",
                    LastName = "Goddard",
                    Birthday = new DateTime(1996, 4, 7),
                    UAH = 2984,
                    USD = 874
                },
                new Trader
                {
                    FirstName = "Kells",
                    LastName = "Jean",
                    Birthday = new DateTime(1992, 10, 17),
                    UAH = 1283,
                    USD = 245
                },
                new Trader
                {
                    FirstName = "Newbold",
                    LastName = "Duckworth",
                    Birthday = new DateTime(1999, 3, 12),
                    UAH = 2793,
                    USD = 574
                },
                new Trader
                {
                    FirstName = "Waite",
                    LastName = "Cox",
                    Birthday = new DateTime(1994, 7, 14),
                    UAH = 1854,
                    USD = 265
                }
            };

            Exchange exchange = new Exchange();
            foreach (Trader trader in traders)
            {
                exchange.CourseDelegate += trader.CourseHandler;
            }

            float[] courses = { 26.5f, 31f, 29f, 27.5f };

            foreach (float course in courses)
            {
                Console.WriteLine($"\nCurrent dollar course : {course:F2} UAH");
                exchange.CreateCourse(course);
            }
        }
    }
}
