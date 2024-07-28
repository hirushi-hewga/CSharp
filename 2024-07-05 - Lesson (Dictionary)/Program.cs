namespace _2024_07_05___Lesson__Dictionary_
{
    class User
    {
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("UA", "Ukraine");
            dic.Add("USA", "United States of America");
            dic.Add("UK", "United Kingdoms");
            dic.Add("FR", "France");
            dic.Add("IT", "Italy");

            foreach (KeyValuePair<string, string> item in dic)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }

            string country = dic["USA"]; // get
            Console.WriteLine(country);
            Console.WriteLine();
            dic["USA"] = "America"; // set
            dic["IN"] = "India";
            dic.Remove("FR");

            foreach (KeyValuePair<string, string> item in dic)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
            */




            Dictionary<char, User> people = new Dictionary<char, User>();
            people.Add('b', new User() { Name = "Bob" });
            people.Add('t', new User() { Name = "Tom" });
            people.Add('j', new User() { Name = "Jack" });
            people.Add('r', new User() { Name = "Rita" });

            foreach (KeyValuePair<char, User> item in people)
            {
                Console.WriteLine(item.Key + " - " + item.Value.Name);
            }

            if (people.ContainsKey('r'))
            {
                people['r'].Name = "Roma";
            }

            foreach (KeyValuePair<char, User> item in people)
            {
                Console.WriteLine(item.Key + " - " + item.Value.Name);
            }

            foreach (var item in people.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (var item in people.Values)
            {
                Console.WriteLine(item.Name);
            }



        }
    }
}
