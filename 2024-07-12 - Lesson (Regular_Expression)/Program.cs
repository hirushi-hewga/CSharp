using System.Text.RegularExpressions;

namespace _2024_07_12___Lesson__Regular_Expression_
{
    /* 
    СПЕЦ.СИМВОЛИ
    \d - Визначає символи цифр.
    \D - Визначає любий символ, який не є цифрою. 
    \w - Визначає любий символ цифри, букви або нижнє підкреслення. 
    \W - Визначає любий символ, який не є цифрою, буквою або нижнім підкресленням.. 
    \s - Визначає любий недрукований символ, включаючи пробіл. (таб і перехід на новий рядок)
    \S - Визначає любий символ, крім символів табуляции, нового рядка и повернення каретки.
    .  - Визначає любий символ крім символа нового рядка.
    \. - Визначає символ крапки.
    */

    /*
    КВАНТИФИКАТОРЫ
    ^ - з початку рядка.
    $ - з кінця рядка.
    * - нуль і більше входжень підшаблону в сторці.
    + - одне і більше входжень підшаблону в сторці.
    ? - нуль чи одне входження підшаблону в сторці.
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string pattern = @"\d";
            var regex = new Regex(pattern);

            bool flag = true;

            while (flag)
            {
                string str = Console.ReadKey().KeyChar.ToString();
                if (str == " ")
                {
                    flag = false;
                }
                bool succes = regex.IsMatch(str);
                Console.WriteLine(succes ? "  match found {0}" : "  match not found {0}", pattern);

            }
            */


            /*
            //string pattern = @"\d";
            //string pattern = @"\d+";
            //string pattern = @"^\d+";
            //string pattern = @"\d+$";

            string pattern = @"^\d+$";
            var regex = new Regex(pattern);
            var arr = new[] { "test", "123", "test123test", "123test123", "test123" };

            foreach (string element in arr)
            {
                Console.WriteLine(regex.IsMatch(element) ? $"  String {element} matched {pattern}" :
                    $"  String {element} not matched {pattern}");
                Console.WriteLine();
            }
            pattern = "^[A-Z]+[a-z]*$";
            regex = new Regex(pattern);
            while (true)
            {
                Console.WriteLine("Enter string : ");
                string input = Console.ReadLine();
                if (input == "exit")
                {
                    break;
                }
                Console.WriteLine(input != null && regex.IsMatch(input) ? $"  String {input} matched {pattern}" :
                    $"  String {input} not matched {pattern}");
                Console.WriteLine();
            }
            */

            /*
            Match m = Regex.Match("123 Axx-1-xxy \n Axyx-2xyxyxy", @"A.*y");
            if (m.Success)
            {
                Console.WriteLine("Value = " + m.Value);
                Console.WriteLine("Length = " + m.Length);
                Console.WriteLine("Index = " + m.Index);
            }
            m = m.NextMatch();
            if (m.Success)
            {
                Console.WriteLine("Value = " + m.Value);
                Console.WriteLine("Length = " + m.Length);
                Console.WriteLine("Index = " + m.Index);
            }
            else
            {
                Console.WriteLine("Error");
            }
            */

            /*
            string value = "4 - 5 AND 5 y 789";
            Match match = Regex.Match(value, @"\d");
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }
            match = match.NextMatch();
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }

            while (match.Success)
            {
                Console.WriteLine(match.Value);
                match = match.NextMatch();
            }
            */


            string value1 = @"saidsaid said shed shed see sreap spear spear super";
            MatchCollection matchCollection = Regex.Matches(value1, @"s\w+d");
            foreach (Match item in matchCollection)
            {
                Console.WriteLine($"Index {item.Index} , Value {item.Value}");
            }
            string str = "Don`t replace Dot Not Nit Net replaced Net Net dots";
            string newstr = Regex.Replace(str, "N.t", "NET");
            Console.WriteLine(str);
            Console.WriteLine(newstr);
        }
    }
}
