namespace _2024_06_17___Lesson__Intro_to_OOP_
{
    // Access spetificator
    /*
        *private (default for all fields)
        *public
        *protected
        *internal
        *protected internal
    */
    class MyClass
    {
        // private:
        private int number;
        private string name;
        private const float pi = 3.14f;
        private readonly int id = 10;
        public MyClass()
        {
            id = 10;
        }
        /*
        public void setId(int id)
        {
            this.id = id;
        }
        */
        public void Print()
        {
            Console.WriteLine($"Name : {name}. Id : {id}");
        }
        public override string ToString()
        {
            return $"Name : {name}. Id : {id}";
        }
    }
    class DerivedClass : MyClass // public
    {

    }
    class Point
    {
        private int x_coord;

        // Properties
        public int X_coord // int value
        {
            get { return x_coord; }
            set {
                if (value > 0)
                    x_coord = value;
                else
                    x_coord = Math.Abs(value);
            }
        }


        /*
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        */
        //Auto property | prop + Tab
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; } // readonly property
        public string Color { get; private set; } = "White";


        //Full property | propfull + Tab
        private int yCoord;

        public int YCoord
        {
            get { return yCoord; }
            set
            {
                if (value >= 0)
                    yCoord = value;
                else
                    yCoord = Math.Abs(value);
            }
        }
        static int count;
        static Point()
        {
            count = 0;
        }


        private int y_coord;
        public Point() : this(0, 0) {}
        /*
        {
            x_coord = 0;
            y_coord = 0;
        }
        */
        public Point(int value) : this(value, value) {}
        /*
        {
            x_coord = value;
            y_coord = value;
        }
        */
        public Point(int x, int y)
        {
            SetX(x);
            SetY(y);
        }
        public void Print()
        {
            Console.WriteLine($"X : {x_coord}. Y : {y_coord}");
        }
        public override string ToString()
        {
            return $"X : {x_coord}. Y : {y_coord}";
        }
        public void SetX(int x)
        {
            if (x > 0)
                x_coord = x;
            else
                x_coord = Math.Abs(x);
        }
        public void SetY(int y)
        {
            if (y > 0)
                y_coord = y;
            else
                y_coord = Math.Abs(y);
        }
        public int GetX() { return x_coord; }
        public int GetY() { return y_coord; }
    }
    struct MyStruct // public
    {
        public int x;
        public int y;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            MyClass my_class = new MyClass();
            my_class.Print();
            Console.WriteLine(my_class);
            */

            Point p = new Point(-8, -12);
            p.Print();
            Console.WriteLine(p);
            p.SetX(100);
            p.SetY(200);
            Console.WriteLine("X : {0}", p.GetX());
            Console.WriteLine("Y : {0}", p.GetY());
            Console.WriteLine(p);

            p.X_coord = 333;
            int x = p.X_coord;
            Console.WriteLine(x);
            Console.WriteLine(p.X_coord);

            p.Name = "2D_Point"; // set
            Console.WriteLine(p.Name); // get
        }
    }
}
