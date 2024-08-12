using static System.Console;
namespace _2024_07_15___HW__Intro_to_Design_Pattern_
{
    #region Processor

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

    class AmdProcessor : Processor
    {
        public AmdProcessor(string name) : base(name) { }
        public override void Print()
        {
            WriteLine(ToString());
        }
    }

    class IntelProcessor : Processor
    {
        public IntelProcessor(string name) : base(name) { }
        public override void Print()
        {
            WriteLine(ToString());
        }
    }

    #endregion

    #region MainBoard

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

    class AsusMainBord : MainBoard
    {
        public AsusMainBord(string name) : base(name) { }
        public override void Print()
        {
            WriteLine(ToString());
        }
    }

    class MSIMainBord : MainBoard
    {
        public MSIMainBord(string name) : base(name) { }
        public override void Print()
        {
            WriteLine(ToString());
        }
    }

    #endregion

    #region Box

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

    class BlackBox : Box
    {
        public BlackBox(string name) : base(name) { }
        public override void Print()
        {
            WriteLine(ToString());
        }
    }

    class SilverBox : Box
    {
        public SilverBox(string name) : base(name) { }
        public override void Print()
        {
            WriteLine(ToString());
        }
    }

    #endregion

    #region Hdd

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

    class LGHDD : Hdd
    {
        public LGHDD(string name) : base(name) { }
        public override void Print()
        {
            WriteLine(ToString());
        }
    }

    class SamsungHDD : Hdd
    {
        public SamsungHDD(string name) : base(name) { }
        public override void Print()
        {
            WriteLine(ToString());
        }
    }

    #endregion

    #region Memory

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

    class DdrMemory : Memory
    {
        public DdrMemory(string name) : base(name) { }
        public override void Print()
        {
            WriteLine(ToString());
        }
    }

    class Ddr2Memory : Memory
    {
        public Ddr2Memory(string name) : base(name) { }
        public override void Print()
        {
            WriteLine(ToString());
        }
    }

    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
