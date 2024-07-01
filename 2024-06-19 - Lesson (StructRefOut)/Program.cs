namespace _2024_06_19___Lesson__StructRefOut_
{
    partial struct MyStruct
    {
        public int MyProperty { get; set; }
    }
    partial struct MyStruct
    {
        public int MyProperty1 { get; set; }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    internal class Program
    {
        static void MethodWithParams(string name, params int[] marks)
        {
            Console.WriteLine("----------------" + name + "----------------");
            foreach (var item in marks)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }
        static void Modify(ref int num, ref string str, ref Point p)
        {
            num += 1;
            str += "!";
            p.X++;
            p.Y++;
        }
        static void GetCurrentTime(ref int hour, ref int minutes, ref int seconds)
        {
            hour = DateTime.Now.Hour;
            minutes = DateTime.Now.Minute;
            seconds = DateTime.Now.Second;
        }
        static void Main(string[] args)
        {
            int h = 0, m = 0, s = 0;
            GetCurrentTime(ref h, ref m, ref s);
            Console.WriteLine($"{h}:{m}:{s}");



            //int num = 10;
            //string str = "Hello academy";
            //Point point = new Point() { X = 7, Y = 10 };
            //Console.WriteLine($"Num : {num}");
            //Console.WriteLine($"Str : {str}");
            //Console.WriteLine($"Point : X = {point.X} ,  Y = {point.Y}");
            //Modify(ref num, ref str, ref point);
            //Console.WriteLine($"Num : {num}");
            //Console.WriteLine($"Str : {str}");
            //Console.WriteLine($"Point : X = {point.X} ,  Y = {point.Y}");



            // ref == & - references



            //int[] marks = new int[] { 11, 12, 7, 4, 8, 9, 6 };
            //MethodWithParams("Bob", marks);

            //MethodWithParams("Tom", new int[] { 11, 12, 7, 4, 8, 9, 6 });
            //MethodWithParams("Ivanka", 11, 12, 4, 7, 8, 10, 11, 12, 12, 12, 10, 10, 1, 1, 1, 3, 12, 12, 10);



            //Point p = new Point();
            //_3D_objects_.Point point = new _3D_objects_.Point();
        }
    }
}
namespace _3D_objects_
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }
}
