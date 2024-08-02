using System.Text;

namespace _2024_07_05___HW__Dictionary_
{
    class User
    {
        private string name;
        private string surname;
        public string Name {
            get { return name; }
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("name");
                name = value;
            }
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("surname");
                surname = value;
            }
        }
        public User(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public override string ToString()
        {
            return $"{name} {surname}";
        }
    }
    class PhoneBook
    {
        private Dictionary<string, User> phoneBook;
        public PhoneBook()
        {
            phoneBook = new Dictionary<string, User>();
        }
        public void AddPhone(string phone_number, string user_name, string user_surname)
        {
            if (phoneBook.ContainsKey(phone_number))
            {
                Console.WriteLine($"\nNumber {phone_number} is already in the phone book\n");
            }
            else if (string.IsNullOrEmpty(phone_number))
            {
                throw new ArgumentNullException("phone number");
            }
            else { phoneBook.Add(phone_number, new User(user_name, user_surname)); }
        }
        public void ChangeName(string phone_number, string user_name)
        {
            phoneBook[phone_number].Name = user_name;
        }
        public void ChangeSurname(string phone_number, string user_surname)
        {
            phoneBook[phone_number].Surname = user_surname;
        }
        public void SearchByPhone(string phone_number)
        {
            if (!phoneBook.ContainsKey(phone_number))
                Console.WriteLine($"\nNumber {phone_number} not found in the phone book\n");
            else
                Console.WriteLine($"{phone_number} - {phoneBook[phone_number].ToString()}");
        }
        public void SearchByName(string user_name)
        {
            bool isFound = false;
            foreach (var item in phoneBook)
            {
                if (item.Value.Name == user_name)
                {
                    Console.WriteLine($"{item.Key} - {item.Value.ToString()}");
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"\nName {user_name} not found in the phone book\n");
            }
        }
        public void SearchBySurname(string user_surname)
        {
            bool isFound = false;
            foreach (var item in phoneBook)
            {
                if (item.Value.Surname == user_surname)
                {
                    Console.WriteLine($"{item.Key} - {item.Value.ToString()}");
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"\nSurname {user_surname} not found in the phone book\n");
            }
        }
        public void DeleteByNumber(string phone_number)
        {
            phoneBook.Remove(phone_number);
        }
        public void ShowAll()
        {
            Console.WriteLine("=================== All ==================");
            foreach (var item in phoneBook)
            {
                Console.WriteLine($"{item.Key} - {item.Value.ToString()}");
            }
            Console.WriteLine("==========================================");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PhoneBook

            /*
            PhoneBook phoneBook = new PhoneBook();
            try
            {
                phoneBook.AddPhone("123456789", "Olga", "Petruk");
                phoneBook.AddPhone("124555457", "Ilya", "Gorchak");
                phoneBook.AddPhone("323667856", "Ivan", "Grozniy");
                phoneBook.AddPhone("987654321", "Petro", "Shevchenko");
            }
            catch (ArgumentNullException ex) { Console.WriteLine(ex.Message); }
            catch (Exception ex) { Console.WriteLine("Unknown exception..."); }
            phoneBook.ShowAll();
            phoneBook.ChangeName("124555457", "Amadey");
            phoneBook.ChangeSurname("123456789", "Tuz");
            phoneBook.ShowAll();
            phoneBook.SearchByPhone("123456789");
            phoneBook.SearchByName("Amadey");
            phoneBook.SearchBySurname("Shevchenko");
            phoneBook.DeleteByNumber("323667856");
            phoneBook.ShowAll();
            */

            #endregion

            #region Statistic

            /*
            Console.OutputEncoding = Encoding.UTF8;
            string text = "Ось будинок, який збудував Джек. А це пшениця, " +
                "яка у темній коморі зберігається у будинку, який збудував " +
                "Джек. А це веселий птах-синиця, який часто краде пшеницю, " +
                "яка у темній коморі зберігається у будинку, який збудував Джек.";
            Dictionary<string, int> Statistic = new Dictionary<string, int>();
            string[] words = text.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (Statistic.ContainsKey(words[i]))
                    Statistic[words[i]]++;
                else
                    Statistic.Add(words[i], 1);
            }
            Console.WriteLine(text);
            Console.WriteLine();
            foreach (var item in Statistic)
            {
                Console.WriteLine("{0} - {1}", item.Value, item.Key);
            }
            */

            #endregion
        }
    }
}
