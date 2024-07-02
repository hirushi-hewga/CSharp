namespace _2024_06_19___HW__StructRefOut_
{
    struct Fullname
    {
        public string name;
        public string surname;
        public string lastname;
    }
    class Worker
    {
        Fullname full_name;
        int age;
        int salary;
        DateTime date_of_employment;
        public string[] Full_name
        {
            private get { return new string[] { full_name.surname, full_name.name, full_name.lastname }; }
            set {
                full_name.name = value[0];
                full_name.surname = value[1];
                full_name.lastname = value[2];
            }
        }
        public int Age
        {
            get { return age; }
            set {
                if (value >= 0)
                    age = value;
                else
                    age = Math.Abs(value);
            }
        }
        public int Salary
        {
            get { return salary; }
            set {
                if (value >= 0)
                    salary = value;
                else
                    salary = Math.Abs(value);
            }
        }
        public int[] Date_of_employment
        {
            get { return new int[] { date_of_employment.Year, date_of_employment.Month, date_of_employment.Day }; }
            set {
                date_of_employment = new DateTime(value[0], value[1], value[2]);
            }
        }
        public Worker(string[] fullname, int age, int salary, int[] date_of_employment)
        {
            Full_name = fullname;
            Age = age;
            Salary = salary;
            Date_of_employment = date_of_employment;
        }
        public override string ToString()
        {
            return $"Fullname : {Full_name[0]}.{Full_name[1][0]}.{Full_name[2][0]}" +
                $"  |  Age : {Age}  |  Salary : {Salary}  |  " +
                $"Date of employment : {Date_of_employment[0]}:{Date_of_employment[1]}:{Date_of_employment[2]}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
