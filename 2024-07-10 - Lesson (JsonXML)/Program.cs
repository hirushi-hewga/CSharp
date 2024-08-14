using System.Text.Json;
using System.Xml.Serialization;

namespace _2024_07_10___Lesson__JsonXML_
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        private int _identNumber;
        const string Planet = "Earth";
        public Person(int number)
        {
            _identNumber = number;
        }
        public override string ToString()
        {
            return $"Name {Name}\nAge : {Age}\nIdentification number : {_identNumber}\n" +
                $"Planet {Planet}\n";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Person> persons = new List<Person>()
            {
                new Person(369852) { Name = "Jack", Age = 22},
                new Person(369852) { Name = "Bob", Age = 27},
                new Person(369852) { Name = "Tom", Age = 12},
                new Person(369852) { Name = "Olga", Age = 4}
            };

            //try
            //{
            //    string fileName = "Person.json";

            //    string jsonString = JsonSerializer.Serialize(persons);
            //    File.WriteAllText(fileName, jsonString);
            //    Console.WriteLine("JsonSerializer serializable is OK!!!!");
            //    //Person pr = null;
            //    jsonString = File.ReadAllText(fileName);

            //    List<Person> pr = JsonSerializer.Deserialize<List<Person>>(jsonString);


            //    foreach (Person p in pr)
            //    {
            //        Console.WriteLine(p);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            XmlSerializer xmlFormst = new XmlSerializer(typeof(List<Person>));
            try
            {

                using (Stream fstream = File.Create("persons.xml"))
                {
                    xmlFormst.Serialize(fstream, persons);
                }
                Console.WriteLine("XmlSerializer serializable is OK!!!!");
                //Person pr = null;
                List<Person> pr = null;

                using (Stream fstream = File.OpenRead("persons.xml"))
                {
                    //pr =  bf.Deserialize(fstream) as Person;
                    pr = (List<Person>)xmlFormst.Deserialize(fstream)!;
                }
                //Console.WriteLine(pr);
                foreach (Person p in pr)
                {
                    Console.WriteLine(p);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
