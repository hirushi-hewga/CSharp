using System.Security.AccessControl;

namespace _2024_07_01___HW__Standart_interfaces_
{
    class Director
    {

    }
    class Movie
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Director director { get; set; }
        public string Country { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }
    }
    class Cinema
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
