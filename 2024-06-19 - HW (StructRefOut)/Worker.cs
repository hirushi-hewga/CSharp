using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_06_19___HW__StructRefOut_
{
    partial class Worker
    {
        private Fullname full_name;
        private int age;
        private int salary;
        private DateTime date_of_employment;
        public string[] Full_name
        {
            private get { return new string[] { full_name.surname, full_name.name, full_name.lastname }; }
            set
            {
                full_name.name = value[0];
                full_name.surname = value[1];
                full_name.lastname = value[2];
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    age = Math.Abs(value);
            }
        }
        public int Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                    salary = value;
                else
                    salary = Math.Abs(value);
            }
        }
        public DateTime Date_of_employment
        {
            private get { return date_of_employment; }
            set
            {
                if (value < DateTime.Now)
                    date_of_employment = value;
                else
                    throw new Exception("Incorrect date");
            }
        }
        public Worker()
        {
            Full_name = new string[] { "no name", "no surname", "no lastname" };
            Age = 0;
            Salary = 0;
            Date_of_employment = new DateTime();
        }
        public Worker(string[] fullname, int age, int salary, DateTime date_of_employment)
        {
            Full_name = fullname;
            Age = age;
            Salary = salary;
            Date_of_employment = date_of_employment;
        }
    }
}
