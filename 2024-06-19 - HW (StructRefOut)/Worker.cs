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
        
        public Worker()
        {
            Full_name = new Fullname();
            Age = 0;
            Salary = 0;
            Date_of_employment = new DateTime();
        }
        public Worker(Fullname fullname, int age, int salary, DateTime date_of_employment)
        {
            Full_name = fullname;
            Age = age;
            Salary = salary;
            Date_of_employment = date_of_employment;
        }
    }
    partial class Worker
    {
        public Fullname Full_name
        {
            private get { return full_name; }
            set
            {
                full_name.name = value.name;
                full_name.surname = value.surname;
                full_name.lastname = value.lastname;
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
                    throw new Exception("Incorrect age");
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
                    throw new Exception("Incorrect salary");
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
    }
}
