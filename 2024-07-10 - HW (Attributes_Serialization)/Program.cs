using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace _2024_07_10___HW__Attributes_Serialization_
{
    class User
    {
        [Required(ErrorMessage = "Id not setted")]
        [Range(1000, 9999, ErrorMessage = "Id out of range")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = 1000;
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
        [Required]
        [RegularExpression(@"^[A-Z]+[a-z]*$", ErrorMessage = "Incorrect Login")]
        public string Login { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-z]*$", ErrorMessage = "Incorrect Password")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Illegal length")]
        public string Password { get; set; }
        [Required]
        [Compare(nameof(Password), ErrorMessage = "Not confirm password")]
        [RegularExpression(@"^[A-Z]+[a-z]*$", ErrorMessage = "Incorrect Confirm Password")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Illegal length")]
        public string ConfirmPassword { get; set; }
        [RegularExpression(@"^\d+$", ErrorMessage = "Incorrect Confirm Password")]
        [StringLength(16, ErrorMessage = "Illegal length")]
        public string CreditCard { get; set; }
    }

    internal class Program
    {
        enum MENU { ADD = 1, REMOVE, SAVE, LOAD, EXIT }
        static void Main(string[] args)
        {
            Dictionary<int, User> users = new Dictionary<int, User>();
            User user = new User();
            bool isValid;
            bool isExit = false;
            int choice = 0;
            while (!isExit)
            {
                Console.Write("1 - Add user\n2 - Delete user" +
                    "\n3 - Save users to file\n4 - Load users from file" +
                    "\n5 - Exit\nEnter your choice : ");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        isValid = true;
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

                            Console.WriteLine("Enter card number");
                            string creditCard = Console.ReadLine()!;

                            Console.Clear();

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
                            if (!(isValid = Validator.TryValidateObject(user, contex, result, true)))
                            {
                                foreach (ValidationResult error in result)
                                {
                                    Console.WriteLine(error.MemberNames.FirstOrDefault() + ": " + error.ErrorMessage);
                                }
                            }
                            Console.WriteLine();

                        } while (!isValid);
                    case 2:
                        Console.WriteLine();
                    case 3:
                        Console.WriteLine();
                    case 4:
                        Console.WriteLine();
                    case 5:
                        isExit = true;
                    default:
                        Console.WriteLine("Invalid choice\n");
                }
            }
        }
    }
}