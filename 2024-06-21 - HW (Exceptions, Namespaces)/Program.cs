using static System.Console;
namespace _2024_06_21___HW__Exceptions__Namespaces_
{
    class LengthException : Exception
    {
        public LengthException(string message) : base(message) { }
    }
    class InvalidValueException : Exception
    {
        public InvalidValueException(string message) : base(message) { }
    }
    partial class CreditCard
    {
        public override string ToString()
        {
            return $"Card number : {Card_number}  |  Owner fullname : {Owner_full_name.surname}-{Owner_full_name.name}-{Owner_full_name.lastname}  |  CVC : {Cvc}  |  Card expiration date : {Card_expiration_date.ToLongDateString()}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1
			try
			{
                Write("Enter number : ");
                string string_value = ReadLine();
                int value = int.Parse(string_value);
                WriteLine(value);
			}
			catch (OverflowException ex)
			{
                WriteLine("Out of range exception");
			}
            catch (FormatException ex)
            {
                WriteLine("Data type exception");
            }
            catch (Exception ex)
            {
                WriteLine("Unknown exception");
            }
            */



            /* 2*/
            CreditCard[] cards =
            {
                new CreditCard("1111222233334444", new Fullname( "Andriy", "Ivanchuk", "Volodymyrovych" ), "123", new DateTime(2027, 11, 24)),
                new CreditCard("4444555566667777", new Fullname( "Oksana", "Lasich", "Yuriivna" ), "456", new DateTime(2028, 12, 23))
            };
            foreach (CreditCard card in cards)
            {
                WriteLine(card.ToString());
            }
        }
    }
}
