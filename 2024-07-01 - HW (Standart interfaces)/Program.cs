using System.Collections;
using System.Reflection;
using System.Security.AccessControl;
using System.Threading.Channels;

namespace _2024_07_01___HW__Standart_interfaces_
{
    enum Genre
    {
        Comedy, Horror, Adventure, Drama
    }
    class Director : ICloneable
    {
        private string firstName;
        private string lastName;
        public string FirstName
        {
            get { return firstName; }
            set {
                if (!string.IsNullOrEmpty(value))
                    firstName = value;
                else
                    throw new ArgumentException();
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    lastName = value;
                else
                    throw new ArgumentException();
            }
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
    class Movie : IComparable<Movie>, ICloneable
    {
        private string title;
        private string country;
        private int year;
        private short rating;
        public string Title
        {
            get { return title; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    title = value;
                else
                    throw new ArgumentException();
            }
        }
        public Director Director { get; set; }
        public string Country
        {
            get { return country; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    country = value;
                else
                    throw new ArgumentException();
            }
        }
        public Genre Genre { get; set; }
        public int Year
        {
            get { return year; }
            set {
                if (value > 1800 && value < DateTime.Now.Year)
                    year = value;
                else
                    throw new ArgumentException();
            }
        }
        public short Rating
        {
            get { return rating; }
            set
            {
                if (value >= 1 && value <= 5)
                    rating = value;
                else
                    throw new ArgumentException();
            }
        }

        public object Clone()
        {
            Movie copy = (MemberwiseClone() as Movie)!;
            copy.Director = (Director.Clone() as Director)!;
            return copy;
        }

        public int CompareTo(Movie? other)
        {
            return Title.CompareTo(other!.Title);
        }

        public override string ToString()
        {
            return $"-------- Title : {Title} --------" +
                $"\nDirector : {Director}" +
                $"\n Country : {Country}" +
                $"\n   Genre : {Genre}" +
                $"\n    Year : {Year}" +
                $"\n  Rating : {new string('*', Rating)}\n";
        }
    }
    class CompareByRating : IComparer<Movie>
    {
        public int Compare(Movie? x, Movie? y)
        {
            return x!.Rating.CompareTo(y!.Rating);
        }
    }
    class CompareByYear : IComparer<Movie>
    {
        public int Compare(Movie? x, Movie? y)
        {
            return x!.Year.CompareTo(y!.Year);
        }
    }
    class Cinema : IEnumerable
    {
        private string address;
        public Movie[] Movies { get; set; }
        public string Address
        {
            get { return address; }
            set {
                if (!string.IsNullOrEmpty(value))
                    address = value;
                else
                    throw new ArgumentException();
            }
        }

        public Cinema(int movie_count)
        {
            Movies = new Movie[movie_count];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Movies.GetEnumerator();
        }

        public void Sort()
        {
            Array.Sort(Movies);
        }
        public void Sort(IComparer<Movie> comparer)
        {
            Array.Sort(Movies, comparer);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema(5);
            cinema.Movies[0] = new Movie
            {
                Title = "The BigLebowski",
                Director = new Director { FirstName = "Brothers", LastName = "Coen" },
                Country = "USA",
                Genre = Genre.Comedy,
                Year = 1998,
                Rating = 4
            };
            cinema.Movies[1] = new Movie
            {
                Title = "A Nightmare on Elm Street",
                Director = new Director { FirstName = "Ves", LastName = "Craiven" },
                Country = "USA",
                Genre = Genre.Horror,
                Year = 1984,
                Rating = 4
            };
            cinema.Movies[2] = new Movie
            {
                Title = "Indiana Jones: Raiders of the Lost Ark",
                Director = new Director { FirstName = "Stiven", LastName = "Spilberg" },
                Country = "USA",
                Genre = Genre.Adventure,
                Year = 1981,
                Rating = 4
            };
            cinema.Movies[3] = new Movie
            {
                Title = "Green Book",
                Director = new Director { FirstName = "Piter", LastName = "Farrelli" },
                Country = "USA",
                Genre = Genre.Drama,
                Year = 2018,
                Rating = 4
            };
            cinema.Movies[4] = new Movie
            {
                Title = "Clown",
                Director = new Director { FirstName = "John", LastName = "Wottenboro" },
                Country = "Canada",
                Genre = Genre.Horror,
                Year = 2014,
                Rating = 3
            };
            foreach (Movie movie in cinema)
            {
                Console.WriteLine(movie);
            }



            /* 
            Console.WriteLine("\n============ Sort by title ============\n");
            cinema.Sort();
            foreach (Movie movie in cinema)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine("\n============ Sort by rating ============\n");
            cinema.Sort(new CompareByRating());
            foreach (Movie movie in cinema)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine("\n============ Sort by year ============\n");
            cinema.Sort(new CompareByYear());
            foreach (Movie movie in cinema)
            {
                Console.WriteLine(movie);
            }
            */



            /*
            Movie copy = (Movie) cinema.Movies[2].Clone();
            Console.WriteLine($"================ Movie ================\n{cinema.Movies[2]}");
            Console.WriteLine($"================ Clone ================\n{copy}");
            copy.Title = "Parasite";
            copy.Director = new Director { FirstName = "Bong", LastName = "Joon-ho" };
            copy.Country = "South Korea";
            copy.Genre = Genre.Drama;
            copy.Year = 2019;
            copy.Rating = 5;
            Console.WriteLine($"================ Movie ================\n{cinema.Movies[2]}");
            Console.WriteLine($"================ Clone ================\n{copy}");
            */
        }
    }
}