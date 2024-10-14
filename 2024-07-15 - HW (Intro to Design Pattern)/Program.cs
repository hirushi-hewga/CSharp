using System.Reflection;
using static System.Console;
namespace _2024_07_15___HW__Intro_to_Design_Pattern_
{
    #region Processor

    abstract class Processor
    {
        public string Model { get; set; }
        public Processor(string model)
        {
            Model = model;
        }
        public abstract void Print();
    }

    class AmdProcessor : Processor
    {
        public AmdProcessor(string model) : base(model) { }
        public override void Print()
        {
            WriteLine($"Processor : {Model}");
        }
    }

    class IntelProcessor : Processor
    {
        public IntelProcessor(string model) : base(model) { }
        public override void Print()
        {
            WriteLine($"Processor : {Model}");
        }
    }

    #endregion

    #region MainBoard

    abstract class MainBoard
    {
        public string Model { get; set; }
        public MainBoard(string model)
        {
            Model = model;
        }
        public abstract void Print();
    }

    class AsusMainBord : MainBoard
    {
        public AsusMainBord(string model) : base(model) { }
        public override void Print()
        {
            WriteLine($"MainBoard : {Model}");
        }
    }

    class MSIMainBord : MainBoard
    {
        public MSIMainBord(string model) : base(model) { }
        public override void Print()
        {
            WriteLine($"MainBoard : {Model}");
        }
    }

    #endregion

    #region Box

    abstract class Box
    {
        public string Model { get; set; }
        public Box(string model)
        {
            Model = model;
        }
        public abstract void Print();
    }

    class BlackBox : Box
    {
        public BlackBox(string model) : base(model) { }
        public override void Print()
        {
            WriteLine($"Box : {Model}");
        }
    }

    class SilverBox : Box
    {
        public SilverBox(string model) : base(model) { }
        public override void Print()
        {
            WriteLine($"Box : {Model}");
        }
    }

    #endregion

    #region Hdd

    abstract class Hdd
    {
        public string Model { get; set; }
        public Hdd(string model)
        {
            Model = model;
        }
        public abstract void Print();
    }

    class LGHDD : Hdd
    {
        public LGHDD(string model) : base(model) { }
        public override void Print()
        {
            WriteLine($"HDD : {Model}");
        }
    }

    class SamsungHDD : Hdd
    {
        public SamsungHDD(string model) : base(model) { }
        public override void Print()
        {
            WriteLine($"HDD : {Model}");
        }
    }

    #endregion

    #region Memory

    abstract class Memory
    {
        public string Model { get; set; }
        public Memory(string model)
        {
            Model = model;
        }
        public abstract void Print();
    }

    class DdrMemory : Memory
    {
        public DdrMemory(string model) : base(model) { }
        public override void Print()
        {
            WriteLine($"Memory : {Model}");
        }
    }

    class Ddr2Memory : Memory
    {
        public Ddr2Memory(string model) : base(model) { }
        public override void Print()
        {
            WriteLine($"Memory : {Model}");
        }
    }

    #endregion


    interface IPcFactory
    {
        Box CreateBox();
        Processor CreateProcessor();
        MainBoard CreateMainBoard();
        Hdd CreateHdd();
        Memory CreateMemory();
    }

    class OfficePcFactory : IPcFactory
    {
        public Box CreateBox()
        {
            return new BlackBox("Black");
        }

        public Hdd CreateHdd()
        {
            return new LGHDD("LG");
        }

        public MainBoard CreateMainBoard()
        {
            return new AsusMainBord("Asus");
        }

        public Memory CreateMemory()
        {
            return new DdrMemory("DDR");
        }

        public Processor CreateProcessor()
        {
            return new AmdProcessor("AMD");
        }
    }

    class HomePcFactory : IPcFactory
    {
        public Box CreateBox()
        {
            return new SilverBox("Silver");
        }

        public Hdd CreateHdd()
        {
            return new SamsungHDD("Samsung");
        }

        public MainBoard CreateMainBoard()
        {
            return new MSIMainBord("MSI");
        }

        public Memory CreateMemory()
        {
            return new Ddr2Memory("DDR2");
        }

        public Processor CreateProcessor()
        {
            return new IntelProcessor("Intel");
        }
    }

    class PcConfigurator
    {
        public IPcFactory PcFactory { get; set; }
        public void Configure(Pc pc)
        {
            if (PcFactory == null)
                throw new InvalidOperationException("PcFactory must be assigned before configuring the PC");

            pc.Box = PcFactory.CreateBox();
            pc.Processor = PcFactory.CreateProcessor();
            pc.MainBoard = PcFactory.CreateMainBoard();
            pc.Hdd = PcFactory.CreateHdd();
            pc.Memory = PcFactory.CreateMemory();
        }
    }

    class Pc
    {
        public Box Box { get; set; }
        public Processor Processor { get; set; }
        public MainBoard MainBoard { get; set; }
        public Hdd Hdd { get; set; }
        public Memory Memory { get; set; }
        public override string ToString()
        {
            return $"Box : {Box.Model}" +
                 $"\nProcessor : {Processor.Model}" +
                 $"\nMain board : {MainBoard.Model}" +
                 $"\nHdd : {Hdd.Model}" +
                 $"\nMemory : {Memory.Model}";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            PcConfigurator homePcConfigurator = new PcConfigurator() { PcFactory = new HomePcFactory() };
            PcConfigurator officePcConfigurator = new PcConfigurator() { PcFactory = new OfficePcFactory() };
            Pc homePc = new Pc();
            Pc officePc = new Pc();
            homePcConfigurator.Configure(homePc);
            officePcConfigurator.Configure(officePc);
            
            WriteLine($"------ Home Pc ------" +
                      $"\n{homePc.ToString()}");

            WriteLine($"\n------ Office Pc ------" +
                      $"\n{officePc.ToString()}");
        }
    }
}
