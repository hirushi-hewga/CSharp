using static System.Console;
namespace _2024_07_01___Lesson__Standart_interfaces_
{
    class StudentCard
    {
        public int Number { get; set; }
        public string Series { get; set; }
        public override string ToString()
        {
            return $"Name : {Number}. Series : {Series}";
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday{ get; set; }
        public StudentCard StudentCard { get; set; }
    }
    class Auditory : IEnumerable
    {
        Student[] students;
        public Auditory()
        {
            students = new Student[]//Array
           {

                new Student
                {
                    FirstName = "Bill",
                    LastName = "Tomson",
                    Birthday = new DateTime(2005, 4, 7),
                    StudentCard = new StudentCard() { Number = 123456, Series = "AA" }
                },
                new Student
                {
                    FirstName = new string("Olga"),
                    LastName = "Ivanchuk",
                    Birthday = new DateTime(2003, 10, 17),
                    StudentCard = new StudentCard() { Number = 321456, Series = "BA" }
                },
                new Student
                {
                    FirstName = "Candice",
                    LastName = "Leman",
                    Birthday = new DateTime(2006, 3, 12),
                    StudentCard = new StudentCard() { Number = 7412585, Series = "AA" }
                },
                new Student
                {
                    FirstName = "Nicol",
                    LastName = "Taylor",
                    Birthday = new DateTime(2004, 7, 14),
                    StudentCard = new StudentCard() { Number = 963258, Series = "BK" }
                }
            };
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Auditory auditory = new Auditory();
            foreach (var student in auditory.GetEnumerator())
            {

            }
        }
    }
}
