using System.ComponentModel.DataAnnotations;

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
        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-z]*$")]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare(nameof(Password), ErrorMessage = "Not confirm password")]
        public string ConfirmPassword { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, User> users = new Dictionary<int, User>();
            User user = new User();
            bool isValid = true;
            do
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine()!;

                Console.WriteLine("Enter age");
                int age = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Enter Login");
                string login = Console.ReadLine()!;

                Console.WriteLine("Enter password");
                string password = Console.ReadLine()!;

                Console.WriteLine("Confirm password");
                string confirmPassword = Console.ReadLine()!;

                Console.WriteLine("Enter email");
                string email = Console.ReadLine()!;

                Console.WriteLine("Enter phone");
                string phone = Console.ReadLine()!;

                user.Id = 1;
                user.Name = name;
                user.Age = age;
                user.Password = password;
                user.ConfirmPassword = confirmPassword;
                user.Email = email;
                user.Phone = phone;
                user.Login = login;

                var result = new List<ValidationResult>();
                var contex = new ValidationContext(user);
                if (!(isValid = Validator.TryValidateObject(user, contex, result, true)))
                {
                    foreach (ValidationResult error in result)
                    {
                        Console.WriteLine(error.MemberNames.FirstOrDefault() + ": " + error.ErrorMessage);
                    }
                }

            } while (!isValid);

            Console.WriteLine("Model is valid");
        }
    }
}