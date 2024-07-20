using System.Security.AccessControl;
using System.Threading.Channels;

namespace _2024_07_03___Lesson__Events_
{
    public delegate void ActionDelegate();
    public delegate void ExamDelegate(string t);
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public void PassExam(string task)
        {
            Console.WriteLine($"Student : {FirstName} {LastName} pass the exam {task}");
        }
    }
    class Teacher
    {
        public event Action TestEvent;
        // public event ExamDelegate ExamDelegate; // auto property
        // or
        public ExamDelegate examDelegate;
        public event ExamDelegate ExamDelegate
        {
            add
            {
                examDelegate += value;
                Console.WriteLine(value.Method.Name + "was added");
            }
            remove
            {
                examDelegate -= value;
                Console.WriteLine(value.Method.Name + "was removed");
            }
        }
        public void CreateExam(string task)
        {
            // create exam
            // some

            // call students
            examDelegate?.Invoke(task);
        }
        public void TestAction()
        {
            TestEvent?.Invoke();
        }
    }
    internal class Program
    {
        static void HardWork(ActionDelegate action)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Operation {i + 1} working.....");
                Thread.Sleep(random.Next(500));
                Console.WriteLine($"Operation {i + 1} finished.....");
            }
            action?.Invoke();
            // Console.WriteLine(); // another message
        }
        static void Action1()
        {
            Console.WriteLine("You are very good worker!!!");
        }
        static void Action2()
        {
            Console.WriteLine("You are normal worker!!!");
        }
        static void Action3()
        {
            Console.WriteLine("You are loser!!!");
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    FirstName = "Bill",
                    LastName = "Tomson",
                    Birthday = new DateTime(2005, 4, 7)
                },
                new Student
                {
                    FirstName = "Olga",
                    LastName = "Ivanchuk",
                    Birthday = new DateTime(2003, 10, 17)
                },
                new Student
                {
                    FirstName = "Candice",
                    LastName = "Leman",
                    Birthday = new DateTime(2006, 3, 12)
                },
                new Student
                {
                    FirstName = "Nicol",
                    LastName = "Taylor",
                    Birthday = new DateTime(2004, 7, 14)
                }
            };
            Teacher teacher = new Teacher();

            foreach (Student student in students)
            {
                teacher.ExamDelegate += student.PassExam;
            }
            teacher.ExamDelegate -= students[3].PassExam;
            // teacher.ExamDelegate = null;

            teacher.CreateExam("C# exam at 18 o`clock 20.07.2024 in 36 auditory");

            teacher.TestEvent += Console.Clear;
            teacher.TestEvent -= Console.Clear;
            teacher.TestEvent += delegate() { Console.ForegroundColor = ConsoleColor.Cyan; };
            teacher.TestEvent += delegate() { Console.BackgroundColor = ConsoleColor.Red; };
            teacher.TestEvent -= delegate() { Console.BackgroundColor = ConsoleColor.Red; };
            teacher.TestEvent += () => Console.Beep(100, 500);
            teacher.TestEvent += Teacher_TestEvent;
            teacher.TestAction();

            


            //HardWork(Action1);
            //HardWork(Action2);
            //HardWork(Action3);
            //HardWork(null);
        }

        private static void Teacher_TestEvent()
        {
            Console.WriteLine("Auto-created method by pressing tab");
        }
    }
}
