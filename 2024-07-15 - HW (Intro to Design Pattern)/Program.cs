using static System.Console;
namespace _2024_07_15___HW__Intro_to_Design_Pattern_
{
    abstract class Processor
    {
        public string Name { get; set; }
        public Processor(string name)
        {
            Name = name;
        }
        public abstract void Print();
        public override string ToString()
        {
            return $"Name : {Name}";
        }
    }
    abstract class MainBoard
    {
        public string Name { get; set; }
        public MainBoard(string name)
        {
            Name = name;
        }
        public abstract void Print();
        public override string ToString()
        {
            return $"Name : {Name}";
        }
    }
    abstract class Box
    {
        public string Name { get; set; }
        public Box(string name)
        {
            Name = name;
        }
        public abstract void Print();
        public override string ToString()
        {
            return $"Name : {Name}";
        }
    }
    abstract class Hdd
    {
        public string Name { get; set; }
        public Hdd(string name)
        {
            Name = name;
        }
        public abstract void Print();
        public override string ToString()
        {
            return $"Name : {Name}";
        }
    }
    abstract class Memory
    {
        public string Name { get; set; }
        public Memory(string name)
        {
            Name = name;
        }
        public abstract void Print();
        public override string ToString()
        {
            return $"Name : {Name}";
        }
    }
    class AmdProcessor : Processor
    {
        public AmdProcessor(string name) : base(name) { }
        public override void Print()
        {
            WriteLine(ToString());
        }
    }
    class AsusMainBord : MainBoard
    {
        public AsusMainBord(string name) : base(name) { }
        public override void Print()
        {
            WriteLine(ToString());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
