namespace _2024_06_14___Lesson__Enum_
{

    enum DAY_OF_WEEK
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    enum TRANSPORT_TYPE
    {
        Semitrailer, Coupling, Refrigeration, Open_side_truck, Tank
    }
    enum DISCOUNT
    {
        Default, Incentive = 2, Patron = 5, VIP = 15
    }
    class Program
    {
        public static DAY_OF_WEEK NextDay(DAY_OF_WEEK day)
        {
            return (day < DAY_OF_WEEK.Sunday) ? ++day : DAY_OF_WEEK.Monday;
        }
        static void Main(string[] args)
        {
            DAY_OF_WEEK day = DAY_OF_WEEK.Sunday;

            day = NextDay(day);

            //Console.WriteLine($"Next day (name) : {day.ToString()}");
            Console.WriteLine($"Next day (name) : {day}");
            Console.WriteLine($"Next day (value) : {(int)day}");



            string[] names = Enum.GetNames(typeof(TRANSPORT_TYPE));

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            DISCOUNT[] values = (DISCOUNT[])Enum.GetValues(typeof(DISCOUNT));

            foreach (DISCOUNT item in values)
            {
                Console.WriteLine($"{item} - {(int)item}")
            }
        }
    }
}
