using System.Security.AccessControl;
using static System.Console;
namespace _2024_06_26___Lesson__Indexers_
{
    class Laptop
    {
        public string Model { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"Model : {Model} .  Price : {Price}";
        }
    }
    class Shop
    {
        Laptop[] laptops;
        public Shop(int size)
        {
            laptops = new Laptop[size];
        }
        public int Length
        {
            get { return laptops.Length; }
        }
        public Laptop GetLaptop(int index)
        {
            if (index >= 0 && index < laptops.Length)
                return laptops[index];
            throw new IndexOutOfRangeException();
        }
        public void SetLaptop(Laptop laptop, int index)
        {
            if (index >= 0 && index < laptops.Length)
                laptops[index] = laptop;
            else
                throw new IndexOutOfRangeException();
        }
        public Laptop this[int index]
        {
            get
            {
                if (index >= 0 && index < laptops.Length)
                    return laptops[index];
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < laptops.Length)
                    laptops[index] = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }
        public Laptop this[string name]
        {
            get
            {
                foreach (var item in laptops)
                {
                    if (item.Model == name)
                        return item;
                }
                return null;
            }
            private set
            {
                for (int i = 0; i < laptops.Length; i++)
                {
                    if (laptops[i].Model == name)
                    {
                        laptops[i] = value;
                        break;
                    }
                }
            }
        }
        public int FindByPrice(double price)
        {
            for(int i = 0; i < laptops.Length; i++)
            {
                if (laptops[i].Price == price)
                    return i;
            }
            return -1;
        }
        public Laptop this[double price]
        {
            get
            {
                int index = FindByPrice(price);
                if (index != -1)
                {
                    return laptops[index];
                }
                throw new Exception("Incorrect price");
            }
            set
            {
                int index = FindByPrice(price);
                if (index != -1)
                {
                    laptops[index] = value;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop(3);
            shop.SetLaptop(new Laptop() { Model = "HP", Price = 35425.99 }, 0);
            var laptop = shop.GetLaptop(0);
            WriteLine(laptop);

            //with indexer
            shop[1] = new Laptop() { Model = "DELL", Price = 15999.99 }; // set
            WriteLine(shop[1]); // get
            WriteLine();

            try
            {
                for (int i = 0; i < shop.Length; i++)
                {
                    WriteLine(shop[i]);
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            // shop["HP"] = new Laptop() { Model = "MAC", Price = 150000.99 };
            // WriteLine(shop["MAC"]);

            shop[15999.99] = new Laptop() { Model = "Samsung", Price = 42000 };
            WriteLine(shop[42000.00]);
        }
    }
}
