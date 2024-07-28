namespace _2024_07_05___HW__Dictionary_
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
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
            if (!phoneBook.ContainsKey(phone_number))
            {
                phoneBook.Add(phone_number, new User { Name = user_name, Surname = user_surname });
            }
            else { Console.WriteLine($"\nNumber {phone_number} is already in the phone book\n"); }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
