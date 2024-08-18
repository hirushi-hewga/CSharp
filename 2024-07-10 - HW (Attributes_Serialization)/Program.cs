using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Xml.Serialization;

namespace _2024_07_10___HW__Attributes_Serialization_
{
    class User
    {
        [Required(ErrorMessage = "Id not setted")]
        [Range(1000, 9999, ErrorMessage = "Id out of range")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name not setted")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Illegal length")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Age not setted")]
        [Range(1, 120, ErrorMessage = "Age is incorrect")]
        public int Age { get; set; }
        [RegularExpression(@"^\+38-0\d{2}-\d{3}-\d{2}-\d{2}$", ErrorMessage = "Incorrect phone number")]
        public string Phone { get; set; }
        [RegularExpression(@"^\w{4,}@\w+\.\w+$", ErrorMessage = "Incorrect Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Login not setted")]
        [RegularExpression(@"^[A-Z]+[a-z]*$", ErrorMessage = "Incorrect Login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Password not setted")]
        [RegularExpression(@"^[A-Z]+[a-z]*$", ErrorMessage = "Incorrect Password")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Illegal length")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm password not setted")]
        [Compare(nameof(Password), ErrorMessage = "Not confirm password")]
        [RegularExpression(@"^[A-Z]+[a-z]*$", ErrorMessage = "Incorrect Confirm Password")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Illegal length")]
        public string ConfirmPassword { get; set; }
        [RegularExpression(@"^\d+$", ErrorMessage = "Incorrect Confirm Password")]
        [StringLength(16, ErrorMessage = "Illegal length")]
        public string CreditCard { get; set; }
        public void Show()
        {
            Console.WriteLine($"====== Id : {Id} , Name : {Name} ======" +
                $"\nAge : {Age}\nPhone : {Phone}\nEmail : {Email}" +
                $"\nLogin : {Login}\nPassword : {Password}" +
                $"\nConfirm password : {ConfirmPassword}" +
                $"\nCredit card number : {CreditCard}\n");
        }
    }

    internal class Program
    {
        static void SaveToJson(Dictionary<int, User> users, string filePath)
        {
            string jsonString = JsonSerializer.Serialize(users);
            File.WriteAllText(filePath, jsonString);
        }
        static Dictionary<int, User> LoadFromJson(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            Dictionary<int, User> users = JsonSerializer.Deserialize<Dictionary<int, User>>(jsonString);
            return users;
        }
        static void Main(string[] args)
        {
            string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\users.json";
            Dictionary<int, User> users = new Dictionary<int, User>();
            bool isValid;
            bool isExit = false;
            int choice = 0;
            while (!isExit)
            {
                Console.Clear();
                Console.Write("1 - Add user\n2 - Delete user" +
                    "\n3 - Save users to file\n4 - Load users from file" +
                    "\n5 - Show users\n6 - Exit\nEnter your choice : ");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        isValid = false;
                        User user = new User();
                        do
                        {
                            Console.Write("Enter id : ");
                            int id = int.Parse(Console.ReadLine()!);

                            Console.Write("Enter name : ");
                            string name = Console.ReadLine()!;

                            Console.Write("Enter age : ");
                            int age = int.Parse(Console.ReadLine()!);

                            Console.Write("Enter Login : ");
                            string login = Console.ReadLine()!;

                            Console.Write("Enter password : ");
                            string password = Console.ReadLine()!;

                            Console.Write("Enter confirm password : ");
                            string confirmPassword = Console.ReadLine()!;

                            Console.Write("Enter email : ");
                            string email = Console.ReadLine()!;

                            Console.Write("Enter phone : ");
                            string phone = Console.ReadLine()!;

                            Console.Write("Enter card number : ");
                            string creditCard = Console.ReadLine()!;

                            Console.Clear();

                            user.Id = id;
                            user.Name = name;
                            user.Age = age;
                            user.Password = password;
                            user.ConfirmPassword = confirmPassword;
                            user.Email = email;
                            user.Phone = phone;
                            user.Login = login;
                            user.CreditCard = creditCard;

                            var result = new List<ValidationResult>();
                            var contex = new ValidationContext(user);
                            if (!(isValid = Validator.TryValidateObject(user, contex, result, true)) || users.ContainsKey(id))
                            {
                                foreach (ValidationResult error in result)
                                {
                                    Console.WriteLine(error.MemberNames.FirstOrDefault() + ": " + error.ErrorMessage);
                                }
                                if (users.ContainsKey(id))
                                    Console.WriteLine("Id: Id already exists");
                                Console.WriteLine("\n=====================\n");
                            }
                            else
                            {
                                isValid = true;
                                users.Add(id, user);
                            }
                        } while (!isValid);
                        break;
                    case 2:
                        if (users.Count == 0)
                        {
                            Console.Write("Dictionary is empty\n\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                        }
                        bool isFoundId = true;
                        int userId = 0;
                        do
                        {
                            foreach (var item in users)
                            {
                                Console.WriteLine("====== Id : {0} ======\nName : {1}\nAge : {2}\n", item.Key, item.Value.Name, item.Value.Age);
                            }
                            if (!isFoundId)
                                Console.WriteLine($"============================\n\nId \"{userId}\" does not exist\n");
                            Console.Write("Enter user id to delete : ");
                            userId = int.Parse(Console.ReadLine());
                            if (!users.ContainsKey(userId))
                                isFoundId = false;
                            else isFoundId = true;
                        }
                        while (!isFoundId);
                        users.Remove(userId);
                        break;
                    case 3:
                        if (users.Count == 0)
                        {
                            Console.Write("Dictionary is empty\n\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                        }
                        if (File.Exists(filePath))
                            File.Delete(filePath);
                        SaveToJson(users, filePath);
                        break;
                    case 4:
                        if (!File.Exists(filePath))
                        {
                            Console.Write("File not found\n\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                        }
                        users = LoadFromJson(filePath);
                        break;
                    case 5:
                        if (users.Count == 0)
                        {
                            Console.Write("Dictionary is empty\n\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                        }
                        foreach (User item in users.Values)
                        {
                            item.Show();
                        }
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case 6:
                        isExit = true; break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Goodbye.");
        }
    }
}